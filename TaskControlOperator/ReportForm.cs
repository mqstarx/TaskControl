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
    public partial class ReportForm : Form
    {

        private List<UserInfo> m_UserList;
        private string m_DbConn;
        public ReportForm()
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

        public string DbConn
        {
            get
            {
                return m_DbConn;
            }

            set
            {
                m_DbConn = value;
            }
        }

        private void ReportForm_Shown(object sender, EventArgs e)
        {
            users_cmb.Items.AddRange(m_UserList.ToArray());
        }

        private void create_report_Click(object sender, EventArgs e)
        {
            report_txb.Text = "";
            string sql = "select * from tasks where ((status=0 or status = 3) and ( (month(date_end)<='" + period.Value.Month.ToString() + "' and year(date_end) = '" + period.Value.Year.ToString() + "'))) and (date_end_fakt > date_end or (now() > date_end and status=0) )  order by id_isp;";

            if(users_cmb.SelectedItem!=null)
             sql = "select * from tasks where ((status=0 or status = 3) and ( (month(date_end)<='" + period.Value.Month.ToString() + "' and year(date_end) = '" + period.Value.Year.ToString() + "'))) and (date_end_fakt > date_end or (now() > date_end and status=0) ) and id_isp='"+((UserInfo)users_cmb.SelectedItem).Id+"' order by id_isp;";

            List<object[]> res = DataBase.SelectQuery(sql, m_DbConn);
            Report rep = new Report(m_UserList);
            for (int i = 0; i < res.Count; i++)
            {
                TaskInfo ti = new TaskInfo((int)res[i][0], (string)res[i][1], (int)res[i][2], (int)res[i][4], (DateTime)res[i][3], (DateTime)res[i][5], (int)res[i][9]);
                ti.DateFactEnd = (DateTime)res[i][8];
                rep.AddTask(ti);
            }

            report_txb.Text = rep.GetReportAllUsers();
        }
    }
}
