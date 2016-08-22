using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ADONET_1
{
    class Animals
    {
        public void Animals_TableInit()
        {

            SQLiteConnection.CreateFile("base.sqlite");
            SQLiteConnection conn = new SQLiteConnection("Data Source=base.sqlite;Version=3;");
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS [Animals] (
                              [ID] INTEGER,
                              [Name] VARCHAR(20),
                              [Weight] REAL,
                              [Type] INTEGER
                              )";

            SQLiteCommand comm = new SQLiteCommand(sql, conn);
            comm.ExecuteNonQuery();
        }

        public void Animals_DataInsert()
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=base.sqlite;Version=3;");
            conn.Open();

            string [] SqlArr = new string[20];

            SqlArr[0] = @"insert into [Animals] (Id, Name, Weight, Type) values (1,'lion',125,1)";
            SqlArr[1] = @"insert into [Animals] (Id, Name, Weight, Type) values (2,'dolphin',85,2)";
            SqlArr[2] = @"insert into [Animals] (Id, Name, Weight, Type) values (3,'squirrel',0.3,3)";
            SqlArr[3] = @"insert into [Animals] (Id, Name, Weight, Type) values (4,'calibri',0.004,4)";
            SqlArr[4] = @"insert into [Animals] (Id, Name, Weight, Type) values (5,'aligator',355,1)";
            SqlArr[5] = @"insert into [Animals] (Id, Name, Weight, Type) values (6,'bear',167,1)";
            SqlArr[6] = @"insert into [Animals] (Id, Name, Weight, Type) values (7,'rabbit',2.8,2)";
            SqlArr[7] = @"insert into [Animals] (Id, Name, Weight, Type) values (8,'duck',4.6,2)";
            SqlArr[8] = @"insert into [Animals] (Id, Name, Weight, Type) values (9,'wolf',42,1)";
            SqlArr[9] = @"insert into [Animals] (Id, Name, Weight, Type) values (10,'eagle',2.1,1)";
            SqlArr[10] = @"insert into [Animals] (Id, Name, Weight, Type) values (11,'salmon',1.6,3)";
            SqlArr[11] = @"insert into [Animals] (Id, Name, Weight, Type) values (12,'fox',7.4,2)";
            SqlArr[12] = @"insert into [Animals] (Id, Name, Weight, Type) values (13,'mouse',0.14,4)";
            SqlArr[13] = @"insert into [Animals] (Id, Name, Weight, Type) values (14,'spider',0.006,2)";
            SqlArr[14] = @"insert into [Animals] (Id, Name, Weight, Type) values (15,'elephant',4500,3)";
            SqlArr[15] = @"insert into [Animals] (Id, Name, Weight, Type) values (16,'horse',420,2)";
            SqlArr[16] = @"insert into [Animals] (Id, Name, Weight, Type) values (17,'pig',182,3)";
            SqlArr[17] = @"insert into [Animals] (Id, Name, Weight, Type) values (18,'cow',670,2)";
            SqlArr[18] = @"insert into [Animals] (Id, Name, Weight, Type) values (19,'frog',0.25,4)";
            SqlArr[19] = @"insert into [Animals] (Id, Name, Weight, Type) values (20,'snake',1.1,1)";

            foreach (string i in SqlArr)
            {
                SQLiteCommand comm = new SQLiteCommand(i, conn);
                comm.ExecuteNonQuery();
            }
        }

        public void Animals_ScalarRead()
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=base.sqlite;Version=3;");
            conn.Open();
            string sql = @"select count(*) from [Animals]";
            SQLiteCommand comm = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                System.Windows.Forms.MessageBox.Show(dr.GetInt64(0).ToString());
            }

        }
            
        }
    
}

