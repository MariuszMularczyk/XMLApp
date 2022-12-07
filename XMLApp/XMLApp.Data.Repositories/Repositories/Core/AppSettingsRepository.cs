using XMLApp.Domain;
using XMLApp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp.Data
{
    public class AppSettingsRepository : Repository<AppSetting, MainDatabaseContext>, IAppSettingsRepository
    {
        public AppSettingsRepository(MainDatabaseContext context)
            : base(context)
        {
        }

    }
}
