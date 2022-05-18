using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    public class Project
    {
        /// <summary>
        /// Список заметок.
        /// </summary>
        public List<string> Note { get; set; } = new List<string>();

    }
}
