using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Exit.ActiveForm.Close();
            panel.ActiveForm.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel f5 = new panel();
            f5.Show();
        }
    }
}
