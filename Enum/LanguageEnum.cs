
using System.ComponentModel.DataAnnotations;

namespace BookStore.Enum
{
    public enum LanguageEnum
    {
        [Display(Name="Hindi Language")] //To change text of existing language
        Hindi=10,
        English=20,
        Urdu=30,
        French=40,
        Tamil=60,
        Marathi=70,
        BhojPuri=80,
        Japanese=90,
    }
}