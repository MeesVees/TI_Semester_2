using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_29_03_17
{
    public partial class TI_29_03 : Form
    {
        public TI_29_03()
        {
            InitializeComponent();
        }

        private void TI_failivalik_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Ava pilt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    TI_pictureBox1.Image = new Bitmap(dlg.FileName);
                    this.Controls.Add(TI_pictureBox1);
                    if (TI_Normal.Checked)
                    {
                        TI_pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    }
                    if (TI_Stretchimg.Checked)
                    {
                        TI_pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (TI_Autosize.Checked)
                    {
                        TI_pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    }
                    if (TI_CenterImg.Checked)
                    {
                        TI_pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    if (TI_Zoom.Checked)
                    {
                        TI_pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }

   
             System.IO.Stream striim;

        private void TI_directory_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Title = "Vali mitu pilti";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (String fail in dlg.FileNames)
                {
                    try
                    {
                        if ((striim = dlg.OpenFile()) != null)
                        {
                            using (striim)
                            {
                                TI_listBox1.Items.Add(fail);
                            }
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("VIGA" + ex.Message);
                    }



                }
            }
        }
    }
}