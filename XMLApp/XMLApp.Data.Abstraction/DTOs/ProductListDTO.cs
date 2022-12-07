using XMLApp.Dictionaries;
using XMLApp.Utils;
using XMLApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp.Data
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Calories { get; set; }
    }
}

