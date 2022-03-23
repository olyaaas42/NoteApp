using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public MainForm()
        {
            InitializeComponent();
        }

        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //open NoteForm Add/Edit
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteForm.ShowDialog();
        }

        //open NoteForm Add/Edit
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteForm.ShowDialog();
        }

        //remove note
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //open AboutForm
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        //open NoteForm Add/Edit
        private void NoteAppButton1_Click(object sender, EventArgs e)
        {
            noteForm.ShowDialog();
        }

        //open NoteForm Add/Edit
        private void NoteAppButton2_Click(object sender, EventArgs e)
        {
            noteForm.ShowDialog();
        }

        //remove note
        private void NoteAppButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
