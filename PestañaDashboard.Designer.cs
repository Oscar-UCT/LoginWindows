namespace LoginWindows
{
    partial class PestañaDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioDashboard = new System.Windows.Forms.Label();
            this.direccionUsuarioLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonoUsuarioLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // usuarioDashboard
            // 
            this.usuarioDashboard.AutoSize = true;
            this.usuarioDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioDashboard.Location = new System.Drawing.Point(134, 90);
            this.usuarioDashboard.Name = "usuarioDashboard";
            this.usuarioDashboard.Size = new System.Drawing.Size(23, 31);
            this.usuarioDashboard.TabIndex = 2;
            this.usuarioDashboard.Text = "-";
            // 
            // direccionUsuarioLabel
            // 
            this.direccionUsuarioLabel.AutoSize = true;
            this.direccionUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionUsuarioLabel.Location = new System.Drawing.Point(149, 134);
            this.direccionUsuarioLabel.Name = "direccionUsuarioLabel";
            this.direccionUsuarioLabel.Size = new System.Drawing.Size(23, 31);
            this.direccionUsuarioLabel.TabIndex = 4;
            this.direccionUsuarioLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Direccion:";
            // 
            // telefonoUsuarioLabel
            // 
            this.telefonoUsuarioLabel.AutoSize = true;
            this.telefonoUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoUsuarioLabel.Location = new System.Drawing.Point(149, 180);
            this.telefonoUsuarioLabel.Name = "telefonoUsuarioLabel";
            this.telefonoUsuarioLabel.Size = new System.Drawing.Size(23, 31);
            this.telefonoUsuarioLabel.TabIndex = 6;
            this.telefonoUsuarioLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono:";
            // 
            // PestañaDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telefonoUsuarioLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.direccionUsuarioLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuarioDashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PestañaDashboard";
            this.Text = "PestañaDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usuarioDashboard;
        private System.Windows.Forms.Label direccionUsuarioLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label telefonoUsuarioLabel;
        private System.Windows.Forms.Label label4;
    }
}