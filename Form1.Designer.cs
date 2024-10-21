namespace LoginWindows
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
            this.usuarioInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.contraseñaInput = new System.Windows.Forms.MaskedTextBox();
            this.estadoVerifiacionLabel = new System.Windows.Forms.Label();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioInput
            // 
            this.usuarioInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioInput.Location = new System.Drawing.Point(335, 226);
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(140, 26);
            this.usuarioInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Romantic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(301, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(210, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(210, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Font = new System.Drawing.Font("Romantic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ingresarBtn.Location = new System.Drawing.Point(389, 290);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(86, 30);
            this.ingresarBtn.TabIndex = 5;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // contraseñaInput
            // 
            this.contraseñaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaInput.Location = new System.Drawing.Point(335, 261);
            this.contraseñaInput.Name = "contraseñaInput";
            this.contraseñaInput.PasswordChar = '*';
            this.contraseñaInput.Size = new System.Drawing.Size(140, 26);
            this.contraseñaInput.TabIndex = 6;
            // 
            // estadoVerifiacionLabel
            // 
            this.estadoVerifiacionLabel.AutoSize = true;
            this.estadoVerifiacionLabel.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.estadoVerifiacionLabel.Location = new System.Drawing.Point(12, 9);
            this.estadoVerifiacionLabel.Name = "estadoVerifiacionLabel";
            this.estadoVerifiacionLabel.Size = new System.Drawing.Size(0, 18);
            this.estadoVerifiacionLabel.TabIndex = 7;
            // 
            // registrarBtn
            // 
            this.registrarBtn.Font = new System.Drawing.Font("Romantic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.registrarBtn.Location = new System.Drawing.Point(297, 290);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(86, 30);
            this.registrarBtn.TabIndex = 8;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = true;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.estadoVerifiacionLabel);
            this.Controls.Add(this.contraseñaInput);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.MaskedTextBox contraseñaInput;
        private System.Windows.Forms.Label estadoVerifiacionLabel;
        private System.Windows.Forms.Button registrarBtn;
    }
}

