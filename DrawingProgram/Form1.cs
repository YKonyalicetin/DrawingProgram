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
            //getting coordinates
            mouseX = e.X;
            mouseY = e.Y;
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
                else
                {
                    DrawStickMan();
                }

                PbSurface.Invalidate(); //calls the paint event

            }
        }

        private void DrawStickMan()
        {
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, mouseY1 - mouseY, mouseY1 - mouseY);
        }

        private void DrawStickLady()
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
