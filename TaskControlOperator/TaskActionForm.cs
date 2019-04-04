using CoreL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskControlOperator
{
    public partial class TaskActionForm : Form
    {
       
        private List<UserInfo> m_UserList;

        private TaskInfo m_TaskInfo;
        public TaskActionForm()
        {
            InitializeComponent();
            
        }

        public List<UserInfo> UserList
        {
            get
            {
                return m_UserList;
            }

            set
            {
                m_UserList = value;
            }
        }

        public TaskInfo TaskInfo
        {
            get
            {
                return m_TaskInfo;
            }

            set
            {
                m_TaskInfo = value;
            }
        }

        private void users_cmb_TextChanged(object sender, EventArgs e)
        {
           
         
        }

        private void TaskActionForm_Shown(object sender, EventArgs e)
        {
            users_cmb.Items.AddRange(m_UserList.ToArray());
            users_sogl_cmb.Items.AddRange(m_UserList.ToArray());
            status_cmb.Items.Add(new StatusInfo(0, "На исполнении"));
            status_cmb.Items.Add(new StatusInfo(1, "Запрос закрытия"));
            status_cmb.Items.Add(new StatusInfo(2, "Запрос переноса"));
            status_cmb.Items.Add(new StatusInfo(3, "Выполнена"));


            if (m_TaskInfo!=null)
            {
                task_text_txb.Text = m_TaskInfo.TaskContent;
                date_begin_task.Value = m_TaskInfo.DateBegin;
                date_end_task.Value = m_TaskInfo.DateEnd;
              
                status_cmb.SelectedIndex = m_TaskInfo.Status;


                if(m_TaskInfo.DateFactEnd != TaskInfo.NULLDATE)
                {
                    date_end_fakt.Value = m_TaskInfo.DateFactEnd;
                    date_end_fakt.Enabled = true;
                   
                }
                if (m_TaskInfo.DatePerenos != TaskInfo.NULLDATE)
                {
                    date_perenos.Value = m_TaskInfo.DatePerenos;
                    date_perenos.Enabled = true;
                  
                }
                if(m_TaskInfo.Chat!=null)
                {
                    msg_list.Items.AddRange(m_TaskInfo.Chat.ToArray());
                   
                }
              

                for(int i=0;i<users_cmb.Items.Count;i++)
                {
                    if(((UserInfo)users_cmb.Items[i]).Id ==m_TaskInfo.IspId)
                    {
                        users_cmb.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < users_sogl_cmb.Items.Count; i++)
                {
                    if (((UserInfo)users_sogl_cmb.Items[i]).Id == m_TaskInfo.SoglId)
                    {
                        users_sogl_cmb.SelectedIndex = i;
                        break;
                    }
                }
                if (m_TaskInfo.SoglStatus == 1)
                    panelSogl.BackColor = Color.Green;
                else
                    panelSogl.BackColor = Color.Red;

            }
            else
            {
                m_TaskInfo = new TaskInfo(0, "", 0,0, DateTime.Now, DateTime.Now, 0);
                status_cmb.SelectedIndex = 0;
            }
        }

        private void confirm_end_task_btn_Click(object sender, EventArgs e)
        {
            if (m_TaskInfo.Status == 0 || m_TaskInfo.Status == 3)
                return;

            if (m_TaskInfo.SoglStatus == 0)
            {
                if (MessageBox.Show("Перенос срока не согласован! Все равно продолжить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            UpdateTaskInfo();
            NewChat();
            if (m_TaskInfo.Status == 1)
            {
                m_TaskInfo.Status = 3;
                m_TaskInfo.Chat.Add(DateTime.Now.ToString("dd.MM.yyyy") + ": Задача закрыта");
                m_TaskInfo.DateFactEnd = DateTime.Now;
            }
            if (m_TaskInfo.Status == 2)
            {
               
                m_TaskInfo.Status = 0;
                m_TaskInfo.Chat.Add(DateTime.Now.ToString("dd.MM.yyyy") + ": Перенос срока согласован");
                m_TaskInfo.DateEnd = date_perenos.Value;
            }
            this.Close();
        }

        private void edit_task_Click(object sender, EventArgs e)
        {
            if (users_cmb.SelectedIndex != -1 && users_sogl_cmb.SelectedIndex!=-1)
            {
                this.DialogResult = DialogResult.OK;
                UpdateTaskInfo();
                if (m_TaskInfo.Status == 3)
                {
                    NewChat();
                    m_TaskInfo.Chat.Add(DateTime.Now.ToString("dd.MM.yyyy") + ": Задача закрыта");
                    m_TaskInfo.DateFactEnd = date_end_fakt.Value;
                }
                this.Close();
            }
            else
                MessageBox.Show("Выберите исполнителя");
        }

        private void return_task_btn_Click(object sender, EventArgs e)
        {
            if (m_TaskInfo.Status == 0 || m_TaskInfo.Status == 3)
                return;
            this.DialogResult = DialogResult.OK;
            m_TaskInfo.SoglStatus = 0;
            NewChat();
            if (m_TaskInfo.Status == 1)
            {
                m_TaskInfo.Status = 0;
                m_TaskInfo.Chat.Add(DateTime.Now.ToString("dd.MM.yyyy") + ": Задача возвращена на доработку");
               
                
            }
            if (m_TaskInfo.Status == 2)
            {

                m_TaskInfo.Status = 0;
                m_TaskInfo.Chat.Add(DateTime.Now.ToString("dd.MM.yyyy") + ": Перенос срока не согласован");
              
            }
            if (msg_txb.Text.Length > 0)
            {

              
                m_TaskInfo.Chat.Add((DateTime.Now.ToString("dd.MM.yyyy") + ": Cообщение от оператора: " + msg_txb.Text));

            }
            this.Close();

        }

        private void UpdateTaskInfo()
        {
            if(task_text_txb.Text.Length>0)
                m_TaskInfo.TaskContent = task_text_txb.Text;

            m_TaskInfo.Status = ((StatusInfo)status_cmb.SelectedItem).StatusId;
            if(m_TaskInfo.Status == 0)
            {
                m_TaskInfo.DateFactEnd = TaskInfo.NULLDATE;
                m_TaskInfo.DatePerenos = TaskInfo.NULLDATE;
            }

            m_TaskInfo.DateBegin = date_begin_task.Value;
            m_TaskInfo.DateEnd = date_end_task.Value;
           
            m_TaskInfo.IspId = ((UserInfo)users_cmb.SelectedItem).Id;
            if (m_TaskInfo.SoglId != ((UserInfo)users_sogl_cmb.SelectedItem).Id)
                m_TaskInfo.SoglStatus = 0;
            m_TaskInfo.SoglId = ((UserInfo)users_sogl_cmb.SelectedItem).Id;

            if (m_TaskInfo.DateFactEnd != TaskInfo.NULLDATE)
                m_TaskInfo.DateFactEnd = date_end_fakt.Value;
            if (m_TaskInfo.DatePerenos != TaskInfo.NULLDATE)
                m_TaskInfo.DatePerenos = date_perenos.Value;

            if(msg_txb.Text.Length>0)
            {

                NewChat();
                m_TaskInfo.Chat.Add((DateTime.Now.ToString("dd.MM.yyyy")+": Cообщение от оператора: " + msg_txb.Text));
               
            }


        }
        private void NewChat()
        {
            if (m_TaskInfo.Chat == null)
                m_TaskInfo.Chat = new List<string>();
        }
    }
}
