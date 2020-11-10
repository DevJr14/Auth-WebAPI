using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AppSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_App_Url { get; set; } 
    }
}
