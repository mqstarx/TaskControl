using CoreL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Cfg m_Cfg = Cfg.ReadConfig();
            if (m_Cfg == null)
                return;
            // Thread.Sleep(2000);
            List<object[]> res = DataBase.SelectQuery("select * from update_operator order by id desc;", m_Cfg.DbConnectionString);
            if (res.Count > 0)
            {
                UFiles uf = (UFiles)DataBase.ArrayToObject((byte[])res[0][1]);

                for (int i = 0; i < uf.FilesList.Count; i++)
                {
                    Console.WriteLine("Нажмите любую кнопку для продолжения....");
                    Console.ReadLine();
                    uf.FilesList[i].Update(FileToUpdate.StartupPath + @"\" + uf.FilesList[i].FileName);
                }

                Process.Start("TaskControlOperator.exe");


            }
        }
    }
}
