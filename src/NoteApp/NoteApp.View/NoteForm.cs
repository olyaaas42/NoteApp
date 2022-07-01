﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Переменная заметки.
        /// </summary>
        private Note _note = new Note();

        /// <summary>
        /// Переменная заметки копирования.
        /// </summary>
        private Note _noteCopy = new Note();

        /// <summary>
        /// Строка для вывода ошибки.
        /// </summary>
        private string _noteError;

        /// <summary>
        /// Константа для корректного цвета. 
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Константа для цвета ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        public NoteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает и возвращает объект заметки.
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    _noteCopy = (Note)_note.Clone();
                }
                else
                {
                    _noteCopy = new Note();
                }
                UpdateForm();
            }
        }


        /// <summary>
        /// Метод обновления формы.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _noteCopy.Title;
            CreatedDateTimePicker.Value = _noteCopy.CreateTime;
            ModifiedDateTimePicker.Value = _noteCopy.ModifiedTime;
            NoteAppTextBox.Text = _noteCopy.Text;
        }

        /// <summary>
        /// Метод обновления заметки.
        /// </summary>
        private void UpdateNote()
        {
            _noteCopy.Title = TitleTextBox.Text;
            _noteCopy.Text = NoteAppTextBox.Text;
        }

        /// <summary>
        /// Метод обработки и валидации названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _correctColor;
                _noteError = "";
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _errorColor;
                _noteError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на анличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if (_noteError != "")
            {
                ///MessageBox.Show(_noteError);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Завершение редактирования кнопкой OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                UpdateNote();
                _note = _noteCopy;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Закрытие окна редактирования кнопкой cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
