using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLApp.Dictionaries;

namespace XMLApp.Domain
{
    public class AppSetting : Entity
    {
        public string Value { get; set; }
        public AppSettingEnum Type { get; set; }
    }
}
