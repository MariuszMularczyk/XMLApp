using XMLApp.Dictionaries;
using XMLApp.Resources.Shared;
using XMLApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp.Application
{
    public class ProductEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Calories { get; set; }
    }
}
