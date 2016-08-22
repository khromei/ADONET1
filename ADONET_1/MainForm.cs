using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
            FillGrid();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            XmlOut();

        }

        private void button_EX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EX button Click");
        }

        private void button_IM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IM button Click");
        }




        void XmlOut()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=base.sqlite;Version=3;"))
            {
                conn.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select Id, Name, Weight, Type from [Animals]", conn))
                {
                    DataTable tbl = new DataTable();
                    adapter.Fill(tbl);
                    DataSet ds = new DataSet();
                    ds.Tables.Add(tbl);
                    ds.WriteXml(@"D:\\MyDataset.xml");
                }

            }
        }


        void FillGrid()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=base.sqlite;Version=3;"))
            {
                conn.Open();
                using (SQLiteDataAdapter a = new SQLiteDataAdapter("Select Id, Name, Weight, Type from [Animals]", conn))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
            }
        }


    }

}
