using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
