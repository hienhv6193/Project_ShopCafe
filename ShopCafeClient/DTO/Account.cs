using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.DTO
{
    public class Account
    {
        public int id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String DisplayName { get; set; }
        public int type { get; set; }
    }
}
