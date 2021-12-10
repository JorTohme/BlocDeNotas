
namespace BlocDeNotas.Vista
{
    partial class FormNoteWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoteWriter));
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.textNewTitle = new System.Windows.Forms.TextBox();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.pictureSaveImage = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelLastChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSaveImage)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNota.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNota.Location = new System.Drawing.Point(270, 40);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(444, 478);
            this.richTextBoxNota.TabIndex = 0;
            this.richTextBoxNota.Text = "";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 18;
            this.listBoxNotes.Location = new System.Drawing.Point(25, 82);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(175, 432);
            this.listBoxNotes.TabIndex = 1;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(270, 524);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(177, 33);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "         GUARDAR CAMBIOS";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewNote.Enabled = false;
            this.buttonNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewNote.ForeColor = System.Drawing.Color.Black;
            this.buttonNewNote.Location = new System.Drawing.Point(25, 40);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(175, 36);
            this.buttonNewNote.TabIndex = 3;
            this.buttonNewNote.Text = "NUEVA NOTA";
            this.buttonNewNote.UseVisualStyleBackColor = false;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // textNewTitle
            // 
            this.textNewTitle.Enabled = false;
            this.textNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewTitle.Location = new System.Drawing.Point(25, 12);
            this.textNewTitle.MaxLength = 24;
            this.textNewTitle.Name = "textNewTitle";
            this.textNewTitle.Size = new System.Drawing.Size(175, 22);
            this.textNewTitle.TabIndex = 4;
            this.textNewTitle.Text = "Añadir Título";
            this.textNewTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNewTitle.Click += new System.EventHandler(this.textNewTitle_Click);
            this.textNewTitle.TextChanged += new System.EventHandler(this.textNewTitle_TextChanged);
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteNote.BackgroundImage")));
            this.buttonDeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNote.Location = new System.Drawing.Point(683, 524);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(31, 33);
            this.buttonDeleteNote.TabIndex = 5;
            this.buttonDeleteNote.UseVisualStyleBackColor = false;
            this.buttonDeleteNote.Click += new System.EventHandler(this.buttonDeleteNote_Click);
            // 
            // pictureSaveImage
            // 
            this.pictureSaveImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureSaveImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSaveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSaveImage.Image = global::BlocDeNotas.Properties.Resources.floppy_disk;
            this.pictureSaveImage.InitialImage = null;
            this.pictureSaveImage.Location = new System.Drawing.Point(283, 528);
            this.pictureSaveImage.Name = "pictureSaveImage";
            this.pictureSaveImage.Size = new System.Drawing.Size(25, 25);
            this.pictureSaveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSaveImage.TabIndex = 6;
            this.pictureSaveImage.TabStop = false;
            this.pictureSaveImage.Click += new System.EventHandler(this.pictureSaveImage_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(270, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 21);
            this.labelTitle.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(528, 14);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(0, 19);
            this.labelAuthor.TabIndex = 8;
            // 
            // labelLastChange
            // 
            this.labelLastChange.AutoSize = true;
            this.labelLastChange.BackColor = System.Drawing.SystemColors.Control;
            this.labelLastChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastChange.Location = new System.Drawing.Point(540, 502);
            this.labelLastChange.Name = "labelLastChange";
            this.labelLastChange.Size = new System.Drawing.Size(44, 16);
            this.labelLastChange.TabIndex = 9;
            this.labelLastChange.Text = "Ult M: ";
            // 
            // FormNoteWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 597);
            this.Controls.Add(this.labelLastChange);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureSaveImage);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.textNewTitle);
            this.Controls.Add(this.buttonNewNote);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.richTextBoxNota);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNoteWriter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNoteWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSaveImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.TextBox textNewTitle;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.PictureBox pictureSaveImage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelLastChange;
    }
}