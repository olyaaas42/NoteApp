
namespace NoteApp.View
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoteTextBox2 = new System.Windows.Forms.TextBox();
            this.TitleTextBox1 = new System.Windows.Forms.TextBox();
            this.CategoryComboBox1 = new System.Windows.Forms.ComboBox();
            this.ModifiedDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CreatedDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel4 = new System.Windows.Forms.Label();
            this.CreatedLabel3 = new System.Windows.Forms.Label();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.TitleLabel1 = new System.Windows.Forms.Label();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.OKButton1 = new System.Windows.Forms.Button();
            this.NoteAppSaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // NoteTextBox2
            // 
            this.NoteTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox2.Location = new System.Drawing.Point(11, 108);
            this.NoteTextBox2.Multiline = true;
            this.NoteTextBox2.Name = "NoteTextBox2";
            this.NoteTextBox2.Size = new System.Drawing.Size(806, 387);
            this.NoteTextBox2.TabIndex = 21;
            // 
            // TitleTextBox1
            // 
            this.TitleTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox1.Location = new System.Drawing.Point(88, 14);
            this.TitleTextBox1.MaxLength = 50;
            this.TitleTextBox1.Name = "TitleTextBox1";
            this.TitleTextBox1.Size = new System.Drawing.Size(729, 22);
            this.TitleTextBox1.TabIndex = 20;
            this.TitleTextBox1.Text = "БезНазвания";
            // 
            // CategoryComboBox1
            // 
            this.CategoryComboBox1.FormattingEnabled = true;
            this.CategoryComboBox1.Location = new System.Drawing.Point(88, 44);
            this.CategoryComboBox1.Name = "CategoryComboBox1";
            this.CategoryComboBox1.Size = new System.Drawing.Size(161, 24);
            this.CategoryComboBox1.TabIndex = 19;
            this.CategoryComboBox1.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox1_SelectedIndexChanged);
            // 
            // ModifiedDateTimePicker2
            // 
            this.ModifiedDateTimePicker2.Location = new System.Drawing.Point(328, 77);
            this.ModifiedDateTimePicker2.Name = "ModifiedDateTimePicker2";
            this.ModifiedDateTimePicker2.Size = new System.Drawing.Size(163, 22);
            this.ModifiedDateTimePicker2.TabIndex = 18;
            // 
            // CreatedDateTimePicker1
            // 
            this.CreatedDateTimePicker1.Location = new System.Drawing.Point(89, 77);
            this.CreatedDateTimePicker1.Name = "CreatedDateTimePicker1";
            this.CreatedDateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.CreatedDateTimePicker1.TabIndex = 17;
            // 
            // ModifiedLabel4
            // 
            this.ModifiedLabel4.AllowDrop = true;
            this.ModifiedLabel4.AutoSize = true;
            this.ModifiedLabel4.Location = new System.Drawing.Point(257, 80);
            this.ModifiedLabel4.Name = "ModifiedLabel4";
            this.ModifiedLabel4.Size = new System.Drawing.Size(65, 17);
            this.ModifiedLabel4.TabIndex = 16;
            this.ModifiedLabel4.Text = "Modified:";
            // 
            // CreatedLabel3
            // 
            this.CreatedLabel3.AutoSize = true;
            this.CreatedLabel3.Location = new System.Drawing.Point(14, 79);
            this.CreatedLabel3.Name = "CreatedLabel3";
            this.CreatedLabel3.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel3.TabIndex = 15;
            this.CreatedLabel3.Text = "Created:";
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(13, 47);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel2.TabIndex = 14;
            this.CategoryLabel2.Text = "Category:";
            // 
            // TitleLabel1
            // 
            this.TitleLabel1.AutoSize = true;
            this.TitleLabel1.Location = new System.Drawing.Point(13, 14);
            this.TitleLabel1.Name = "TitleLabel1";
            this.TitleLabel1.Size = new System.Drawing.Size(39, 17);
            this.TitleLabel1.TabIndex = 13;
            this.TitleLabel1.Text = "Title:";
            // 
            // CancelButton2
            // 
            this.CancelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton2.Location = new System.Drawing.Point(691, 501);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(127, 33);
            this.CancelButton2.TabIndex = 12;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.NoteAppButton2_Click);
            // 
            // OKButton1
            // 
            this.OKButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton1.Location = new System.Drawing.Point(558, 501);
            this.OKButton1.Name = "OKButton1";
            this.OKButton1.Size = new System.Drawing.Size(127, 33);
            this.OKButton1.TabIndex = 11;
            this.OKButton1.Text = "ОК";
            this.OKButton1.UseVisualStyleBackColor = true;
            this.OKButton1.Click += new System.EventHandler(this.NoteAppButton1_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 546);
            this.Controls.Add(this.NoteTextBox2);
            this.Controls.Add(this.TitleTextBox1);
            this.Controls.Add(this.CategoryComboBox1);
            this.Controls.Add(this.ModifiedDateTimePicker2);
            this.Controls.Add(this.CreatedDateTimePicker1);
            this.Controls.Add(this.ModifiedLabel4);
            this.Controls.Add(this.CreatedLabel3);
            this.Controls.Add(this.CategoryLabel2);
            this.Controls.Add(this.TitleLabel1);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.OKButton1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTextBox2;
        private System.Windows.Forms.TextBox TitleTextBox1;
        private System.Windows.Forms.ComboBox CategoryComboBox1;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker2;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker1;
        private System.Windows.Forms.Label ModifiedLabel4;
        private System.Windows.Forms.Label CreatedLabel3;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.Label TitleLabel1;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.Button OKButton1;
        private System.Windows.Forms.SaveFileDialog NoteAppSaveFileDialog1;
    }
}