using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingProgram
{
    public partial class Form1 : Form
    { 
        //adding drawing pen
        Pen drawingPen;

        //=======================
        // Global Variables
        //=======================

        //mouse positions
        int mouseX, mouseY, mouseX1, mouseY1;

        //boolean flags for which stick figure has been selected to be drawn
        bool drawStickManStraight = false;
        bool drawStickManArmsUp = false;
        bool drawStickManArmsDown = false;
        bool drawStickWoman = false;
        bool drawRunningMan = false;

        //Bitmap and Graphics Objects
        Bitmap bitmapObject;
        Graphics graphicsObject;

        //Stack For Undo Redo Buttons
        readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();

        //variables for second form where text is drawn
        public static string theText;
        public static Font theFont;
        public static Color theFontColor;


        public Form1()
        {
            InitializeComponent();

           
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //changing mouse cursor
            PbSurface.Cursor = Cursors.Cross;

            //===================================================================
            // Setting up Drawing Pen
            //===================================================================

            drawingPen = new Pen(Color.Black); //black by default
            drawingPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; //solid dash style by default
            drawingPen.Width = TrackBrushSize.Value; //width depends on Trackbar

            //===================================================================
            // Setting Bitmap and Graphics Objects and a default stick figure to draw
            //===================================================================

            bitmapObject = new Bitmap(PbSurface.Width, PbSurface.Height);
            graphicsObject = Graphics.FromImage(bitmapObject);

            drawStickManStraight = true;

            //====================================================================
            //Loading Combobox with Colors
            //====================================================================

            //foreach loop through colors in order to load system known colors to combobox
            foreach (KnownColor inbuiltcolor in Enum.GetValues(typeof(KnownColor)))
            
            //'KnownColor' is Enumeration, therefore 'Enum' is needed after keyword 'in'
            //'GetValues' is a method of 'Enum'
            //typeof is needed because of the attempt to access data in an enumeration (KnownColor)
            {
                // converting the KnownColor enumeration to a usable Color
                Color loadColor = Color.FromKnownColor(inbuiltcolor);

                //getting rid of unnecessary Transparent colors
                if (loadColor.IsSystemColor == false)
                {
                    if (loadColor.Name != "Transparent")
                    {
                        cmbColors.Items.Add(loadColor.Name);
                    }
                }
            }
        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changing color of oversized label to the color selected from the ComboBox
            labelColor.BackColor = Color.FromName(cmbColors.SelectedItem.ToString());
            
            //changing Pen Color to the selected one
            drawingPen.Color = Color.FromName(cmbColors.SelectedItem.ToString());

        }

        private void BtnCustomColor_Click(object sender, EventArgs e)
        {
            if(ColorDB.ShowDialog() != DialogResult.Cancel)
            {
                labelColor.BackColor = ColorDB.Color;
                drawingPen.Color = ColorDB.Color;
            }
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Blue;
            drawingPen.Color = Color.Blue;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Red;
            drawingPen.Color = Color.Red;
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Yellow;
            drawingPen.Color = Color.Yellow;
        }

        private void BtnGrey_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Gray;
            drawingPen.Color = Color.Gray;
        }

        private void PbSurface_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                int rightClickX = e.X;
                int rightClickY = e.Y;

                FormText textForm = new FormText();
                if (textForm.ShowDialog() == DialogResult.OK)
                {
                    //undo and redo
                    UndoStack.Push((Bitmap)bitmapObject.Clone());
                    RedoStack.Clear();

                    //passing values obtained from form2
                    Font chosenFont = new Font( theFont.FontFamily,
                                                theFont.Size,
                                                theFont.Style);

                    //setting up brush with passed fontcolor
                    Brush chosenBrush = new SolidBrush(theFontColor);

                    //anti aliasing smoothens out the pixels
                    graphicsObject.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                   //Drawing the Text with chosen font, brush and at position of the right Click
                    graphicsObject.DrawString(theText, chosenFont, chosenBrush, rightClickX, rightClickY);

                    PbSurface.Invalidate();
                }
                textForm.Dispose();

            }
            else if (e.Button == MouseButtons.Left)
            {
                //getting coordinates
                mouseX = e.X;
                mouseY = e.Y;
            
                //Stacks for Undo and Redo Buttons
                UndoStack.Push((Bitmap)bitmapObject.Clone());
                RedoStack.Clear();

            }
        }

        private void PbSurface_MouseUp(object sender, MouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left)
            {
                //getting coordinates
                mouseX1 = e.X;
                mouseY1 = e.Y;

                graphicsObject.SmoothingMode = SmoothingMode.AntiAlias;

                if(drawStickWoman)
                {
                    DrawStickLady();
                }
                else if(drawRunningMan)
                {
                    DrawStickRunningMan();
                }
                else
                {
                    DrawStickMan();
                }

                PbSurface.Invalidate(); //calls the paint event

            }
        }

        private void DrawStickMan()
        {
            
            StickFigureDimensions size = new StickFigureDimensions(mouseY, mouseY1);
            //Head
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter);
            //Body
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + size.HeadDiameter,
                                                mouseX + size.HeadRadius,
                                                mouseY + size.HeadDiameter + size.BodySize);
            //Right Leg
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + (size.HeadDiameter + size.BodySize),
                                                mouseX + (size.HeadRadius + size.BaseUnit * 2),
                                                mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));

            //Left Leg
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + (size.HeadDiameter + size.BodySize),
                                                mouseX + (size.HeadRadius - size.BaseUnit * 2),
                                                mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));

            //Arms
            if (drawStickManStraight)
            {
                //Left Arm
                graphicsObject.DrawLine(drawingPen, mouseX,
                                        size.MidBody,
                                        mouseX + size.HeadRadius,
                                        size.MidBody);

                //Right Arm
                graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                        size.MidBody,
                                        mouseX + 2*size.HeadRadius,
                                        size.MidBody);
                                        
            }
            else if (drawStickManArmsUp)
            {

                //Left Arm
                graphicsObject.DrawLine(drawingPen, mouseX,
                                        size.MidBody - (size.BaseUnit * 2),
                                        mouseX + size.HeadRadius,
                                        size.MidBody);

                //Right Arm
                graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                        size.MidBody,
                                        mouseX + 2 * size.HeadRadius,
                                        size.MidBody - (size.BaseUnit * 2));

            }
            else if (drawStickManArmsDown)
            {
                
                //Left Arm
                graphicsObject.DrawLine(drawingPen, mouseX,
                                        size.MidBody + (size.BaseUnit * 2),
                                        mouseX + size.HeadRadius,
                                        size.MidBody);

                //Right Arm
                graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                        size.MidBody,
                                        mouseX + 2 * size.HeadRadius,
                                        size.MidBody + (size.BaseUnit * 2));

            }

        }

        private void DrawStickLady()
        {
            StickFigureDimensions size = new StickFigureDimensions(mouseY, mouseY1);

            //Triangle Body
            Point[] polygonPoints = new Point[3]; //setting up a new polygon of 3 points = triangle

            //zeroing out all points to set them again later
            polygonPoints[0] = new Point(0, 0);
            polygonPoints[1] = new Point(0, 0);
            polygonPoints[2] = new Point(0, 0);

            //first point
            polygonPoints[0].X = mouseX + size.HeadRadius;
            polygonPoints[0].Y = mouseY + (int)(size.HeadDiameter + drawingPen.Width);
            //second point
            polygonPoints[1].X = mouseX + size.HeadDiameter;
            polygonPoints[1].Y = mouseY + size.HeadDiameter + size.BodySize;
            //third point
            polygonPoints[2].X = mouseX;
            polygonPoints[2].Y = mouseY + size.HeadDiameter + size.BodySize;

            
            //Head
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter);

            //finally drawing out the body polygon
            graphicsObject.DrawPolygon(drawingPen, polygonPoints);

            //left arm
            graphicsObject.DrawLine(drawingPen, mouseX,
                                    size.MidBody,
                                    mouseX + (size.HeadRadius / 2),
                                    size.MidBody);

            //right arm
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75),
                                    size.MidBody,
                                    mouseX + size.HeadDiameter,
                                    size.MidBody);

            //left leg
            graphicsObject.DrawLine(drawingPen, mouseX + (size.HeadRadius / 2),
            mouseY + size.HeadDiameter + size.BodySize,
            mouseX + (size.HeadRadius / 2),
            mouseY + size.HeadDiameter + size.BodySize + size.LegSize);

            //right leg
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75),
            mouseY + size.HeadDiameter + size.BodySize,
            mouseX + (int)(size.HeadDiameter * 0.75),
            mouseY + size.HeadDiameter + size.BodySize + size.LegSize);


        }


        private void DrawStickRunningMan()
        {

        }

        private void btnArmsStraight_Click(object sender, EventArgs e)
        {
            drawStickManStraight = true;
            drawStickManArmsUp = false;
            drawStickManArmsDown = false;
            drawStickWoman = false;
            drawRunningMan = false;
        }

        private void btnArmsUp_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = true;
            drawStickManArmsDown = false;
            drawStickWoman = false;
            drawRunningMan = false;
        }

        private void btnArmsDown_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = false;
            drawStickManArmsDown = true;
            drawStickWoman = false;
            drawRunningMan = false;
        }

        private void btnStickWoman_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = false;
            drawStickManArmsDown = false;
            drawStickWoman = true;
            drawRunningMan = false;
        }

        private void btnRunningMan_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = false;
            drawStickManArmsDown = false;
            drawStickWoman = false;
            drawRunningMan = true;
        }

        private void PbSurface_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapObject, 0, 0);
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0) //undostack has a count property to count how many items are in stack
            {
                RedoStack.Push((Bitmap)bitmapObject.Clone());

                bitmapObject = UndoStack.Pop();
                graphicsObject = Graphics.FromImage(bitmapObject);

                PbSurface.Invalidate(); //redrawing previous picture
            }
            else
            {
                //MessageBox.Show("There is nothing to Undo Here.");
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0) //undostack has a count property to count how many items are in stack
            {
                UndoStack.Push((Bitmap)bitmapObject.Clone());

                bitmapObject = RedoStack.Pop();
                graphicsObject = Graphics.FromImage(bitmapObject);

                PbSurface.Invalidate(); //redrawing previous picture
            }
            else
            {
                //MessageBox.Show("There is nothing to Redo Here.");
            }
        }

        private void SaveDB_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SaveDB.ShowDialog() == DialogResult.OK)
            {
                string savePath = SaveDB.FileName;
                Bitmap bmpImage = new Bitmap(bitmapObject);

                bmpImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);

                bmpImage.Dispose();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            int stackCount = UndoStack.Count;
            int loopCount = 0;

            //clearing the drawing surface can be done by checking whether stack has something in it
            //if yes it will clear all the contents and leave a blank surface again
            if (UndoStack.Count > 0)
            {
                do
                {
                    bitmapObject = UndoStack.Pop();
                    graphicsObject = Graphics.FromImage(bitmapObject);
                    PbSurface.Invalidate();
                    loopCount++;
                } while (loopCount < stackCount);
            }
        }

        private void RadioSolid_Click(object sender, EventArgs e)
        {
            drawingPen.DashStyle = DashStyle.Solid;
        }

        private void RadioDashed_Click(object sender, EventArgs e)
        {
            drawingPen.DashStyle = DashStyle.Dash;
        }

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Black;
            drawingPen.Color = Color.Black;
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Lime;
            drawingPen.Color = Color.Lime;
        }

        private void TrackBrushSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TrackBrushSize.Value;
        }
    }
}
