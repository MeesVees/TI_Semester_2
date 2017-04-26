using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_29_03_17;

namespace TI_Semester_2
{
    public partial class TI_29_03_2017 : Form

    {
        Form TI1 = new TI_29_03();
        Form TI2 = new TI_12_04_18();
     
        public TI_29_03_2017()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TI1.Visible == false) TI1 = new TI_29_03();
            TI1.Visible = true;
            TI1.Activate();
        }

        private void TI_button2_Click(object sender, EventArgs e)
        {
            if (TI2.Visible == false) TI1 = new TI_12_04_18();
            TI2.Visible = true;
            TI2.Activate();
        }
    }
}
