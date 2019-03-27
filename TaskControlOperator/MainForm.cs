using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreL;

namespace TaskControlOperator
{
    public partial class MainForm : Form
    {
        private Cfg m_Cfg;
        public MainForm()
        {
            InitializeComponent();
            m_Cfg = Cfg.ReadConfig();
            if (m_Cfg == null)
                this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (show_ended_tasks_cxb.Checked)
                sql = "select tasks.id_task,tasks.status,tasks.task_text,users.user,tasks.date_begin,tasks.date_end,tasks.date_end_fakt from tasks,users where tasks.id_isp = users.id ;";
            else
                sql = "select tasks.id_task,tasks.status,tasks.task_text,users.user,tasks.date_begin,tasks.date_end,tasks.date_end_fakt from tasks,users where tasks.id_isp = users.id and tasks.status != 3;";

            List<object[]> res = DataBase.SelectQuery(sql, m_Cfg.DbConnectionString);
            if (res != null && res.Count > 0)
            {
                task_listView.Items.Clear();
                for (int i=0;i<res.Count;i++)
                {
                    string[] strItems = new string[6];

                    strItems[0] = DataBase.GetStatus((int)res[i][1]); // task status
                    strItems[1] = (string)res[i][2]; // task text
                    strItems[2] = (string)res[i][3]; // task ispolnitel
                    strItems[3] = ((DateTime)res[i][4]).ToString("dd.MM.yyyy"); // data begin
                    strItems[4] = ((DateTime)res[i][5]).ToString("dd.MM.yyyy"); // data end

                    if(res[i][6].GetType()!=typeof(System.DBNull))
                        strItems[5] = ((DateTime)res[i][6]).ToString("dd.MM.yyyy"); // data end fakt

                    ListViewItem lvi = new ListViewItem(strItems, -1, Color.Black, Color.White, null);
                    lvi.Tag = res[i][0]; // id task

                    task_listView.Items.Add(lvi);

                }

               
            }
       
        }

        private void show_ended_tasks_cxb_CheckedChanged(object sender, EventArgs e)
        {
            refresh_btn_Click(null, null);
        }

        private void task_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(task_listView.SelectedItems.Count!=0)
            {
                TaskActionForm taskAction = new TaskActionForm();
                // taskAction.SqlDbConnString = m_Cfg.DbConnectionString;
                List<object[]> res = DataBase.SelectQuery("select * from users;", m_Cfg.DbConnectionString);
                if (res.Count > 0)
                {
                    List<UserInfo> usr_lst = new List<UserInfo>();
                    for (int i = 0; i < res.Count; i++)
                    {

                        usr_lst.Add(new UserInfo((int)res[i][0], (string)res[i][1]));
                    }
                    taskAction.UserList = usr_lst;
                    taskAction.ShowDialog();

                }
            }
        }
    }
}
