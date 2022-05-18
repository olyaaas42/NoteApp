
namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NoteAppListBox1 = new System.Windows.Forms.ListBox();
            this.NoteAppSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoteButton3 = new System.Windows.Forms.Button();
            this.EditButton2 = new System.Windows.Forms.Button();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.ShowCategoryLabel1 = new System.Windows.Forms.Label();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.NoteAppTextBox3 = new System.Windows.Forms.TextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel4 = new System.Windows.Forms.Label();
            this.CreatedLabel3 = new System.Windows.Forms.Label();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.TitleNoteTextBox1 = new System.Windows.Forms.TextBox();
            this.NoteTextBox1 = new System.Windows.Forms.TextBox();
            this.NoteAppMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteAppOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NoteAppSplitContainer1)).BeginInit();
            this.NoteAppSplitContainer1.Panel1.SuspendLayout();
            this.NoteAppSplitContainer1.Panel2.SuspendLayout();
            this.NoteAppSplitContainer1.SuspendLayout();
            this.NoteAppMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteAppListBox1
            // 
            this.NoteAppListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppListBox1.FormattingEnabled = true;
            this.NoteAppListBox1.IntegralHeight = false;
            this.NoteAppListBox1.ItemHeight = 16;
            this.NoteAppListBox1.Location = new System.Drawing.Point(7, 48);
            this.NoteAppListBox1.Name = "NoteAppListBox1";
            this.NoteAppListBox1.Size = new System.Drawing.Size(291, 396);
            this.NoteAppListBox1.TabIndex = 0;
            this.NoteAppListBox1.SelectedIndexChanged += new System.EventHandler(this.NoteAppListBox1_SelectedIndexChanged);
            // 
            // NoteAppSplitContainer1
            // 
            this.NoteAppSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppSplitContainer1.Location = new System.Drawing.Point(2, 30);
            this.NoteAppSplitContainer1.Name = "NoteAppSplitContainer1";
            // 
            // NoteAppSplitContainer1.Panel1
            // 
            this.NoteAppSplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.RemoteButton3);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.EditButton2);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.AddButton1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.CategoryComboBox1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppListBox1);
            // 
            // NoteAppSplitContainer1.Panel2
            // 
            this.NoteAppSplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteAppSplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppTextBox3);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.ModifiedLabel4);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CreatedLabel3);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CategoryLabel2);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.TitleNoteTextBox1);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteTextBox1);
            this.NoteAppSplitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoteAppSplitContainer1.Size = new System.Drawing.Size(879, 499);
            this.NoteAppSplitContainer1.SplitterDistance = 301;
            this.NoteAppSplitContainer1.TabIndex = 5;
            // 
            // RemoteButton3
            // 
            this.RemoteButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoteButton3.BackgroundImage = global::NoteApp.View.Properties.Resources.file_delete_114438;
            this.RemoteButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoteButton3.FlatAppearance.BorderSize = 0;
            this.RemoteButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteButton3.Location = new System.Drawing.Point(114, 450);
            this.RemoteButton3.Name = "RemoteButton3";
            this.RemoteButton3.Size = new System.Drawing.Size(47, 45);
            this.RemoteButton3.TabIndex = 5;
            this.RemoteButton3.UseVisualStyleBackColor = false;
            this.RemoteButton3.Click += new System.EventHandler(this.NoteAppButton3_Click_1);
            // 
            // EditButton2
            // 
            this.EditButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton2.BackgroundImage = global::NoteApp.View.Properties.Resources.file_edit_114433;
            this.EditButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton2.FlatAppearance.BorderSize = 0;
            this.EditButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton2.Location = new System.Drawing.Point(62, 450);
            this.EditButton2.Name = "EditButton2";
            this.EditButton2.Size = new System.Drawing.Size(46, 43);
            this.EditButton2.TabIndex = 4;
            this.EditButton2.UseVisualStyleBackColor = true;
            this.EditButton2.Click += new System.EventHandler(this.NoteAppButton2_Click);
            // 
            // AddButton1
            // 
            this.AddButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton1.BackgroundImage = global::NoteApp.View.Properties.Resources.file_add_114479;
            this.AddButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton1.FlatAppearance.BorderSize = 0;
            this.AddButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton1.Location = new System.Drawing.Point(10, 450);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(46, 42);
            this.AddButton1.TabIndex = 3;
            this.AddButton1.UseVisualStyleBackColor = false;
            this.AddButton1.Click += new System.EventHandler(this.NoteAppButton1_Click);
            // 
            // ShowCategoryLabel1
            // 
            this.ShowCategoryLabel1.AutoSize = true;
            this.ShowCategoryLabel1.Location = new System.Drawing.Point(10, 20);
            this.ShowCategoryLabel1.Name = "ShowCategoryLabel1";
            this.ShowCategoryLabel1.Size = new System.Drawing.Size(107, 17);
            this.ShowCategoryLabel1.TabIndex = 2;
            this.ShowCategoryLabel1.Text = "Show Category:";
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(120, 17);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(178, 24);
            this.CategoryComboBox1.TabIndex = 1;
            // 
            // NoteAppTextBox3
            // 
            this.NoteAppTextBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteAppTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteAppTextBox3.Location = new System.Drawing.Point(85, 35);
            this.NoteAppTextBox3.Name = "NoteAppTextBox3";
            this.NoteAppTextBox3.Size = new System.Drawing.Size(145, 15);
            this.NoteAppTextBox3.TabIndex = 7;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(324, 61);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(144, 22);
            this.ModifiedDateTimePicker.TabIndex = 6;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(85, 61);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(145, 22);
            this.CreatedDateTimePicker.TabIndex = 5;
            // 
            // ModifiedLabel4
            // 
            this.ModifiedLabel4.AutoSize = true;
            this.ModifiedLabel4.Location = new System.Drawing.Point(244, 66);
            this.ModifiedLabel4.Name = "ModifiedLabel4";
            this.ModifiedLabel4.Size = new System.Drawing.Size(65, 17);
            this.ModifiedLabel4.TabIndex = 4;
            this.ModifiedLabel4.Text = "Modified:";
            // 
            // CreatedLabel3
            // 
            this.CreatedLabel3.AutoSize = true;
            this.CreatedLabel3.Location = new System.Drawing.Point(10, 66);
            this.CreatedLabel3.Name = "CreatedLabel3";
            this.CreatedLabel3.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel3.TabIndex = 3;
            this.CreatedLabel3.Text = "Created:";
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(10, 35);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel2.TabIndex = 2;
            this.CategoryLabel2.Text = "Category:";
            // 
            // TitleNoteTextBox1
            // 
            this.TitleNoteTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleNoteTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleNoteTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleNoteTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleNoteTextBox1.Location = new System.Drawing.Point(13, 5);
            this.TitleNoteTextBox1.Name = "TitleNoteTextBox1";
            this.TitleNoteTextBox1.Size = new System.Drawing.Size(327, 27);
            this.TitleNoteTextBox1.TabIndex = 1;
            // 
            // NoteTextBox1
            // 
            this.NoteTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteTextBox1.Location = new System.Drawing.Point(5, 94);
            this.NoteTextBox1.Multiline = true;
            this.NoteTextBox1.Name = "NoteTextBox1";
            this.NoteTextBox1.Size = new System.Drawing.Size(566, 401);
            this.NoteTextBox1.TabIndex = 0;
            // 
            // NoteAppMenuStrip1
            // 
            this.NoteAppMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NoteAppMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.NoteAppMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.NoteAppMenuStrip1.Name = "NoteAppMenuStrip1";
            this.NoteAppMenuStrip1.Size = new System.Drawing.Size(886, 28);
            this.NoteAppMenuStrip1.TabIndex = 4;
            this.NoteAppMenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NoteAppOpenFileDialog1
            // 
            this.NoteAppOpenFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.NoteAppSplitContainer1);
            this.Controls.Add(this.NoteAppMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.NoteAppSplitContainer1.Panel1.ResumeLayout(false);
            this.NoteAppSplitContainer1.Panel1.PerformLayout();
            this.NoteAppSplitContainer1.Panel2.ResumeLayout(false);
            this.NoteAppSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteAppSplitContainer1)).EndInit();
            this.NoteAppSplitContainer1.ResumeLayout(false);
            this.NoteAppMenuStrip1.ResumeLayout(false);
            this.NoteAppMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer NoteAppSplitContainer1;
        private System.Windows.Forms.Button RemoteButton3;
        private System.Windows.Forms.Button EditButton2;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Label ShowCategoryLabel1;
        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.MenuStrip NoteAppMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog NoteAppOpenFileDialog1;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.Label ModifiedLabel4;
        private System.Windows.Forms.Label CreatedLabel3;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.TextBox TitleNoteTextBox1;
        private System.Windows.Forms.TextBox NoteTextBox1;
        private System.Windows.Forms.TextBox NoteAppTextBox3;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ListBox NoteAppListBox1;
    }
}

