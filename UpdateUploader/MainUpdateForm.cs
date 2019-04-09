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

namespace UpdateUploader
{
    public partial class MainUpdateForm : Form
    {
        Cfg m_Cfg;
        UFiles m_Files;
        public MainUpdateForm()
        {
            InitializeComponent();
            m_Cfg = Cfg.ReadConfig();
            if (m_Cfg == null)
                this.Close();
            m_Files = new UFiles();
        }

        private void obzor_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                FileToUpdate fu = new FileToUpdate(op.FileName);
                m_Files.FilesList.Add(fu);
                listBox1.Items.Add(fu);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (m_Files.FilesList.Count > 0 && textBox1.Text.Length > 0)
            {
                if (!checkBox1.Checked)
                    DataBase.InsertFilesQuery(m_Files, textBox1.Text, m_Cfg.DbConnectionString);
                else
                    DataBase.InsertFilesOperatorQuery(m_Files, textBox1.Text, m_Cfg.DbConnectionString);
                m_Files.FilesList.Clear();
                listBox1.Items.Clear();

            }
        }
    }
}
