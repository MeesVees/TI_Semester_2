namespace TI_Semester_2
{
    partial class TI_12_04_18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TI_12_04_18));
            this.TI_groupBox1 = new System.Windows.Forms.GroupBox();
            this.TI_radioButton2 = new System.Windows.Forms.RadioButton();
            this.TI_radioButton1 = new System.Windows.Forms.RadioButton();
            this.TI_Vurr = new System.Windows.Forms.PictureBox();
            this.TI_Images = new System.Windows.Forms.ImageList(this.components);
            this.TI_timer1 = new System.Windows.Forms.Timer(this.components);
            this.TI_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TI_Vurr)).BeginInit();
            this.SuspendLayout();
            // 
            // TI_groupBox1
            // 
            this.TI_groupBox1.Controls.Add(this.TI_radioButton2);
            this.TI_groupBox1.Controls.Add(this.TI_radioButton1);
            this.TI_groupBox1.Controls.Add(this.TI_Vurr);
            this.TI_groupBox1.Location = new System.Drawing.Point(40, 55);
            this.TI_groupBox1.Name = "TI_groupBox1";
            this.TI_groupBox1.Size = new System.Drawing.Size(560, 514);
            this.TI_groupBox1.TabIndex = 0;
            this.TI_groupBox1.TabStop = false;
            // 
            // TI_radioButton2
            // 
            this.TI_radioButton2.AutoSize = true;
            this.TI_radioButton2.Location = new System.Drawing.Point(30, 145);
            this.TI_radioButton2.Name = "TI_radioButton2";
            this.TI_radioButton2.Size = new System.Drawing.Size(54, 17);
            this.TI_radioButton2.TabIndex = 2;
            this.TI_radioButton2.TabStop = true;
            this.TI_radioButton2.Text = "Paigal";
            this.TI_radioButton2.UseVisualStyleBackColor = true;
            // 
            // TI_radioButton1
            // 
            this.TI_radioButton1.AutoSize = true;
            this.TI_radioButton1.Location = new System.Drawing.Point(30, 122);
            this.TI_radioButton1.Name = "TI_radioButton1";
            this.TI_radioButton1.Size = new System.Drawing.Size(86, 17);
            this.TI_radioButton1.TabIndex = 1;
            this.TI_radioButton1.TabStop = true;
            this.TI_radioButton1.Text = "Liigub küljele";
            this.TI_radioButton1.UseVisualStyleBackColor = true;
            // 
            // TI_Vurr
            // 
            this.TI_Vurr.Location = new System.Drawing.Point(255, 248);
            this.TI_Vurr.Name = "TI_Vurr";
            this.TI_Vurr.Size = new System.Drawing.Size(45, 41);
            this.TI_Vurr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TI_Vurr.TabIndex = 0;
            this.TI_Vurr.TabStop = false;
            // 
            // TI_Images
            // 
            this.TI_Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TI_Images.ImageStream")));
            this.TI_Images.TransparentColor = System.Drawing.Color.Transparent;
            this.TI_Images.Images.SetKeyName(0, "vurr_1.ico");
            this.TI_Images.Images.SetKeyName(1, "vurr_2.ico");
            this.TI_Images.Images.SetKeyName(2, "vurr_3.ico");
            this.TI_Images.Images.SetKeyName(3, "vurr_4.ico");
            this.TI_Images.Images.SetKeyName(4, "vurr_5.ico");
            this.TI_Images.Images.SetKeyName(5, "vurr_6.ico");
            // 
            // TI_timer1
            // 
            this.TI_timer1.Enabled = true;
            this.TI_timer1.Tick += new System.EventHandler(this.TI_timer1_Tick);
            // 
            // TI_12_04_18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 626);
            this.Controls.Add(this.TI_groupBox1);
            this.Name = "TI_12_04_18";
            this.Text = "TI_12_04_18";
            this.TI_groupBox1.ResumeLayout(false);
            this.TI_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TI_Vurr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TI_groupBox1;
        private System.Windows.Forms.ImageList TI_Images;
        private System.Windows.Forms.Timer TI_timer1;
        private System.Windows.Forms.RadioButton TI_radioButton1;
        private System.Windows.Forms.RadioButton TI_radioButton2;
        private System.Windows.Forms.PictureBox TI_Vurr;
    }
}