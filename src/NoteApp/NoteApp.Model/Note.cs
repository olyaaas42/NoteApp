using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    // <summary> 
    /// Описывает заметку
    /// </summary> 
    public class Note
    {
        /// <summary>
        /// Название заметки. Ограничено 50 символами.
        /// </summary>
        private string _title { get; set; }

        /// <summary>
        /// Категория заметки
        /// </summary>
        private enum CategoryNote { }

        /// <summary>
        /// Teкст заметки
        /// </summary>
        private string _textNote { get; set; }

        /// <summary>
        /// Дата создания заметки. Не меняется. Доступна для чтения.
        /// </summary>
        private DateTime _dateCreated { get; }

        /// <summary>
        /// Дата изменения заметки. Меняется при редактировании.
        /// </summary>
        private DateTime _dateModified { get; set; }

        /// <summary> 
        /// Возвращает или задает название заметки. 
        /// </summary> 
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(_title.Length > 50)
                {
                    throw new ArgumentException($"Название должно быть меньше 50 символов.");
                }
                _title = value;
            }
        }

        /// <summary> 
        /// Возвращает или задает текст заметки. 
        /// </summary> 
        public string TextNote
        {
            get
            {
                return _textNote;
            }
            set
            {
                _textNote = value;
            }
        }

        /// <summary> 
        /// Возвращает или задает дату изменения заметки. 
        /// </summary> 
        public DateTime DataModified
        {
            get
            {
                return _dateModified;
            }
            set
            {
                _dateModified = value;
            }
        }

        /// <summary> 
        /// Возвращает дату создания заметки. 
        /// </summary> 
        public DateTime DataCreated
        {
            get
            {
                return _dateCreated;
            }
        }

        /// <summary> 
        /// Создает экземпляр <see cref="Note">. 
        /// </summary> 
        public Note(string title, string textNote, DateTime dateModified)
        {
            Title = title;
            TextNote = textNote;
            DataModified = dateModified;
        }
    };

}
