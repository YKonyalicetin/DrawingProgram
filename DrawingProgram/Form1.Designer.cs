
namespace DrawingProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbSurface = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRunningMan = new System.Windows.Forms.Button();
            this.btnStickWoman = new System.Windows.Forms.Button();
            this.btnArmsDown = new System.Windows.Forms.Button();
            this.btnArmsUp = new System.Windows.Forms.Button();
            this.btnArmsStraight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.BtnCustomColor = new System.Windows.Forms.Button();
            this.BtnGrey = new System.Windows.Forms.Button();
            this.BtnBlack = new System.Windows.Forms.Button();
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnYellow = new System.Windows.Forms.Button();
            this.BtnRed = new System.Windows.Forms.Button();
            this.BtnBlue = new System.Windows.Forms.Button();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBrushSize = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RadioDashed = new System.Windows.Forms.RadioButton();
            this.RadioSolid = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRedo = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.ColorDB = new System.Windows.Forms.ColorDialog();
            this.SaveDB = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbSurface)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBrushSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbSurface
            // 
            this.PbSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PbSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSurface.Location = new System.Drawing.Point(0, 0);
            this.PbSurface.Name = "PbSurface";
            this.PbSurface.Size = new System.Drawing.Size(630, 420);
            this.PbSurface.TabIndex = 0;
            this.PbSurface.TabStop = false;
            this.PbSurface.Paint += new System.Windows.Forms.PaintEventHandler(this.PbSurface_Paint);
            this.PbSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbSurface_MouseDown);
            this.PbSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbSurface_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunningMan);
            this.groupBox1.Controls.Add(this.btnStickWoman);
            this.groupBox1.Controls.Add(this.btnArmsDown);
            this.groupBox1.Controls.Add(this.btnArmsUp);
            this.groupBox1.Controls.Add(this.btnArmsStraight);
            this.groupBox1.Location = new System.Drawing.Point(655, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stick Figures";
            // 
            // btnRunningMan
            // 
            this.btnRunningMan.BackgroundImage = global::DrawingProgram.Properties.Resources.m_running_right;
            this.btnRunningMan.Location = new System.Drawing.Point(6, 214);
            this.btnRunningMan.Name = "btnRunningMan";
            this.btnRunningMan.Size = new System.Drawing.Size(64, 64);
            this.btnRunningMan.TabIndex = 5;
            this.btnRunningMan.UseVisualStyleBackColor = true;
            this.btnRunningMan.Click += new System.EventHandler(this.btnRunningMan_Click);
            // 
            // btnStickWoman
            // 
            this.btnStickWoman.BackgroundImage = global::DrawingProgram.Properties.Resources.f_arms_straight;
            this.btnStickWoman.Location = new System.Drawing.Point(105, 122);
            this.btnStickWoman.Name = "btnStickWoman";
            this.btnStickWoman.Size = new System.Drawing.Size(64, 64);
            this.btnStickWoman.TabIndex = 4;
            this.btnStickWoman.UseVisualStyleBackColor = true;
            this.btnStickWoman.Click += new System.EventHandler(this.btnStickWoman_Click);
            // 
            // btnArmsDown
            // 
            this.btnArmsDown.BackgroundImage = global::DrawingProgram.Properties.Resources.m_arms_down;
            this.btnArmsDown.Location = new System.Drawing.Point(6, 122);
            this.btnArmsDown.Name = "btnArmsDown";
            this.btnArmsDown.Size = new System.Drawing.Size(64, 64);
            this.btnArmsDown.TabIndex = 3;
            this.btnArmsDown.UseVisualStyleBackColor = true;
            this.btnArmsDown.Click += new System.EventHandler(this.btnArmsDown_Click);
            // 
            // btnArmsUp
            // 
            this.btnArmsUp.BackgroundImage = global::DrawingProgram.Properties.Resources.m_arms_up;
            this.btnArmsUp.Location = new System.Drawing.Point(105, 30);
            this.btnArmsUp.Name = "btnArmsUp";
            this.btnArmsUp.Size = new System.Drawing.Size(64, 64);
            this.btnArmsUp.TabIndex = 2;
            this.btnArmsUp.UseVisualStyleBackColor = true;
            this.btnArmsUp.Click += new System.EventHandler(this.btnArmsUp_Click);
            // 
            // btnArmsStraight
            // 
            this.btnArmsStraight.BackgroundImage = global::DrawingProgram.Properties.Resources.m_arms_straight;
            this.btnArmsStraight.Location = new System.Drawing.Point(6, 30);
            this.btnArmsStraight.Name = "btnArmsStraight";
            this.btnArmsStraight.Size = new System.Drawing.Size(64, 64);
            this.btnArmsStraight.TabIndex = 1;
            this.btnArmsStraight.UseVisualStyleBackColor = true;
            this.btnArmsStraight.Click += new System.EventHandler(this.btnArmsStraight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelColor);
            this.groupBox2.Controls.Add(this.BtnCustomColor);
            this.groupBox2.Controls.Add(this.BtnGrey);
            this.groupBox2.Controls.Add(this.BtnBlack);
            this.groupBox2.Controls.Add(this.BtnGreen);
            this.groupBox2.Controls.Add(this.BtnYellow);
            this.groupBox2.Controls.Add(this.BtnRed);
            this.groupBox2.Controls.Add(this.BtnBlue);
            this.groupBox2.Controls.Add(this.cmbColors);
            this.groupBox2.Location = new System.Drawing.Point(0, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 223);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(192, 20);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(52, 57);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "  ";
            // 
            // BtnCustomColor
            // 
            this.BtnCustomColor.Location = new System.Drawing.Point(7, 45);
            this.BtnCustomColor.Name = "BtnCustomColor";
            this.BtnCustomColor.Size = new System.Drawing.Size(150, 32);
            this.BtnCustomColor.TabIndex = 7;
            this.BtnCustomColor.Text = "Custom";
            this.BtnCustomColor.UseVisualStyleBackColor = true;
            this.BtnCustomColor.Click += new System.EventHandler(this.BtnCustomColor_Click);
            // 
            // BtnGrey
            // 
            this.BtnGrey.BackColor = System.Drawing.Color.Gray;
            this.BtnGrey.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGrey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrey.Location = new System.Drawing.Point(85, 20);
            this.BtnGrey.Name = "BtnGrey";
            this.BtnGrey.Size = new System.Drawing.Size(20, 20);
            this.BtnGrey.TabIndex = 6;
            this.BtnGrey.UseVisualStyleBackColor = false;
            this.BtnGrey.Click += new System.EventHandler(this.BtnGrey_Click);
            // 
            // BtnBlack
            // 
            this.BtnBlack.BackColor = System.Drawing.Color.Black;
            this.BtnBlack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlack.Location = new System.Drawing.Point(111, 20);
            this.BtnBlack.Name = "BtnBlack";
            this.BtnBlack.Size = new System.Drawing.Size(20, 20);
            this.BtnBlack.TabIndex = 5;
            this.BtnBlack.UseVisualStyleBackColor = false;
            this.BtnBlack.Click += new System.EventHandler(this.BtnBlack_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.Color.Lime;
            this.BtnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreen.Location = new System.Drawing.Point(137, 20);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(20, 20);
            this.BtnGreen.TabIndex = 4;
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnYellow
            // 
            this.BtnYellow.BackColor = System.Drawing.Color.Yellow;
            this.BtnYellow.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYellow.Location = new System.Drawing.Point(59, 20);
            this.BtnYellow.Name = "BtnYellow";
            this.BtnYellow.Size = new System.Drawing.Size(20, 20);
            this.BtnYellow.TabIndex = 3;
            this.BtnYellow.UseVisualStyleBackColor = false;
            this.BtnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.Red;
            this.BtnRed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRed.Location = new System.Drawing.Point(33, 20);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(20, 20);
            this.BtnRed.TabIndex = 2;
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.Color.Blue;
            this.BtnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlue.Location = new System.Drawing.Point(7, 20);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(20, 20);
            this.BtnBlue.TabIndex = 1;
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // cmbColors
            // 
            this.cmbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(6, 142);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(291, 24);
            this.cmbColors.TabIndex = 0;
            this.cmbColors.Text = "Select a Color";
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.cmbColors_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TrackBrushSize);
            this.groupBox3.Location = new System.Drawing.Point(317, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brush Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // TrackBrushSize
            // 
            this.TrackBrushSize.Location = new System.Drawing.Point(15, 20);
            this.TrackBrushSize.Maximum = 20;
            this.TrackBrushSize.Minimum = 1;
            this.TrackBrushSize.Name = "TrackBrushSize";
            this.TrackBrushSize.Size = new System.Drawing.Size(283, 45);
            this.TrackBrushSize.TabIndex = 0;
            this.TrackBrushSize.Value = 5;
            this.TrackBrushSize.Scroll += new System.EventHandler(this.TrackBrushSize_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RadioDashed);
            this.groupBox4.Controls.Add(this.RadioSolid);
            this.groupBox4.Location = new System.Drawing.Point(317, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Line Style";
            // 
            // RadioDashed
            // 
            this.RadioDashed.AutoSize = true;
            this.RadioDashed.Location = new System.Drawing.Point(6, 51);
            this.RadioDashed.Name = "RadioDashed";
            this.RadioDashed.Size = new System.Drawing.Size(62, 17);
            this.RadioDashed.TabIndex = 1;
            this.RadioDashed.Text = "Dashed";
            this.RadioDashed.UseVisualStyleBackColor = true;
            this.RadioDashed.Click += new System.EventHandler(this.RadioDashed_Click);
            // 
            // RadioSolid
            // 
            this.RadioSolid.AutoSize = true;
            this.RadioSolid.Checked = true;
            this.RadioSolid.Location = new System.Drawing.Point(6, 19);
            this.RadioSolid.Name = "RadioSolid";
            this.RadioSolid.Size = new System.Drawing.Size(48, 17);
            this.RadioSolid.TabIndex = 0;
            this.RadioSolid.TabStop = true;
            this.RadioSolid.Text = "Solid";
            this.RadioSolid.UseVisualStyleBackColor = true;
            this.RadioSolid.Click += new System.EventHandler(this.RadioSolid_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnClear);
            this.groupBox5.Controls.Add(this.BtnSave);
            this.groupBox5.Controls.Add(this.BtnRedo);
            this.groupBox5.Controls.Add(this.BtnUndo);
            this.groupBox5.Location = new System.Drawing.Point(655, 426);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 223);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 168);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(175, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear Surface";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(7, 123);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(175, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save Image";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRedo
            // 
            this.BtnRedo.Location = new System.Drawing.Point(7, 77);
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(175, 23);
            this.BtnRedo.TabIndex = 1;
            this.BtnRedo.Text = "Redo";
            this.BtnRedo.UseVisualStyleBackColor = true;
            this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Location = new System.Drawing.Point(7, 32);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(175, 23);
            this.BtnUndo.TabIndex = 0;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.DefaultExt = "png";
            this.SaveDB.Filter = "Png|*.png";
            this.SaveDB.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            this.SaveDB.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveDB_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PbSurface);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stick Figure Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSurface)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBrushSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbSurface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRunningMan;
        private System.Windows.Forms.Button btnStickWoman;
        private System.Windows.Forms.Button btnArmsDown;
        private System.Windows.Forms.Button btnArmsUp;
        private System.Windows.Forms.Button btnArmsStraight;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button BtnCustomColor;
        private System.Windows.Forms.Button BtnGrey;
        private System.Windows.Forms.Button BtnBlack;
        private System.Windows.Forms.Button BtnGreen;
        private System.Windows.Forms.Button BtnYellow;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Button BtnBlue;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackBrushSize;
        private System.Windows.Forms.RadioButton RadioDashed;
        private System.Windows.Forms.RadioButton RadioSolid;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRedo;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.ColorDialog ColorDB;
        private System.Windows.Forms.SaveFileDialog SaveDB;
    }
}

