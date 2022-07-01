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
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки. Ограничено 50 символами.
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory Category { get; set; }

        /// <summary>
        /// Teкст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Дата создания заметки. Не меняется. Доступна для чтения.
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата изменения заметки. Меняется при редактировании.
        /// </summary>
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private const int NOTETITLELIMIT = 50;

        /// <summary>
        /// Название по умолчанию.
        /// </summary>
        private const string DEFAULTTITLE = "Без Названия";

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
                if (value.Length > NOTETITLELIMIT)
                {
                    throw new ArgumentException("Max title length = 50");
                }
                if (value == string.Empty)
                {
                    _title = DEFAULTTITLE;
                }

                _title = value;
                ModifiedTime = DateTime.Now;
            }
        }

        /// <summary> 
        /// Возвращает или задает текст заметки. 
        /// </summary> 
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                ModifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Копирования объекта, интерфейс ICloneable
        /// </summary>
        public object Clone()
        {
            Note note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note.Category = this.Category;
            note.CreateTime = this.CreateTime;
            note.ModifiedTime = this.ModifiedTime;
            return note;
        }
    };

}
