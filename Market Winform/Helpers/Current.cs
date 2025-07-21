using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Winform.Helpers
{
    public static class Current
    {
        public static string Username { get; set; } = null;
        public static string PasswordHash { get; set; } = null;
        public static string Token { get; set; } = null;
    }
}
