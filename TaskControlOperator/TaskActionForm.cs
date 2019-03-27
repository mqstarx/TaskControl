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

        private void users_cmb_TextChanged(object sender, EventArgs e)
        {
           
          /*  if (m_UserList.Count > 0)
            {
                users_cmb.Items.Clear();
                for (int i = 0; i < res.Count; i++)
                {
                    UserInfo ui = new UserInfo();
                    ui.Id = (int)res[i][0];
                    ui.User = (string)res[i][1];

                    users_cmb.Items.Add(ui);
                }
                if (users_cmb.Items.Count > 0)
                    users_cmb.SelectedIndex = 0;
            }*/
        }

        private void TaskActionForm_Shown(object sender, EventArgs e)
        {
            users_cmb.Items.AddRange(m_UserList.ToArray());
        }

        private void confirm_end_task_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
