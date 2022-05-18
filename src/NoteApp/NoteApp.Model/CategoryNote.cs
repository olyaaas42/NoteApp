using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    public class CategoryNote
    {
        /// <summary>
        /// Категории заметок.
        /// </summary>
        enum Category
        {
            Work,
            Home,
            HealthAndSport,
            People,
            Document,
            Finance,
            Other
        }
    };
}
