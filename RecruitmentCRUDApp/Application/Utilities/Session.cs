using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication.Utilities
{
    public static class Session
    {
        public static int? CurrentUserId { get; set; }
        public static string UserType { get; set; }
        public static void Login(int userId, string userType)
        {
            CurrentUserId = userId;
            UserType = userType;
        }

        public static void Logout()
        {
            CurrentUserId = null;
        }

        public static bool IsAuthenticated => CurrentUserId != null;

    }
}
