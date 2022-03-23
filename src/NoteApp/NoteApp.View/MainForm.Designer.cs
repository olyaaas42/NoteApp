
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
            this.NoteAppLabel1 = new System.Windows.Forms.Label();
            this.NoteAppComboBox1 = new System.Windows.Forms.ComboBox();
            this.NoteAppListBox1 = new System.Windows.Forms.ListBox();
            this.NoteAppMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteAppButton3 = new System.Windows.Forms.Button();
            this.NoteAppButton2 = new System.Windows.Forms.Button();
            this.NoteAppButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteAppSplitContainer1)).BeginInit();
            this.NoteAppSplitContainer1.Panel1.SuspendLayout();
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
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton3);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton2);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppButton1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppLabel1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppComboBox1);
            this.NoteAppSplitContainer1.Panel1.Controls.Add(this.NoteAppListBox1);
            // 
            // NoteAppSplitContainer1.Panel2
            // 
            this.NoteAppSplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppSplitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoteAppSplitContainer1.Size = new System.Drawing.Size(1000, 570);
            this.NoteAppSplitContainer1.SplitterDistance = 332;
            this.NoteAppSplitContainer1.TabIndex = 5;
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
            this.NoteAppComboBox1.Size = new System.Drawing.Size(162, 24);
            this.NoteAppComboBox1.TabIndex = 1;
            // 
            // NoteAppListBox1
            // 
            this.NoteAppListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppListBox1.FormattingEnabled = true;
            this.NoteAppListBox1.ItemHeight = 16;
            this.NoteAppListBox1.Location = new System.Drawing.Point(10, 43);
            this.NoteAppListBox1.Name = "NoteAppListBox1";
            this.NoteAppListBox1.Size = new System.Drawing.Size(305, 468);
            this.NoteAppListBox1.TabIndex = 0;
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
            this.NoteAppMenuStrip1.Size = new System.Drawing.Size(978, 30);
            this.NoteAppMenuStrip1.TabIndex = 4;
            this.NoteAppMenuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NoteAppButton3
            // 
            this.NoteAppButton3.BackgroundImage = global::NoteApp.View.Properties.Resources.delete_file_icon_icons_com_71692__1_;
            this.NoteAppButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton3.Location = new System.Drawing.Point(139, 517);
            this.NoteAppButton3.Name = "NoteAppButton3";
            this.NoteAppButton3.Size = new System.Drawing.Size(46, 48);
            this.NoteAppButton3.TabIndex = 5;
            this.NoteAppButton3.UseVisualStyleBackColor = true;
            this.NoteAppButton3.Click += new System.EventHandler(this.NoteAppButton3_Click);
            // 
            // NoteAppButton2
            // 
            this.NoteAppButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppButton2.BackgroundImage = global::NoteApp.View.Properties.Resources.file_document_edit_outline_icon_139608;
            this.NoteAppButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton2.Location = new System.Drawing.Point(75, 517);
            this.NoteAppButton2.Name = "NoteAppButton2";
            this.NoteAppButton2.Size = new System.Drawing.Size(46, 48);
            this.NoteAppButton2.TabIndex = 4;
            this.NoteAppButton2.UseVisualStyleBackColor = true;
            this.NoteAppButton2.Click += new System.EventHandler(this.NoteAppButton2_Click);
            // 
            // NoteAppButton1
            // 
            this.NoteAppButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteAppButton1.BackgroundImage = global::NoteApp.View.Properties.Resources.Add_File_icon_icons_com_55973;
            this.NoteAppButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoteAppButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteAppButton1.Location = new System.Drawing.Point(11, 517);
            this.NoteAppButton1.Name = "NoteAppButton1";
            this.NoteAppButton1.Size = new System.Drawing.Size(46, 48);
            this.NoteAppButton1.TabIndex = 3;
            this.NoteAppButton1.UseVisualStyleBackColor = true;
            this.NoteAppButton1.Click += new System.EventHandler(this.NoteAppButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 600);
            this.Controls.Add(this.NoteAppSplitContainer1);
            this.Controls.Add(this.NoteAppMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.NoteAppSplitContainer1.Panel1.ResumeLayout(false);
            this.NoteAppSplitContainer1.Panel1.PerformLayout();
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
    }
}

