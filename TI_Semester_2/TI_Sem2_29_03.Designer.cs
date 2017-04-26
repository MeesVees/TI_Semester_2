namespace TI_29_03_17
{
    partial class TI_29_03
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
            this.TI_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TI_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TI_Suurus = new System.Windows.Forms.Label();
            this.TI_failivalik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TI_Zoom = new System.Windows.Forms.RadioButton();
            this.TI_CenterImg = new System.Windows.Forms.RadioButton();
            this.TI_Autosize = new System.Windows.Forms.RadioButton();
            this.TI_Stretchimg = new System.Windows.Forms.RadioButton();
            this.TI_Normal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TI_directory = new System.Windows.Forms.Button();
            this.TI_listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TI_pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TI_openFileDialog
            // 
            this.TI_openFileDialog.FileName = "openFileDialog";
            // 
            // TI_pictureBox1
            // 
            this.TI_pictureBox1.Location = new System.Drawing.Point(368, 40);
            this.TI_pictureBox1.Name = "TI_pictureBox1";
            this.TI_pictureBox1.Size = new System.Drawing.Size(399, 228);
            this.TI_pictureBox1.TabIndex = 24;
            this.TI_pictureBox1.TabStop = false;
            // 
            // TI_Suurus
            // 
            this.TI_Suurus.AutoSize = true;
            this.TI_Suurus.Location = new System.Drawing.Point(364, 280);
            this.TI_Suurus.Name = "TI_Suurus";
            this.TI_Suurus.Size = new System.Drawing.Size(0, 21);
            this.TI_Suurus.TabIndex = 23;
            // 
            // TI_failivalik
            // 
            this.TI_failivalik.Location = new System.Drawing.Point(41, 40);
            this.TI_failivalik.Name = "TI_failivalik";
            this.TI_failivalik.Size = new System.Drawing.Size(167, 45);
            this.TI_failivalik.TabIndex = 22;
            this.TI_failivalik.Text = "Faili valik";
            this.TI_failivalik.UseVisualStyleBackColor = true;
            this.TI_failivalik.Click += new System.EventHandler(this.TI_failivalik_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pildi suurus";
            // 
            // TI_Zoom
            // 
            this.TI_Zoom.AutoSize = true;
            this.TI_Zoom.Location = new System.Drawing.Point(43, 280);
            this.TI_Zoom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TI_Zoom.Name = "TI_Zoom";
            this.TI_Zoom.Size = new System.Drawing.Size(72, 25);
            this.TI_Zoom.TabIndex = 20;
            this.TI_Zoom.TabStop = true;
            this.TI_Zoom.Text = "Zoom";
            this.TI_Zoom.UseVisualStyleBackColor = true;
            // 
            // TI_CenterImg
            // 
            this.TI_CenterImg.AutoSize = true;
            this.TI_CenterImg.Location = new System.Drawing.Point(43, 243);
            this.TI_CenterImg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TI_CenterImg.Name = "TI_CenterImg";
            this.TI_CenterImg.Size = new System.Drawing.Size(160, 25);
            this.TI_CenterImg.TabIndex = 19;
            this.TI_CenterImg.TabStop = true;
            this.TI_CenterImg.Text = "Center image";
            this.TI_CenterImg.UseVisualStyleBackColor = true;
            // 
            // TI_Autosize
            // 
            this.TI_Autosize.AutoSize = true;
            this.TI_Autosize.Location = new System.Drawing.Point(43, 205);
            this.TI_Autosize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TI_Autosize.Name = "TI_Autosize";
            this.TI_Autosize.Size = new System.Drawing.Size(116, 25);
            this.TI_Autosize.TabIndex = 18;
            this.TI_Autosize.TabStop = true;
            this.TI_Autosize.Text = "Autosize";
            this.TI_Autosize.UseVisualStyleBackColor = true;
            // 
            // TI_Stretchimg
            // 
            this.TI_Stretchimg.AutoSize = true;
            this.TI_Stretchimg.Location = new System.Drawing.Point(43, 167);
            this.TI_Stretchimg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TI_Stretchimg.Name = "TI_Stretchimg";
            this.TI_Stretchimg.Size = new System.Drawing.Size(171, 25);
            this.TI_Stretchimg.TabIndex = 17;
            this.TI_Stretchimg.TabStop = true;
            this.TI_Stretchimg.Text = "Stretch Image";
            this.TI_Stretchimg.UseVisualStyleBackColor = true;
            // 
            // TI_Normal
            // 
            this.TI_Normal.AutoSize = true;
            this.TI_Normal.Location = new System.Drawing.Point(43, 130);
            this.TI_Normal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TI_Normal.Name = "TI_Normal";
            this.TI_Normal.Size = new System.Drawing.Size(94, 25);
            this.TI_Normal.TabIndex = 16;
            this.TI_Normal.TabStop = true;
            this.TI_Normal.Text = "Normal";
            this.TI_Normal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TI_listBox1);
            this.groupBox1.Controls.Add(this.TI_directory);
            this.groupBox1.Location = new System.Drawing.Point(43, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 194);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TI_directory
            // 
            this.TI_directory.Location = new System.Drawing.Point(3, 25);
            this.TI_directory.Name = "TI_directory";
            this.TI_directory.Size = new System.Drawing.Size(135, 40);
            this.TI_directory.TabIndex = 0;
            this.TI_directory.Text = "DIR";
            this.TI_directory.UseVisualStyleBackColor = true;
            this.TI_directory.Click += new System.EventHandler(this.TI_directory_Click);
            // 
            // TI_listBox1
            // 
            this.TI_listBox1.FormattingEnabled = true;
            this.TI_listBox1.ItemHeight = 21;
            this.TI_listBox1.Location = new System.Drawing.Point(13, 80);
            this.TI_listBox1.Name = "TI_listBox1";
            this.TI_listBox1.Size = new System.Drawing.Size(502, 88);
            this.TI_listBox1.TabIndex = 2;
            // 
            // TI_29_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TI_pictureBox1);
            this.Controls.Add(this.TI_Suurus);
            this.Controls.Add(this.TI_failivalik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TI_Zoom);
            this.Controls.Add(this.TI_CenterImg);
            this.Controls.Add(this.TI_Autosize);
            this.Controls.Add(this.TI_Stretchimg);
            this.Controls.Add(this.TI_Normal);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TI_29_03";
            this.Text = "TI_Sem2_29_03";
            ((System.ComponentModel.ISupportInitialize)(this.TI_pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog TI_openFileDialog;
        private System.Windows.Forms.PictureBox TI_pictureBox1;
        private System.Windows.Forms.Label TI_Suurus;
        private System.Windows.Forms.Button TI_failivalik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TI_Zoom;
        private System.Windows.Forms.RadioButton TI_CenterImg;
        private System.Windows.Forms.RadioButton TI_Autosize;
        private System.Windows.Forms.RadioButton TI_Stretchimg;
        private System.Windows.Forms.RadioButton TI_Normal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TI_listBox1;
        private System.Windows.Forms.Button TI_directory;
    }
}