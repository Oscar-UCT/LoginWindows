namespace LoginWindows
{
    partial class FormularioRegistro
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
            this.contraseñaInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioInput = new System.Windows.Forms.TextBox();
            this.ciudadInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonoInput = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.estadoRegistroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contraseñaInput
            // 
            this.contraseñaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaInput.Location = new System.Drawing.Point(332, 220);
            this.contraseñaInput.Name = "contraseñaInput";
            this.contraseñaInput.PasswordChar = '*';
            this.contraseñaInput.Size = new System.Drawing.Size(140, 26);
            this.contraseñaInput.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(207, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(207, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Romantic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(267, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registro";
            // 
            // usuarioInput
            // 
            this.usuarioInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioInput.Location = new System.Drawing.Point(332, 185);
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(140, 26);
            this.usuarioInput.TabIndex = 7;
            // 
            // ciudadInput
            // 
            this.ciudadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadInput.Location = new System.Drawing.Point(332, 252);
            this.ciudadInput.Name = "ciudadInput";
            this.ciudadInput.Size = new System.Drawing.Size(140, 26);
            this.ciudadInput.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(207, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ciudad";
            // 
            // telefonoInput
            // 
            this.telefonoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoInput.Location = new System.Drawing.Point(332, 284);
            this.telefonoInput.Name = "telefonoInput";
            this.telefonoInput.Size = new System.Drawing.Size(140, 26);
            this.telefonoInput.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(207, 281);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono";
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Font = new System.Drawing.Font("Romantic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ingresarBtn.Location = new System.Drawing.Point(386, 316);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(86, 30);
            this.ingresarBtn.TabIndex = 16;
            this.ingresarBtn.Text = "Guardar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // estadoRegistroLabel
            // 
            this.estadoRegistroLabel.AutoSize = true;
            this.estadoRegistroLabel.Font = new System.Drawing.Font("Romantic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.estadoRegistroLabel.Location = new System.Drawing.Point(12, 9);
            this.estadoRegistroLabel.Name = "estadoRegistroLabel";
            this.estadoRegistroLabel.Size = new System.Drawing.Size(0, 21);
            this.estadoRegistroLabel.TabIndex = 17;
            // 
            // FormularioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estadoRegistroLabel);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.telefonoInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ciudadInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contraseñaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioInput);
            this.Name = "FormularioRegistro";
            this.Text = "FormularioRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox contraseñaInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioInput;
        private System.Windows.Forms.MaskedTextBox ciudadInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox telefonoInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Label estadoRegistroLabel;
    }
}