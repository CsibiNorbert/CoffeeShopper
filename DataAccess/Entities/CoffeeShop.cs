using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    [Table("CoffeeShop")]
    public class CoffeeShop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string OpeningHours { get; set; }

        public string Address { get; set; }
    }
}
