using XMLApp.Dictionaries;
using XMLApp.Resources.Shared;
using XMLApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLApp.Application
{
    [XmlRoot("breakfast_menu")]
    public class ProductModel
    {
        [XmlElement("food")]
        public List<Food> Foods { get; set; }
    }

    public class Food
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("calories")]
        public int Calories { get; set; }
    }
}

