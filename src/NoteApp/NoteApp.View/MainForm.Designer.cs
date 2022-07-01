
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
            this.NoteAppListBox = new System.Windows.Forms.ListBox();
            this.NoteAppSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleNoteTextBox = new System.Windows.Forms.TextBox();
            this.NoteAppTextBox = new System.Windows.Forms.TextBox();
            this.NoteAppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteAppOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NoteAppSplitContainer1)).BeginInit();
            this.NoteAppSplitContainer1.Panel1.SuspendLayout();
            this.NoteAppSplitContainer1.Panel2.SuspendLayout();
            this.NoteAppSplitContainer1.SuspendLayout();
            this.NoteAppMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteAppListBox
            // 
            this.NoteAppListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppListBox.FormattingEnabled = true;
            this.NoteAppListBox.IntegralHeight = false;
            this.NoteAppListBox.ItemHeight = 16;
            this.NoteAppListBox.Location = new System.Drawing.Point(7, 48);
            this.NoteAppListBox.Name = "NoteAppListBox";
            this.NoteAppListBox.Size = new System.Drawing.Size(291, 396);
            this.NoteAppListBox.TabIndex = 0;
            this.NoteAppListBox.SelectedIndexChanged += new System.EventHandler(this.NoteAppListBox_SelectedIndexChanged);
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
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.RemoteButton);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.EditButton);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.AddButton);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppListBox);
            // 
            // NoteAppSplitContainer1.Panel2
            // 
            this.NoteAppSplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteAppSplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.TextLabel);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.TitleNoteTextBox);
            this.NoteAppSplitContainer1.Panel2.Controls.Add(this.NoteAppTextBox);
            this.NoteAppSplitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoteAppSplitContainer1.Size = new System.Drawing.Size(879, 499);
            this.NoteAppSplitContainer1.SplitterDistance = 301;
            this.NoteAppSplitContainer1.TabIndex = 5;
            // 
            // RemoteButton
            // 
            this.RemoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.file_delete_114438;
            this.RemoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoteButton.FlatAppearance.BorderSize = 0;
            this.RemoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteButton.Location = new System.Drawing.Point(114, 450);
            this.RemoteButton.Name = "RemoteButton";
            this.RemoteButton.Size = new System.Drawing.Size(47, 45);
            this.RemoteButton.TabIndex = 5;
            this.RemoteButton.UseVisualStyleBackColor = false;
            this.RemoteButton.Click += new System.EventHandler(this.RemoteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackgroundImage = global::NoteApp.View.Properties.Resources.file_edit_114433;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(62, 450);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(46, 43);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.BackgroundImage = global::NoteApp.View.Properties.Resources.file_add_114479;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(10, 450);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(46, 42);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(10, 20);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(107, 17);
            this.ShowCategoryLabel.TabIndex = 2;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(120, 17);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(178, 24);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(85, 35);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(0, 17);
            this.TextLabel.TabIndex = 7;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(324, 61);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(144, 22);
            this.ModifiedDateTimePicker.TabIndex = 6;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(85, 61);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(145, 22);
            this.CreatedDateTimePicker.TabIndex = 5;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(244, 66);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedLabel.TabIndex = 4;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(10, 66);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel.TabIndex = 3;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(10, 35);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // TitleNoteTextBox
            // 
            this.TitleNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleNoteTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleNoteTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleNoteTextBox.Location = new System.Drawing.Point(13, 5);
            this.TitleNoteTextBox.Name = "TitleNoteTextBox";
            this.TitleNoteTextBox.Size = new System.Drawing.Size(327, 23);
            this.TitleNoteTextBox.TabIndex = 1;
            // 
            // NoteAppTextBox
            // 
            this.NoteAppTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoteAppTextBox.Location = new System.Drawing.Point(5, 94);
            this.NoteAppTextBox.Multiline = true;
            this.NoteAppTextBox.Name = "NoteAppTextBox";
            this.NoteAppTextBox.Size = new System.Drawing.Size(566, 401);
            this.NoteAppTextBox.TabIndex = 0;
            // 
            // NoteAppMenuStrip
            // 
            this.NoteAppMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NoteAppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.NoteAppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NoteAppMenuStrip.Name = "NoteAppMenuStrip";
            this.NoteAppMenuStrip.Size = new System.Drawing.Size(886, 28);
            this.NoteAppMenuStrip.TabIndex = 4;
            this.NoteAppMenuStrip.Text = "menuStrip1";
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
            // NoteAppOpenFileDialog
            // 
            this.NoteAppOpenFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.NoteAppSplitContainer1);
            this.Controls.Add(this.NoteAppMenuStrip);
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
            this.NoteAppMenuStrip.ResumeLayout(false);
            this.NoteAppMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer NoteAppSplitContainer1;
        private System.Windows.Forms.Button RemoteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.MenuStrip NoteAppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog NoteAppOpenFileDialog;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleNoteTextBox;
        private System.Windows.Forms.TextBox NoteAppTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ListBox NoteAppListBox;
        private System.Windows.Forms.Label TextLabel;
    }
}

