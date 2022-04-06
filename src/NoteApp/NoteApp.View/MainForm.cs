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

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        NoteForm noteForm = new NoteForm();
        AboutForm aboutForm = new AboutForm();
        private string filename;
        private string category;

        public MainForm()
        {
            InitializeComponent();
        }

        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //open NoteForm Add/Edit add
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm1 = new NoteForm();
            noteForm1.ShowDialog();

            filename = noteForm1.filename;
            category = noteForm1.category;

            // Добавить файл в listBox
            if (!NoteAppListBox1.Items.Contains(filename))
            {
                NoteAppListBox1.Items.Add(filename);
            }
            else
            {
                MessageBox.Show("Файл с таким названием уже существует");
            }
            if (!NoteAppComboBox1.Items.Contains(category))
            {
                NoteAppComboBox1.Items.Add(category);
            }
        }

        //open NoteForm Add/Edit edit
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteForm = (NoteForm)NoteAppListBox1.SelectedItem;

            noteForm.ShowDialog();

            filename = noteForm.filename;
            category = noteForm.category;



            // Добавить файл в listBox
            //NoteAppListBox1.Items.Add(filename);
            //NoteAppComboBox1.Items.Add(category);
        }

        //remove note
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            index = NoteAppListBox1.SelectedIndex;
            NoteAppListBox1.Items.RemoveAt(index);
        }

        //open AboutForm
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        //open NoteForm Add/Edit add
        private void NoteAppButton1_Click(object sender, EventArgs e)
        {
            NoteForm noteForm1 = new NoteForm();
            noteForm1.ShowDialog();

            filename = noteForm1.filename;
            category = noteForm1.category;

            // Добавить файл в listBox
            if(!NoteAppListBox1.Items.Contains(filename))
            {
                NoteAppListBox1.Items.Add(filename);
            }
            else
            {
                MessageBox.Show("Файл с таким названием уже существует");
            }
            if (!NoteAppComboBox1.Items.Contains(category))
            {
                NoteAppComboBox1.Items.Add(category);
            }
        }

        //open NoteForm Add/Edit edit
        private void NoteAppButton2_Click(object sender, EventArgs e)
        {
            noteForm.ShowDialog();

            filename = noteForm.filename;
            category = noteForm.category;

            // Добавить файл в listBox
            NoteAppListBox1.Items.Add(filename);
            NoteAppComboBox1.Items.Add(category);
        }

        //remove note
        private void NoteAppButton3_Click_1(object sender, EventArgs e)
        {
            int index;
            index = NoteAppListBox1.SelectedIndex;
            NoteAppListBox1.Items.RemoveAt(index);
        }

        //вывод заметки
        private void NoteAppListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Если ничего не выбрано выходим
            if (NoteAppListBox1.SelectedIndex == -1) return;
        }

    }
}
