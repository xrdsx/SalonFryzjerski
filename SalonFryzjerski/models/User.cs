using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonFryzjerski.models
{
    public class User
    {
        public string username { get; set; }
        public string password_hash { get; set; }
        public int fryzjer_id { get; set; }
    }
}
