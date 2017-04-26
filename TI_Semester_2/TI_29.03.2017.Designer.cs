namespace TI_Semester_2
{
    partial class TI_29_03_2017
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
            this.TI_button1 = new System.Windows.Forms.Button();
            this.TI_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TI_button1
            // 
            this.TI_button1.Location = new System.Drawing.Point(229, 147);
            this.TI_button1.Name = "TI_button1";
            this.TI_button1.Size = new System.Drawing.Size(162, 78);
            this.TI_button1.TabIndex = 0;
            this.TI_button1.Text = "Jou";
            this.TI_button1.UseVisualStyleBackColor = true;
            this.TI_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TI_button2
            // 
            this.TI_button2.Location = new System.Drawing.Point(229, 242);
            this.TI_button2.Name = "TI_button2";
            this.TI_button2.Size = new System.Drawing.Size(162, 78);
            this.TI_button2.TabIndex = 1;
            this.TI_button2.Text = "Ajou, mina siin";
            this.TI_button2.UseVisualStyleBackColor = true;
            this.TI_button2.Click += new System.EventHandler(this.TI_button2_Click);
            // 
            // TI_29_03_2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 515);
            this.Controls.Add(this.TI_button2);
            this.Controls.Add(this.TI_button1);
            this.Name = "TI_29_03_2017";
            this.Text = "TI_29_03_2017";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TI_button1;
        private System.Windows.Forms.Button TI_button2;
    }
}