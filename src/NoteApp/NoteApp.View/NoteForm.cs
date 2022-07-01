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
    public partial class NoteForm : Form
    {
        public string filename;
        public string category;
        public bool isFileChanged;

        public NoteForm()
        {
            InitializeComponent();

            Init();
        }

        //button cancel
        private void NoteAppButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //buttom ok
        private void NoteAppButton1_Click(object sender, EventArgs e)
        {
            SaveFile(filename, category);

            this.Close();
        }

        public void Init()
        {
            filename = "";
            category = "";
            isFileChanged = false;

        }
        
        public void CreateNewDocument(object sender, EventArgs e)
        {
            NoteAppTextBox.Text = "";
            filename = "";
            category = "";
        }

        public void SaveFile(string _filename, string _category)
        {
            if (_filename == "" || _filename == filename)
            {
                if (NoteAppSaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = TitleTextBox.Text;
                }
            }
            if (_category == "")
            {
                if (NoteAppSaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _category = CategoryComboBox.Text;
                }
            }

            try
            {
                //StreamWriter sw = new StreamWriter(_filename);
                //sw.Write(NoteAppTextBox2.Text);
                filename = _filename;
                isFileChanged = false;
                category = _category;
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить файл");
            }
        }

        private void CategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
