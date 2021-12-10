
namespace BlocDeNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAdministrador = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelComprobacionConexion = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(104, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(254, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Bloc de Notas";
            // 
            // buttonAdministrador
            // 
            this.buttonAdministrador.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdministrador.Location = new System.Drawing.Point(138, 342);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(187, 52);
            this.buttonAdministrador.TabIndex = 4;
            this.buttonAdministrador.Text = "ADMINISTRADOR";
            this.buttonAdministrador.UseVisualStyleBackColor = false;
            this.buttonAdministrador.Click += new System.EventHandler(this.buttonAdministrador_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Location = new System.Drawing.Point(138, 225);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(187, 52);
            this.buttonSignUp.TabIndex = 2;
            this.buttonSignUp.Text = "REGISTRAR ESCRITOR";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelComprobacionConexion
            // 
            this.labelComprobacionConexion.AutoSize = true;
            this.labelComprobacionConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComprobacionConexion.Location = new System.Drawing.Point(186, 444);
            this.labelComprobacionConexion.Name = "labelComprobacionConexion";
            this.labelComprobacionConexion.Size = new System.Drawing.Size(0, 13);
            this.labelComprobacionConexion.TabIndex = 3;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Location = new System.Drawing.Point(138, 109);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(187, 52);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "INGRESAR ESCRITOR";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 481);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelComprobacionConexion);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonAdministrador);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloc de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelComprobacionConexion;
        private System.Windows.Forms.Button buttonSignIn;
    }
}

