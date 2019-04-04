using CoreL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskControlOperator
{
    public class Report
    {
        private List<UserTasks> m_UserTasksList;
        private List<UserInfo> m_Users;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usrlist">список всех пользователей</param>
        public Report(List<UserInfo> usrlist)
        {
            m_UserTasksList = new List<UserTasks>();
            m_Users = usrlist;
            if (m_Users == null)
                m_Users = new List<UserInfo>();
        }


        public void AddTask(TaskInfo task)
        {
            for (int i = 0; i < m_Users.Count; i++)
            {
                if (m_Users[i].Id == task.IspId)
                {
                    if (m_UserTasksList.Count == 0)
                    {
                        UserTasks ut = new UserTasks(m_Users[i]);
                        ut.Tasks.Add(task.Copy());
                        m_UserTasksList.Add(ut);
                    }
                    else
                    {
                        bool have_task = false;
                        for (int j = 0; j < m_UserTasksList.Count; j++)
                        {
                            if (m_UserTasksList[j].User.Id == task.IspId)
                            {

                                m_UserTasksList[j].Tasks.Add(task);
                                have_task = true;
                                break;
                            }
                           
                        }
                        if(!have_task)
                        {
                            UserTasks ut = new UserTasks(m_Users[i]);
                            ut.Tasks.Add(task);
                            m_UserTasksList.Add(ut);
                            break;
                        }
                    }

                }
            }


        }

        public string GetReportAllUsers()
        {
            string result = "";

            for (int i = 0; i < m_UserTasksList.Count; i++)
            {
                int days_counter = 0;
                result += m_UserTasksList[i].User.User + ": \r\n";
                for (int j = 0; j < m_UserTasksList[i].Tasks.Count; j++)
                {
                    if (m_UserTasksList[i].Tasks[j].Status == 3)
                    {
                        days_counter += TaskInfo.DaysDiff(m_UserTasksList[i].Tasks[j].DateEnd, m_UserTasksList[i].Tasks[j].DateFactEnd);
                        result += "Задача: " + m_UserTasksList[i].Tasks[j].TaskContent.Replace(Environment.NewLine, " ") + "\r\nСтатус: " + DataBase.GetStatus(m_UserTasksList[i].Tasks[j].Status).ToString() + "\r\nПросрочено дней: " + TaskInfo.DaysDiff(m_UserTasksList[i].Tasks[j].DateEnd, m_UserTasksList[i].Tasks[j].DateFactEnd).ToString()+"\r\n";
                    }
                    if (m_UserTasksList[i].Tasks[j].Status == 0)
                    {
                        days_counter += TaskInfo.DaysDiff(m_UserTasksList[i].Tasks[j].DateEnd, DateTime.Now);
                        result += "Задача: " + m_UserTasksList[i].Tasks[j].TaskContent.Replace(Environment.NewLine, " ") + "\r\nСтатус: " + DataBase.GetStatus(m_UserTasksList[i].Tasks[j].Status).ToString() + "\r\nПросрочено дней: " + TaskInfo.DaysDiff(m_UserTasksList[i].Tasks[j].DateEnd,DateTime.Now).ToString() + "\r\n";
                    }
                }
                
                result += "Всего дней просрочено: "+ days_counter.ToString() + "\r\nКоэффициент снижения: "+((double)((double)days_counter/100)).ToString()+ "\r\n\r\n\r\n";
            }


            return result;
        }



        /// <summary>
        /// определяет список задач одного пользователя
        /// </summary>
        public class UserTasks
        {
            private UserInfo m_User;

            private List<TaskInfo> m_Tasks;

            public UserTasks(UserInfo user)
            {
                m_Tasks = new List<TaskInfo>();
                m_User = user;
            }
            public UserInfo User
            {
                get
                {
                    return m_User;
                }

                set
                {
                    m_User = value;
                }
            }

            public List<TaskInfo> Tasks
            {
                get
                {
                    return m_Tasks;
                }

                set
                {
                    m_Tasks = value;
                }
            }
        }
    }
}