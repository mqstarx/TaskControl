﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreL;
using System.Diagnostics;

namespace TaskControlOperator
{
    public partial class MainForm : Form
    {
        private Cfg m_Cfg;
        private const int m_Version = 10;
        public MainForm()
        {
            InitializeComponent();
            m_Cfg = Cfg.ReadConfig();
            this.Text += " Версия: " + m_Version.ToString();
            if (m_Cfg == null)
                this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string sql_dop = "";

            if (only_req_cxb.Checked)
                sql_dop = "and (status=1 or status=2)";
            if (show_ended_tasks_cxb.Checked)
                sql = "select tasks.id_task,tasks.status,tasks.task_text,users.user,tasks.date_begin,tasks.date_end,tasks.date_end_fakt,tasks.id_isp,chat,tasks.zapros_perenosa,tasks.id_sogl,tasks.perenos_sogl from tasks,users where tasks.id_isp = users.id "+sql_dop+" order by id_task desc;";
            else
                sql = "select tasks.id_task,tasks.status,tasks.task_text,users.user,tasks.date_begin,tasks.date_end,tasks.date_end_fakt,tasks.id_isp,chat,tasks.zapros_perenosa,tasks.id_sogl,tasks.perenos_sogl from tasks,users where tasks.id_isp = users.id and tasks.status != 3 "+sql_dop+" order by id_task desc;";

            List<object[]> res = DataBase.SelectQuery(sql, m_Cfg.DbConnectionString);
            if (res != null && res.Count > 0)
            {
                task_listView.Items.Clear();
                for (int i=0;i<res.Count;i++)
                {
                    TaskInfo ti = new TaskInfo((int)res[i][0], (string)res[i][2], (int)res[i][7], (int)res[i][10], (DateTime)res[i][4], (DateTime)res[i][5], (int)res[i][1]);
                    string[] strItems = new string[6];

                    strItems[0] = DataBase.GetStatus((int)res[i][1]); // task status
                    strItems[1] = (string)res[i][2]; // task text
                    strItems[2] = (string)res[i][3]; // task ispolnitel
                    ti.UserIsp = (string)res[i][3];

                    strItems[3] = ((DateTime)res[i][4]).ToString("dd.MM.yyyy"); // data begin
                    strItems[4] = ((DateTime)res[i][5]).ToString("dd.MM.yyyy"); // data end

                    if (res[i][6].GetType() != typeof(System.DBNull) && ((DateTime)res[i][6]) !=TaskInfo.NULLDATE )
                    {
                        strItems[5] = ((DateTime)res[i][6]).ToString("dd.MM.yyyy"); // data end fakt
                        ti.DateFactEnd = (DateTime)res[i][6];
                    }

                    if (res[i][8].GetType() != typeof(System.DBNull))
                        ti.Chat = (List<string>)DataBase.ArrayToObject((byte[])res[i][8]);

                    if (res[i][9].GetType() != typeof(System.DBNull))
                        ti.DatePerenos = (DateTime)res[i][9]; // data perenosa


                    ti.SoglStatus = (int)res[i][11];//sogl status;


                    Font font = new Font("Times New Roman", 9.0f);
                    Color back_color = Color.White;
                    FontStyle fs = FontStyle.Regular;
                    Color font_color = Color.Black;

                    if(ti.Status==0)
                    {
                        if(TaskInfo.DaysDiff(DateTime.Now,ti.DateEnd)<=5)
                        {
                            back_color = Color.Yellow;
                        }

                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 2)
                        {
                            back_color = Color.LightCoral;
                        }
                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 0)
                        {
                            back_color = Color.Red;
                        }

                    }
                    if (ti.Status == 3)
                    {
                        fs = FontStyle.Italic;
                        font_color = Color.Gray;
                    }

                    if(ti.Status == 1)
                    {
                        fs = FontStyle.Italic | FontStyle.Bold;
                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 5)
                        {
                            font_color = Color.Yellow;
                            back_color = Color.LightGray;
                        }

                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 2)
                        {
                            font_color = Color.LightCoral;
                        }
                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 0)
                        {
                            font_color = Color.Red;
                        }


                    }
                    if (ti.Status == 2)
                    {
                        fs =  FontStyle.Bold;
                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 5)
                        {
                            font_color = Color.Yellow;
                            back_color = Color.LightGray;
                        }

                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 2)
                        {
                            font_color = Color.LightCoral;
                        }
                        if (TaskInfo.DaysDiff(DateTime.Now, ti.DateEnd) <= 0)
                        {
                            font_color = Color.Red;
                        }


                    }

                    ListViewItem lvi = new ListViewItem(strItems, -1, font_color, back_color, new Font(font, fs));
                    lvi.Tag = ti;

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

                    taskAction.TaskInfo = (TaskInfo)task_listView.SelectedItems[0].Tag;

                    DialogResult dr = taskAction.ShowDialog();
                    if(dr == DialogResult.OK)
                    {
                        DataBase.UpdateTaskQuery(taskAction.TaskInfo, m_Cfg.DbConnectionString);
                        refresh_btn_Click(null, null);
                    }

                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            refresh_btn_Click(null, null);

            List<object[]> res = DataBase.SelectQuery("select * from update_operator order by id desc;", m_Cfg.DbConnectionString);
            if (res.Count > 0)
            {
                if ((int)res[0][2] > m_Version)
                {
                    if (MessageBox.Show("Доступна новая версия ПО! Обновить?", "Обновление программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start("OperatorUpdate.exe");
                        this.Close();
                    }
                }
            }
        }

        private void новаяЗадачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskActionForm taskAction = new TaskActionForm();
            List<object[]> res = DataBase.SelectQuery("select * from users;", m_Cfg.DbConnectionString);
            if (res.Count > 0)
            {
                List<UserInfo> usr_lst = new List<UserInfo>();
                for (int i = 0; i < res.Count; i++)
                {

                    usr_lst.Add(new UserInfo((int)res[i][0], (string)res[i][1]));
                }
                taskAction.UserList = usr_lst;
                taskAction.confirm_end_task_btn.Enabled = false;
                taskAction.return_task_btn.Enabled = false;
                taskAction.edit_task.Text = "Создать задачу";
               

                DialogResult dr = taskAction.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    DataBase.InsertTaskQuery(taskAction.TaskInfo, m_Cfg.DbConnectionString);
                    refresh_btn_Click(null, null);
                }

            }
        }

        private void новаяЗадачаНаОсновеВыбраннойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (task_listView.SelectedItems.Count != 0)
            {
                TaskActionForm taskAction = new TaskActionForm();
                List<object[]> res = DataBase.SelectQuery("select * from users;", m_Cfg.DbConnectionString);
                if (res.Count > 0)
                {
                    List<UserInfo> usr_lst = new List<UserInfo>();
                    for (int i = 0; i < res.Count; i++)
                    {

                        usr_lst.Add(new UserInfo((int)res[i][0], (string)res[i][1]));
                    }
                    taskAction.UserList = usr_lst;
                    taskAction.confirm_end_task_btn.Enabled = false;
                    taskAction.return_task_btn.Enabled = false;
                    taskAction.edit_task.Text = "Создать задачу";
                    taskAction.TaskInfo =new TaskInfo(0, ((TaskInfo)task_listView.SelectedItems[0].Tag).TaskContent, ((TaskInfo)task_listView.SelectedItems[0].Tag).IspId, ((TaskInfo)task_listView.SelectedItems[0].Tag).SoglId, ((TaskInfo)task_listView.SelectedItems[0].Tag).DateBegin, ((TaskInfo)task_listView.SelectedItems[0].Tag).DateEnd,0);

                    DialogResult dr = taskAction.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        DataBase.InsertTaskQuery(taskAction.TaskInfo, m_Cfg.DbConnectionString);
                        refresh_btn_Click(null, null);
                    }

                }
            }
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.DbConn = m_Cfg.DbConnectionString;
            List<object[]> res = DataBase.SelectQuery("select * from users;", m_Cfg.DbConnectionString);
            if (res.Count > 0)
            {
                List<UserInfo> usr_lst = new List<UserInfo>();
                for (int i = 0; i < res.Count; i++)
                {

                    usr_lst.Add(new UserInfo((int)res[i][0], (string)res[i][1]));
                }
                rf.UserList = usr_lst;
            }
                rf.Show();
        }

        private void only_req_cxb_CheckedChanged(object sender, EventArgs e)
        {
            refresh_btn_Click(null, null);
        }
    }
}
