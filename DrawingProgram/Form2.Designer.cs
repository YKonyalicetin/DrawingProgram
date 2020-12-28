
namespace DrawingProgram
{
    partial class FormText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormText));
            this.TextboxStickFigure = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbFontFamily = new System.Windows.Forms.ComboBox();
            this.SpinFontSize = new System.Windows.Forms.NumericUpDown();
            this.RadioRegular = new System.Windows.Forms.RadioButton();
            this.RadioBold = new System.Windows.Forms.RadioButton();
            this.RadioItalic = new System.Windows.Forms.RadioButton();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.LabelColor = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ColorDB = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxStickFigure
            // 
            this.TextboxStickFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxStickFigure.Location = new System.Drawing.Point(12, 42);
            this.TextboxStickFigure.Multiline = true;
            this.TextboxStickFigure.Name = "TextboxStickFigure";
            this.TextboxStickFigure.Size = new System.Drawing.Size(315, 75);
            this.TextboxStickFigure.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpinFontSize);
            this.groupBox1.Controls.Add(this.CmbFontFamily);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Family and Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioItalic);
            this.groupBox2.Controls.Add(this.RadioBold);
            this.groupBox2.Controls.Add(this.RadioRegular);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LabelColor);
            this.groupBox3.Controls.Add(this.btnFontColor);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font Color";
            // 
            // CmbFontFamily
            // 
            this.CmbFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFontFamily.FormattingEnabled = true;
            this.CmbFontFamily.Location = new System.Drawing.Point(6, 19);
            this.CmbFontFamily.Name = "CmbFontFamily";
            this.CmbFontFamily.Size = new System.Drawing.Size(225, 28);
            this.CmbFontFamily.TabIndex = 4;
            this.CmbFontFamily.SelectedIndexChanged += new System.EventHandler(this.CmbFontFamily_SelectedIndexChanged);
            // 
            // SpinFontSize
            // 
            this.SpinFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinFontSize.Location = new System.Drawing.Point(254, 19);
            this.SpinFontSize.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.SpinFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.SpinFontSize.Name = "SpinFontSize";
            this.SpinFontSize.Size = new System.Drawing.Size(55, 29);
            this.SpinFontSize.TabIndex = 5;
            this.SpinFontSize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.SpinFontSize.ValueChanged += new System.EventHandler(this.SpinFontSize_ValueChanged);
            // 
            // RadioRegular
            // 
            this.RadioRegular.AutoSize = true;
            this.RadioRegular.Checked = true;
            this.RadioRegular.Location = new System.Drawing.Point(18, 20);
            this.RadioRegular.Name = "RadioRegular";
            this.RadioRegular.Size = new System.Drawing.Size(62, 17);
            this.RadioRegular.TabIndex = 0;
            this.RadioRegular.Text = "Regular";
            this.RadioRegular.UseVisualStyleBackColor = true;
            // 
            // RadioBold
            // 
            this.RadioBold.AutoSize = true;
            this.RadioBold.Location = new System.Drawing.Point(141, 20);
            this.RadioBold.Name = "RadioBold";
            this.RadioBold.Size = new System.Drawing.Size(46, 17);
            this.RadioBold.TabIndex = 1;
            this.RadioBold.Text = "Bold";
            this.RadioBold.UseVisualStyleBackColor = true;
            this.RadioBold.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioItalic
            // 
            this.RadioItalic.AutoSize = true;
            this.RadioItalic.Location = new System.Drawing.Point(254, 20);
            this.RadioItalic.Name = "RadioItalic";
            this.RadioItalic.Size = new System.Drawing.Size(47, 17);
            this.RadioItalic.TabIndex = 2;
            this.RadioItalic.Text = "Italic";
            this.RadioItalic.UseVisualStyleBackColor = true;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(0, 19);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(165, 35);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "Font Color";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColor.Location = new System.Drawing.Point(196, 19);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(37, 39);
            this.LabelColor.TabIndex = 4;
            this.LabelColor.Text = "  ";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 399);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(140, 40);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(187, 399);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(140, 40);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextboxStickFigure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Text for Drawing";
            this.Load += new System.EventHandler(this.FormText_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxStickFigure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SpinFontSize;
        private System.Windows.Forms.ComboBox CmbFontFamily;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioBold;
        private System.Windows.Forms.RadioButton RadioRegular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioItalic;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ColorDialog ColorDB;
    }
}