using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenusApp.WebUI.Model
{
    public static class UserSession
    {
        public static int UserID { get; set; }

        public static string Username { get; set; }

        public static string FullName { get; set; }

        public static int RoleID { get; set; }

        public static string RoleName { get; set; }

        public static bool IsLoggedIn { get; set; }
    }
}
