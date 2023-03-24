using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_admin
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// 


        //mysql
        public static string _Server = "10.10.21.103";
        public static string _Port = "3306";
        public static string _Database = "security";
        public static string _ServerId = "Security";
        public static string _ServerPw = "12345678";
        public static string _connection = string.Format
            (
            "Server={0};" +
            "Port={1};" +
            "Database={2};" +
            "Uid={3};" +
            "Pwd={4}"
            , _Server
            , _Port
            , _Database
            , _ServerId
            , _ServerPw
            );
        ////생성할 커넥션을 담을 변수
        //public static MySqlConnection myConn;
        //public static MySqlCommand cmd;





        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new admin());



        }
    }
}
