using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoreL
{
    public static class DataBase
    {
        public static List<object[]> SelectQuery(string sql, string connection_string)
        {

            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand sql_comm = new MySqlCommand(sql, conn);

            MySqlDataReader MyDataReader;
            MyDataReader = sql_comm.ExecuteReader();
            List<object[]> res = new List<object[]>();
            while (MyDataReader.Read())
            {
                object[] row = new object[MyDataReader.FieldCount];
                MyDataReader.GetValues(row);
                res.Add(row);

            }


            return res;
        }
        public static byte[] ObjectToByteArray(object obj)
        {

            MemoryStream ms = new MemoryStream();
            // fs = new FileStream(Application.StartupPath + @"\" + filename, FileMode.Create, FileAccess.Write, FileShare.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            byte[] res = ms.ToArray();

            ms.Close();
            return res;



        }
        public static object ArrayToObject(byte[] arr)
        {
            MemoryStream ms = new MemoryStream();

            ms.Write(arr, 0, arr.Length);
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            object res = bf.Deserialize(ms);
            ms.Close();
            return res;
           
        }

        public static void UpdateTaskQuery(TaskInfo taskInfo, string connection_string)
        {

            MySqlConnection conn = new MySqlConnection(connection_string);
            // conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

          //  if(taskInfo.DateFactEnd==TaskInfo.NULLDATE && taskInfo.DatePerenos == TaskInfo.NULLDATE)
                // command.CommandText = "UPDATE  tasks set chat=?databuff, task_text='"+taskInfo.TaskContent+"', id_isp='"+taskInfo.IspId+"',date_begin='"+taskInfo.DateBegin.ToString("yyyy-MM-dd")+"',date_end='"+taskInfo.DateEnd.ToString("yyyy-MM-dd") +"',status='"+taskInfo.Status.ToString()+"'  where id_task=" + taskInfo.Id.ToString() + ";";
                command.CommandText = "UPDATE  tasks set chat=?databuff, task_text='" + taskInfo.TaskContent + "', id_isp='" + taskInfo.IspId + "',date_begin='" + taskInfo.DateBegin.ToString("yyyy-MM-dd") + "',date_end='" + taskInfo.DateEnd.ToString("yyyy-MM-dd") + "',status='" + taskInfo.Status.ToString() + "',date_end_fakt='" + taskInfo.DateFactEnd.ToString("yyyy-MM-dd") + "',zapros_perenosa='" + taskInfo.DatePerenos.ToString("yyyy-MM-dd") + "',id_sogl='"+taskInfo.SoglId.ToString()+ "',perenos_sogl='"+taskInfo.SoglStatus.ToString()+"' where id_task=" + taskInfo.Id.ToString() + ";";
            /*    if (taskInfo.DateFactEnd == TaskInfo.NULLDATE && taskInfo.DatePerenos != TaskInfo.NULLDATE)
                    command.CommandText = "UPDATE  tasks set chat=?databuff, task_text='" + taskInfo.TaskContent + "', id_isp='" + taskInfo.IspId + "',date_begin='" + taskInfo.DateBegin.ToString("yyyy-MM-dd") + "',date_end='" + taskInfo.DateEnd.ToString("yyyy-MM-dd") + "',status='" + taskInfo.Status.ToString() + "',zapros_perenosa='"+taskInfo.DatePerenos.ToString("yyyy-MM-dd") +"' where id_task=" + taskInfo.Id.ToString() + ";";
                if (taskInfo.DateFactEnd != TaskInfo.NULLDATE && taskInfo.DatePerenos == TaskInfo.NULLDATE)
                    command.CommandText = "UPDATE  tasks set chat=?databuff, task_text='" + taskInfo.TaskContent + "', id_isp='" + taskInfo.IspId + "',date_begin='" + taskInfo.DateBegin.ToString("yyyy-MM-dd") + "',date_end='" + taskInfo.DateEnd.ToString("yyyy-MM-dd") + "',status='" + taskInfo.Status.ToString() + "',date_end_fakt='" + taskInfo.DateFactEnd.ToString("yyyy-MM-dd") + "' where id_task=" + taskInfo.Id.ToString() + ";";
                if (taskInfo.DateFactEnd != TaskInfo.NULLDATE && taskInfo.DatePerenos != TaskInfo.NULLDATE)
                    command.CommandText = "UPDATE  tasks set chat=?databuff, task_text='" + taskInfo.TaskContent + "', id_isp='" + taskInfo.IspId + "',date_begin='" + taskInfo.DateBegin.ToString("yyyy-MM-dd") + "',date_end='" + taskInfo.DateEnd.ToString("yyyy-MM-dd") + "',status='" + taskInfo.Status.ToString() + "',date_end_fakt='" + taskInfo.DateFactEnd.ToString("yyyy-MM-dd") + "',zapros_perenosa='"+taskInfo.DatePerenos.ToString("yyyy-MM-dd") +"' where id_task=" + taskInfo.Id.ToString() + ";";*/


            if (taskInfo.Chat == null)
                taskInfo.Chat = new List<string>();
            byte[] databuff = ObjectToByteArray(taskInfo.Chat);
            MySqlParameter fileContentParameter = new MySqlParameter("?databuff", MySqlDbType.Blob, databuff.Length);


            fileContentParameter.Value = databuff;

           
            command.Parameters.Add(fileContentParameter);

            conn.Open();

            command.ExecuteNonQuery();
        }


        public static void InsertTaskQuery(TaskInfo taskInfo, string connection_string)
        {

            MySqlConnection conn = new MySqlConnection(connection_string);
            // conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO tasks (task_text, id_isp,date_begin, date_end,id_sogl) VALUES ('"+taskInfo.TaskContent+"','"+taskInfo.IspId.ToString()+"','"+taskInfo.DateBegin.ToString("yyyy-MM-dd") +"','"+ taskInfo.DateEnd.ToString("yyyy-MM-dd") + "','"+taskInfo.SoglId.ToString()+"');";

          

            conn.Open();

            command.ExecuteNonQuery();
        }

        public static string GetStatus(int status)
        {
            switch (status)
            {
                case 0:return "На исполнении";
                case 1: return "Запрос закрытия";
                case 2: return "Запрос переноса";
                case 3: return "Исполнена";
            }
            return "Ошибка";
        }

    }
}
