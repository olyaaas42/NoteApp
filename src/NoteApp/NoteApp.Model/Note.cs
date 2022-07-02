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
    public class Note: ICloneable
    {
        /// <summary>
        /// Название заметки. Ограничено 50 символами.
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory _category;

        /// <summary>
        /// Teкст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Дата создания заметки. Не меняется. Доступна для чтения.
        /// </summary>
        public DateTime _creationDate = DateTime.Now;

        /// <summary>
        /// Дата изменения заметки. Меняется при редактировании.
        /// </summary>
        public DateTime _modifiedTime;

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
                _modifiedTime = DateTime.Now;
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
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает дату создания заметки
        /// </summary>
        public DateTime CreateTime
        {
            get
            {
                return _creationDate;
            }
        }

        /// <summary>
        /// Возвращает дату изменения заметки
        /// </summary>
        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedTime;
            }
        }

        /// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Создает экземпляр заметки.
        /// </summary>
        public Note(string name, NoteCategory category, string text)
        {
            Title = name;
            Category = category;
            Text = text;
        }

        public Note() { }

        /// <summary>
        /// Метод копирования.
        /// </summary>
        public object Clone()
        {
            return new Note(this.Title, this.Category, this.Text);
        }
    };

}
