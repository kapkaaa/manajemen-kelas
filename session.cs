using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manajemen_kelas
{
    internal class session
    {
    }
    public static class Session
    {
        public static int CurrentUserID { get; set; }
        public static string CurrentUserName { get; set; }
        public static int CurrentRole { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void Clear()
        {
            CurrentUserID = 0;
            CurrentUserName = null;
            CurrentRole = 0;
            IsLoggedIn = false;
        }
    }

}
