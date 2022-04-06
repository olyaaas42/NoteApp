
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
            this.NoteAppSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NoteAppButton3 = new System.Windows.Forms.Button();
            this.NoteAppButton2 = new System.Windows.Forms.Button();
            this.NoteAppButton1 = new System.Windows.Forms.Button();
            this.NoteAppLabel1 = new System.Windows.Forms.Label();
            this.NoteAppComboBox1 = new System.Windows.Forms.ComboBox();
            this.NoteAppListBox1 = new System.Windows.Forms.ListBox();
            this.NoteAppDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NoteAppLabel4 = new System.Windows.Forms.Label();
            this.NoteAppLabel3 = new System.Windows.Forms.Label();
            this.NoteAppLabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NoteAppTextBox1 = new System.Windows.Forms.TextBox();
            this.NoteAppMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteAppOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NoteAppDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NoteAppTextBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NoteAppSplitContainer1)).BeginInit();
            this.NoteAppSplitContainer1.Panel1.SuspendLayout();
            this.NoteAppSplitContainer1.Panel2.SuspendLayout();
            this.NoteAppSplitContainer1.SuspendLayout();
            this.NoteAppMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.NoteAppSplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton3);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton2);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppLabel1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppComboBox1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppListBox1);
            // 
            // NoteAppSplitContainer1.Panel2
            // 
            this.NoteAppSplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NoteAppSplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppTextBox3);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppDateTimePicker2);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppDateTimePicker1);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppLabel4);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppLabel3);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppLabel2);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.textBox1);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppTextBox1);
            this.NoteAppSplitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoteAppSplitContainer1.Size = new System.Drawing.Size(892, 537);
            this.NoteAppSplitContainer1.SplitterDistance = 298;
            this.NoteAppSplitContainer1.TabIndex = 5;
            // 
            // NoteAppButton3
            // 
            this.NoteAppButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteAppButton3.BackgroundImage = global::NoteApp.View.Properties.Resources.delete_file_icon_icons_com_71692__1_;
            this.NoteAppButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton3.Location = new System.Drawing.Point(129, 484);
            this.NoteAppButton3.Name = "NoteAppButton3";
            this.NoteAppButton3.Size = new System.Drawing.Size(46, 50);
            this.NoteAppButton3.TabIndex = 5;
            this.NoteAppButton3.UseVisualStyleBackColor = true;
            this.NoteAppButton3.Click += new System.EventHandler(this.NoteAppButton3_Click_1);
            // 
            // NoteAppButton2
            // 
            this.NoteAppButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteAppButton2.BackgroundImage = global::NoteApp.View.Properties.Resources.file_document_edit_outline_icon_139608;
            this.NoteAppButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton2.Location = new System.Drawing.Point(71, 485);
            this.NoteAppButton2.Name = "NoteAppButton2";
            this.NoteAppButton2.Size = new System.Drawing.Size(46, 48);
            this.NoteAppButton2.TabIndex = 4;
            this.NoteAppButton2.UseVisualStyleBackColor = true;
            this.NoteAppButton2.Click += new System.EventHandler(this.NoteAppButton2_Click);
            // 
            // NoteAppButton1
            // 
            this.NoteAppButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteAppButton1.BackgroundImage = global::NoteApp.View.Properties.Resources.Add_File_icon_icons_com_55973;
            this.NoteAppButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton1.Location = new System.Drawing.Point(11, 485);
            this.NoteAppButton1.Name = "NoteAppButton1";
            this.NoteAppButton1.Size = new System.Drawing.Size(46, 48);
            this.NoteAppButton1.TabIndex = 3;
            this.NoteAppButton1.UseVisualStyleBackColor = true;
            this.NoteAppButton1.Click += new System.EventHandler(this.NoteAppButton1_Click);
            // 
            // NoteAppLabel1
            // 
            this.NoteAppLabel1.AutoSize = true;
            this.NoteAppLabel1.Location = new System.Drawing.Point(10, 16);
            this.NoteAppLabel1.Name = "NoteAppLabel1";
            this.NoteAppLabel1.Size = new System.Drawing.Size(107, 17);
            this.NoteAppLabel1.TabIndex = 2;
            this.NoteAppLabel1.Text = "Show Category:";
            // 
            // NoteAppComboBox1
            // 
            this.NoteAppComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppComboBox1.FormattingEnabled = true;
            this.NoteAppComboBox1.Location = new System.Drawing.Point(129, 13);
            this.NoteAppComboBox1.Name = "NoteAppComboBox1";
            this.NoteAppComboBox1.Size = new System.Drawing.Size(126, 24);
            this.NoteAppComboBox1.TabIndex = 1;
            // 
            // NoteAppListBox1
            // 
            this.NoteAppListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppListBox1.FormattingEnabled = true;
            this.NoteAppListBox1.ItemHeight = 16;
            this.NoteAppListBox1.Location = new System.Drawing.Point(13, 43);
            this.NoteAppListBox1.Name = "NoteAppListBox1";
            this.NoteAppListBox1.Size = new System.Drawing.Size(278, 404);
            this.NoteAppListBox1.TabIndex = 0;
            this.NoteAppListBox1.SelectedIndexChanged += new System.EventHandler(this.NoteAppListBox1_SelectedIndexChanged);
            // 
            // NoteAppDateTimePicker1
            // 
            this.NoteAppDateTimePicker1.Location = new System.Drawing.Point(96, 104);
            this.NoteAppDateTimePicker1.Name = "NoteAppDateTimePicker1";
            this.NoteAppDateTimePicker1.Size = new System.Drawing.Size(147, 22);
            this.NoteAppDateTimePicker1.TabIndex = 5;
            // 
            // NoteAppLabel4
            // 
            this.NoteAppLabel4.AutoSize = true;
            this.NoteAppLabel4.Location = new System.Drawing.Point(260, 104);
            this.NoteAppLabel4.Name = "NoteAppLabel4";
            this.NoteAppLabel4.Size = new System.Drawing.Size(65, 17);
            this.NoteAppLabel4.TabIndex = 4;
            this.NoteAppLabel4.Text = "Modified:";
            // 
            // NoteAppLabel3
            // 
            this.NoteAppLabel3.AutoSize = true;
            this.NoteAppLabel3.Location = new System.Drawing.Point(28, 104);
            this.NoteAppLabel3.Name = "NoteAppLabel3";
            this.NoteAppLabel3.Size = new System.Drawing.Size(62, 17);
            this.NoteAppLabel3.TabIndex = 3;
            this.NoteAppLabel3.Text = "Created:";
            // 
            // NoteAppLabel2
            // 
            this.NoteAppLabel2.AutoSize = true;
            this.NoteAppLabel2.Location = new System.Drawing.Point(28, 59);
            this.NoteAppLabel2.Name = "NoteAppLabel2";
            this.NoteAppLabel2.Size = new System.Drawing.Size(69, 17);
            this.NoteAppLabel2.TabIndex = 2;
            this.NoteAppLabel2.Text = "Category:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 22);
            this.textBox1.TabIndex = 1;
            // 
            // NoteAppTextBox1
            // 
            this.NoteAppTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppTextBox1.Location = new System.Drawing.Point(5, 153);
            this.NoteAppTextBox1.Multiline = true;
            this.NoteAppTextBox1.Name = "NoteAppTextBox1";
            this.NoteAppTextBox1.Size = new System.Drawing.Size(576, 374);
            this.NoteAppTextBox1.TabIndex = 0;
            // 
            // NoteAppMenuStrip1
            // 
            this.NoteAppMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NoteAppMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.NoteAppMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.NoteAppMenuStrip1.Name = "NoteAppMenuStrip1";
            this.NoteAppMenuStrip1.Size = new System.Drawing.Size(899, 28);
            this.NoteAppMenuStrip1.TabIndex = 4;
            this.NoteAppMenuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NoteAppOpenFileDialog1
            // 
            this.NoteAppOpenFileDialog1.FileName = "openFileDialog1";
            // 
            // NoteAppDateTimePicker2
            // 
            this.NoteAppDateTimePicker2.Location = new System.Drawing.Point(331, 104);
            this.NoteAppDateTimePicker2.Name = "NoteAppDateTimePicker2";
            this.NoteAppDateTimePicker2.Size = new System.Drawing.Size(162, 22);
            this.NoteAppDateTimePicker2.TabIndex = 6;
            // 
            // NoteAppTextBox3
            // 
            this.NoteAppTextBox3.Location = new System.Drawing.Point(103, 59);
            this.NoteAppTextBox3.Name = "NoteAppTextBox3";
            this.NoteAppTextBox3.Size = new System.Drawing.Size(119, 22);
            this.NoteAppTextBox3.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 569);
            this.Controls.Add(this.NoteAppSplitContainer1);
            this.Controls.Add(this.NoteAppMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button NoteAppButton3;
        private System.Windows.Forms.Button NoteAppButton2;
        private System.Windows.Forms.Button NoteAppButton1;
        private System.Windows.Forms.Label NoteAppLabel1;
        private System.Windows.Forms.ComboBox NoteAppComboBox1;
        private System.Windows.Forms.ListBox NoteAppListBox1;
        private System.Windows.Forms.MenuStrip NoteAppMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog NoteAppOpenFileDialog1;
        private System.Windows.Forms.DateTimePicker NoteAppDateTimePicker1;
        private System.Windows.Forms.Label NoteAppLabel4;
        private System.Windows.Forms.Label NoteAppLabel3;
        private System.Windows.Forms.Label NoteAppLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NoteAppTextBox1;
        private System.Windows.Forms.TextBox NoteAppTextBox3;
        private System.Windows.Forms.DateTimePicker NoteAppDateTimePicker2;
    }
}

