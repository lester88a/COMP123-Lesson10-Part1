using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson10_Part1
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        //Event handler for ShowCheckBox_CheckedChanged
        private void ShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (ShowCheckBox.Checked == true) 
            {
                OptionsGroupBox.Visible = true;
            }
            else
            {
                OptionsGroupBox.Visible = false;
            }
             */
            OptionsGroupBox.Visible = (ShowCheckBox.Checked) ? true : false;
            
        }
    }
}
