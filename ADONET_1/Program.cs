using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET_1
{
    static class Program
    {

        static void Main()
        {


            Animals A = new Animals();

            A.Animals_TableInit();
            //System.Windows.Forms.MessageBox.Show("INIT");
            A.Animals_DataInsert();
            //System.Windows.Forms.MessageBox.Show("Insert");
            //A.Animals_ScalarRead();
            //System.Windows.Forms.MessageBox.Show("show");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());



        }



    }
}
