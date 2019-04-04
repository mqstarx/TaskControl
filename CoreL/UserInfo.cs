using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreL
{
    public class UserInfo
    {
        private string m_User;
        private int m_Id;

        public UserInfo(int id,string user)
        {
            m_Id = id;
            m_User = user;
        }
        public string User
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

        public int Id
        {
            get
            {
                return m_Id;
            }

            set
            {
                m_Id = value;
            }
        }
        public override string ToString()
        {
            return m_User;
        }

        public static string GetUserName(List<UserInfo> usrList,int id)
        {
            foreach(UserInfo usr in usrList)
            {
                if (usr.Id == id)
                    return usr.User;
            }
            return "";
        }

    }
}
