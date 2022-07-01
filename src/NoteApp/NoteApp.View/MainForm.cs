using System;
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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения объектов заметок.
        /// </summary>
        private Project _project;

        public MainForm()
        {
            _project = new Project();
            InitializeComponent();
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите выйти?");
            this.Close();
        }

        /// <summary>
        /// Добавление новой заметки через меню рандомно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Note note = new Note();
            note.Title = random.Next().ToString();
            note.Text = random.Next().ToString();
            _project.Notes.Add(note);
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Открытие окна About.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abourForm = new AboutForm();
            abourForm.ShowDialog();
        }


        /// <summary>
        /// Обновить список заметок.
        /// </summary>
        private void UpdateListBox()
        {
            NoteAppListBox.Items.Clear();
            foreach (Note note in _project.Notes)
            {
                NoteAppListBox.Items.Add(note.Title);
            }
        }

        /// <summary>
        /// Добавление заметок.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
            }
        }

        /// <summary>
        /// Удаление заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Добавление заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                MessageBox.Show("Нет заметок или заметка для удаления не выбрана");
            }
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить {NoteAppListBox.SelectedItem}?",
                "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                NoteAppListBox.SelectedItem = null;
            }
            else return;
        }

        /// <summary>
        /// Обновить поле описания заметки.
        /// </summary>
        /// <param name="index">Индекс заметки.</param>
        private void UpdateSelectedNote(int index)
        {
            if (NoteAppListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
                return;
            }
            NoteAppTextBox.Text = _project.Notes[index].Text;
            TitleNoteTextBox.Text = _project.Notes[index].Title;
            CreatedDateTimePicker.Value = _project.Notes[index].CreateTime;
            ModifiedDateTimePicker.Value = _project.Notes[index].ModifiedTime;
            TextLabel.Text = _project.Notes[index].Category.ToString();
        }

        /// <summary>
        /// Обработчик изменения выбранной заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteAppListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedNote(NoteAppListBox.SelectedIndex);
        }

        /// <summary>
        /// Очистить поле описания заметки.
        /// </summary>
        private void ClearSelectedNote()
        {
            NoteAppTextBox.Text = string.Empty;
            TitleNoteTextBox.Text = string.Empty;
            CreatedDateTimePicker.Value = DateTime.Now;
            ModifiedDateTimePicker.Value = DateTime.Now;
            TextLabel.Text = string.Empty;
        }

        /// <summary>
        /// Редактирование заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
            }
            if ((NoteAppListBox.Items.Count != 0) && (currentIndex < NoteAppListBox.Items.Count))
            {
                NoteAppListBox.SelectedIndex = currentIndex;
            }
        }
    }
}
