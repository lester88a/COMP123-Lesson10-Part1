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
    public partial class OptionsForm : Form
    {
        
        public OptionsForm()
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

        //Accept Button Event Handler - Click Event
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (DefaultRadioButton.Checked==true)
            {
                //optionForm.BackColor = Color.GhostWhite;
                ActiveForm.BackColor = SystemColors;
                ActiveForm.ForeColor = Color.White;
            }
            else if (BlueRadioButton.Checked==true)
            {
                ActiveForm.BackColor = Color.Blue;
                ActiveForm.ForeColor = Color.White;
            }
            else if (GreenRadioButton.Checked == true)
            {
                ActiveForm.BackColor = Color.Green;
                ActiveForm.ForeColor = Color.White;
            }
            else if (PinkRadioButton.Checked == true)
            {
                ActiveForm.BackColor = Color.Pink;
                ActiveForm.ForeColor = Color.White;
            }
        }
        
        
    }
}
