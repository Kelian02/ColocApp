using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Fruit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FruitID { get; set; }

        public string FruitName { get; set; }

        public int Quantity { get; set; }

        public DateOnly Date_Achat { get; set; }
    }
}

