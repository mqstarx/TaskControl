using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreL
{
    public class TaskInfo
    {
        private int m_Id;

       
        
        public static  DateTime NULLDATE = DateTime.Parse("12.03.1986");// т к значение не может быть null ставим по умолчанию эту дату

        private string m_TaskContent;
        
        private int  m_IspId;
        private int m_SoglId;
       
        private DateTime m_DateBegin;
        private DateTime m_DateEnd;
        private DateTime m_DateFactEnd = NULLDATE;
    
        private DateTime m_DatePerenos = NULLDATE;

        private List<string> m_Chat;

        private int m_SoglStatus;
        private int m_Status;


        private string m_UserIsp; // исполнитель (текстом)

        public TaskInfo(int task_id, string taskContent,int isp_id,int sogl_id , DateTime m_DateBegin, DateTime m_DateEnd,int status)
        {

            m_Id = task_id;
            m_IspId = isp_id;
            m_TaskContent = taskContent;
            this.m_DateBegin = m_DateBegin;
            this.m_DateEnd = m_DateEnd;
            m_SoglId = sogl_id;
            m_Chat = new List<string>();
            m_Status = status;
           
        }


        public int Id
        {
            get
            {
                return m_Id;
            }

        }

     

        public string TaskContent
        {
            get
            {
                return m_TaskContent;
            }

            set
            {
                m_TaskContent = value;
            }
        }


     
     
     
     

        /// <summary>
        /// дата начала задачи
        /// </summary>
        public DateTime DateBegin
        {
            get
            {
                return m_DateBegin;
            }

            set
            {
                m_DateBegin = value;
            }
        }

        /// <summary>
        /// срок завершения
        /// </summary>
        public DateTime DateEnd
        {
            get
            {
                return m_DateEnd;
            }

            set
            {
                m_DateEnd = value;
            }
        }

        /// <summary>
        /// Фактический срок завершения
        /// </summary>
        public DateTime DateFactEnd
        {
            get
            {
                return m_DateFactEnd;
            }

            set
            {
                m_DateFactEnd = value;
            }
        }

      

        /// <summary>
        /// запрашиваемая дата переноса
        /// </summary>
        public DateTime DatePerenos
        {
            get
            {
                return m_DatePerenos;
            }

            set
            {
                m_DatePerenos = value;
            }
        }

        /// <summary>
        /// сообщения пользователей;
        /// </summary>
        public List<string> Chat
        {
            get
            {
                return m_Chat;
            }

            set
            {
                m_Chat = value;
            }
        }

        public int IspId
        {
            get
            {
                return m_IspId;
            }

            set
            {
                m_IspId = value;
            }
        }

        public int Status
        {
            get
            {
                return m_Status;
            }

            set
            {
                m_Status = value;
            }
        }

        public string UserIsp
        {
            get
            {
                return m_UserIsp;
            }

            set
            {
                m_UserIsp = value;
            }
        }

        public int SoglId
        {
            get
            {
                return m_SoglId;
            }

            set
            {
                m_SoglId = value;

            }
        }

        public int SoglStatus
        {
            get
            {
                return m_SoglStatus;
            }

            set
            {
                m_SoglStatus = value;
            }
        }

        public string GetChatOneString()
        {
            string result = "";
            foreach (string str in m_Chat)
            {
                result += str + "\n";
            }
            return result;
        }
        public static int DaysDiff(DateTime begin,DateTime end)
        {
            TimeSpan ts = end - begin;
            return ts.Days;
        }
        public TaskInfo Copy()
        {
            TaskInfo ti = new TaskInfo(m_Id, m_TaskContent, m_IspId, m_SoglId, m_DateBegin, m_DateEnd, m_Status);
            ti.DateFactEnd = m_DateFactEnd;
            ti.m_DatePerenos = m_DatePerenos;

            if (m_Chat != null)
            {
                ti.m_Chat = new List<string>();
                ti.m_Chat.AddRange(m_Chat.ToArray());


            }
            ti.m_SoglStatus = m_SoglStatus;
            ti.m_UserIsp = m_UserIsp;
            return ti;
        }

    }
}
