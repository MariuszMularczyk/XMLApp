using XMLApp.Dictionaries;
using XMLApp.Domain;
using XMLApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp.Data
{
    public interface ILanguageRepository : IRepository<Language>
    {
        Language GetLanguage(LanguageDictionary languageDictionary);
        List<SelectModelBinder<int>> GetLanguagesToSelect();
    }
}
