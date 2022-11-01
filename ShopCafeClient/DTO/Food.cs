using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.DTO
{
    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int idCategory { get; set; }
    }
}
