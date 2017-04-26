using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_Semester_2
{
    public partial class TI_12_04_18 : Form
        
    {
        int Vurr_Numb = 0;
        int muudubX = 1;
        int muudubY = 1;

        public TI_12_04_18()
        {
            InitializeComponent();
            
        }

        private void TI_timer1_Tick(object sender, EventArgs e)
        {
            Vurr_Numb++;
            if (Vurr_Numb > 5) Vurr_Numb = 0;
            TI_Vurr.Image = TI_Images.Images[Vurr_Numb];

            if (TI_Vurr.Left > TI_groupBox1.Width - TI_Vurr.Width)
            {
                muudubX = -1;
            }

            if (TI_Vurr.Top > TI_groupBox1.Height - TI_Vurr.Height)
            {
                muudubY = -1;

            }
            if (TI_Vurr.Left < 0)
            {
                muudubX = 1;
            }

            if (TI_Vurr.Top < 0)
            {
                muudubY = 1;

            }

            if (TI_radioButton1.Checked)
            {
                TI_Vurr.Left += 9*muudubX;
                TI_Vurr.Top += 9*muudubY;
              
            }

            if (TI_radioButton2.Checked)
            {
                TI_Vurr.Left += 0;
            }

        }
    }
}
