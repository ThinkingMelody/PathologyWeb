using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathologyWeb
{
    public class CUsers
    {
        public CUsers()
        {

        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserAlias { get; set; }
        public string DoctorCode { get; set; }
        public string Lic { get; set; }
    }
}
