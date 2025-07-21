using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Winform.Helpers
{
    public static class ApiClient
    {
        public static readonly HttpClient Client;

        static ApiClient()
        {
            Client = new HttpClient();
        }
    }

}
