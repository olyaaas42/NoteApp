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

        /// <summary>
        /// Показывать все заметки без учета категории
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// отображение списка заметок
        /// </summary>
        private List<Note> _currentNotes;

        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
            _project = ProjectSerializer.LoadFromFile();
            _currentNotes = _project.Notes;
            CategoryComboBox.SelectedIndex = 0;
            ClearSelectedNote();
            UpdateListBox();
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdateListBox();
                NoteAppListBox.SelectedIndex = -1;
                ProjectSerializer.SaveToFile(_project);
            }
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
            Note note = _currentNotes[index];
            index = FindNoteIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
                OutputByCategory();
                UpdateSelectedNote(NoteAppListBox.SelectedIndex);
                UpdateListBox();
                ProjectSerializer.SaveToFile(_project);
            }
            if ((NoteAppListBox.Items.Count != 0) && (currentIndex < NoteAppListBox.Items.Count))
            {
                NoteAppListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Удалить заметку.
        /// </summary>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _project.Notes[index];
            index = FindNoteIndex(index);
            var result = MessageBox.Show("Вы действительно хотите удалить " + "\"" + NoteAppListBox.SelectedItem.ToString()
                + "\"" + "?", "Удалить заметку?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
                OutputByCategory();
                UpdateListBox();
                ProjectSerializer.SaveToFile(_project);
            }
            if ((NoteAppListBox.Items.Count != 0) && (currentIndex < NoteAppListBox.Items.Count))
            {
                NoteAppListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Метод для заполнения.
        /// </summary>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0) || (_currentNotes.Count <= index))
            {
                ClearSelectedNote();
                return;
            }
            Note note = _currentNotes[index];
            NoteAppTextBox.Text = note.Text;
            TextLabel.Text = Enum.GetName(typeof(NoteCategory), note.Category);
            NameLabel.Text = note.Title;
            CreatedDateTimePicker.Visible = true;
            ModifiedDateTimePicker.Visible = true;
            CreatedDateTimePicker.Value = note.CreateTime;
            ModifiedDateTimePicker.Value = note.ModifiedTime;
        }

        /// <summary>
        /// Метод для очистки.
        /// </summary>
        private void ClearSelectedNote()
        {
            NameLabel.Text = "";
            NoteAppTextBox.Text = "";
            TextLabel.Text = "";
            CreatedDateTimePicker.Visible = false;
            ModifiedDateTimePicker.Visible = false;
        }

        /// <summary>
        /// Метод для обновления.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteAppListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(NoteAppListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = new NoteCategory();
                foreach (var category in Enum.GetValues(typeof(NoteCategory)))
                {
                    if (CategoryComboBox.SelectedItem.ToString() == category.ToString())
                    {
                        noteCategory = (NoteCategory)category;
                    }
                }
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории
        /// </summary>
        private int FindNoteIndex(int index)
        {
            return _project.Notes.IndexOf(_currentNotes[index]);
        }

        /// <summary>
        /// Обновляет список заметок в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            NoteAppListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                NoteAppListBox.Items.Add(_currentNotes[i].Title);
            }
        }

        /// <summary>
        /// Добавление новой заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Удаление заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Окно About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        /// <summary>
        /// Закрытие окна приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите выйти?");
            this.Close();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdateListBox();
        }

        /// <summary>
        /// Добавление заметки через иконку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование заметки через иконку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Удаление заметки через иконку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NoteAppListBox.SelectedIndex);
            UpdateListBox();
        }
    }
}
