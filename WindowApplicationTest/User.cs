using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowApplicationTest
{
    class User
    {
        static string userid,userno,noteno;
        public static string UserID
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        public static string UserNo
        {
            get
            {
                return userno;
            }
            set
            {
                userno = value;
            }
        }

        public static string NoteNo
        {
            get
            {
                return noteno;
            }
            set
            {
                noteno = value;
            }
        }
    }
}
