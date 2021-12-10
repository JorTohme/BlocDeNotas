
namespace BlocDeNotas.Vista
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.groupUserData = new System.Windows.Forms.GroupBox();
            this.labelReinsertPassword = new System.Windows.Forms.Label();
            this.labelRePassword = new System.Windows.Forms.Label();
            this.textRePassword = new System.Windows.Forms.TextBox();
            this.labelShortPassword = new System.Windows.Forms.Label();
            this.labelTextName = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.groupUserAlreadyExists = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelUserAlreadyExists = new System.Windows.Forms.Label();
            this.groupUserData.SuspendLayout();
            this.groupUserAlreadyExists.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(15, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(220, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ingrese su nombre de usuario";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(7, 126);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(162, 18);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Ingrese una contraseña";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(54, 43);
            this.textName.MaxLength = 25;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(136, 22);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(175, 126);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(98, 24);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // groupUserData
            // 
            this.groupUserData.BackColor = System.Drawing.SystemColors.Control;
            this.groupUserData.Controls.Add(this.labelReinsertPassword);
            this.groupUserData.Controls.Add(this.labelRePassword);
            this.groupUserData.Controls.Add(this.textRePassword);
            this.groupUserData.Controls.Add(this.labelShortPassword);
            this.groupUserData.Controls.Add(this.labelTextName);
            this.groupUserData.Controls.Add(this.labelPassword);
            this.groupUserData.Controls.Add(this.textName);
            this.groupUserData.Controls.Add(this.textPassword);
            this.groupUserData.Controls.Add(this.labelName);
            this.groupUserData.ForeColor = System.Drawing.Color.Transparent;
            this.groupUserData.Location = new System.Drawing.Point(12, 12);
            this.groupUserData.Name = "groupUserData";
            this.groupUserData.Size = new System.Drawing.Size(279, 234);
            this.groupUserData.TabIndex = 4;
            this.groupUserData.TabStop = false;
            // 
            // labelReinsertPassword
            // 
            this.labelReinsertPassword.AutoSize = true;
            this.labelReinsertPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReinsertPassword.ForeColor = System.Drawing.Color.Black;
            this.labelReinsertPassword.Location = new System.Drawing.Point(7, 175);
            this.labelReinsertPassword.Name = "labelReinsertPassword";
            this.labelReinsertPassword.Size = new System.Drawing.Size(153, 18);
            this.labelReinsertPassword.TabIndex = 8;
            this.labelReinsertPassword.Text = "Reingrese contraseña";
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRePassword.ForeColor = System.Drawing.Color.Red;
            this.labelRePassword.Location = new System.Drawing.Point(16, 208);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(177, 13);
            this.labelRePassword.TabIndex = 7;
            this.labelRePassword.Text = "Las contraseñas no coinciden";
            this.labelRePassword.Visible = false;
            // 
            // textRePassword
            // 
            this.textRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRePassword.Location = new System.Drawing.Point(175, 175);
            this.textRePassword.Name = "textRePassword";
            this.textRePassword.PasswordChar = '*';
            this.textRePassword.Size = new System.Drawing.Size(98, 24);
            this.textRePassword.TabIndex = 6;
            this.textRePassword.TextChanged += new System.EventHandler(this.textRePassword_TextChanged);
            // 
            // labelShortPassword
            // 
            this.labelShortPassword.AutoSize = true;
            this.labelShortPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortPassword.ForeColor = System.Drawing.Color.Red;
            this.labelShortPassword.Location = new System.Drawing.Point(16, 154);
            this.labelShortPassword.Name = "labelShortPassword";
            this.labelShortPassword.Size = new System.Drawing.Size(130, 13);
            this.labelShortPassword.TabIndex = 5;
            this.labelShortPassword.Text = "Contraseña muy corta";
            this.labelShortPassword.Visible = false;
            // 
            // labelTextName
            // 
            this.labelTextName.AutoSize = true;
            this.labelTextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextName.ForeColor = System.Drawing.Color.Red;
            this.labelTextName.Location = new System.Drawing.Point(62, 66);
            this.labelTextName.Name = "labelTextName";
            this.labelTextName.Size = new System.Drawing.Size(128, 13);
            this.labelTextName.TabIndex = 4;
            this.labelTextName.Text = "Ya existe ese usuario";
            this.labelTextName.Visible = false;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateUser.Enabled = false;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.Location = new System.Drawing.Point(332, 20);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(163, 55);
            this.buttonCreateUser.TabIndex = 5;
            this.buttonCreateUser.Text = "CREAR \r\nUSUARIO";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // groupUserAlreadyExists
            // 
            this.groupUserAlreadyExists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupUserAlreadyExists.Controls.Add(this.buttonExit);
            this.groupUserAlreadyExists.Controls.Add(this.labelUserAlreadyExists);
            this.groupUserAlreadyExists.ForeColor = System.Drawing.Color.Transparent;
            this.groupUserAlreadyExists.Location = new System.Drawing.Point(317, 137);
            this.groupUserAlreadyExists.Name = "groupUserAlreadyExists";
            this.groupUserAlreadyExists.Size = new System.Drawing.Size(200, 86);
            this.groupUserAlreadyExists.TabIndex = 6;
            this.groupUserAlreadyExists.TabStop = false;
            this.groupUserAlreadyExists.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(64, 57);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelUserAlreadyExists
            // 
            this.labelUserAlreadyExists.AutoSize = true;
            this.labelUserAlreadyExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserAlreadyExists.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelUserAlreadyExists.Location = new System.Drawing.Point(33, 16);
            this.labelUserAlreadyExists.Name = "labelUserAlreadyExists";
            this.labelUserAlreadyExists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUserAlreadyExists.Size = new System.Drawing.Size(135, 26);
            this.labelUserAlreadyExists.TabIndex = 5;
            this.labelUserAlreadyExists.Text = "Si ya tiene una cuenta\r\n   debe iniciar sesión\r\n";
            // 
            // FormSignUp
            // 
            this.AcceptButton = this.buttonCreateUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(547, 269);
            this.Controls.Add(this.groupUserAlreadyExists);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.groupUserData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignUp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.groupUserData.ResumeLayout(false);
            this.groupUserData.PerformLayout();
            this.groupUserAlreadyExists.ResumeLayout(false);
            this.groupUserAlreadyExists.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.GroupBox groupUserData;
        private System.Windows.Forms.Label labelTextName;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.GroupBox groupUserAlreadyExists;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelUserAlreadyExists;
        private System.Windows.Forms.Label labelShortPassword;
        private System.Windows.Forms.Label labelRePassword;
        private System.Windows.Forms.TextBox textRePassword;
        private System.Windows.Forms.Label labelReinsertPassword;
    }
}