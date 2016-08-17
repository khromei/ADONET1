using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill button Click");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update button Click");
        }

        private void button_EX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EX button Click");
        }

        private void button_IM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IM button Click");
        }
    }

}
