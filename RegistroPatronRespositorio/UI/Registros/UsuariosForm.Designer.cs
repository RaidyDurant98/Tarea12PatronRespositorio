namespace RegistroPatronRespositorio.UI.Registros
{
    partial class UsuariosForm
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
            System.Windows.Forms.Label usuarioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label claveLabel;
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            usuarioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuarioIdLabel
            // 
            usuarioIdLabel.AutoSize = true;
            usuarioIdLabel.Location = new System.Drawing.Point(12, 40);
            usuarioIdLabel.Name = "usuarioIdLabel";
            usuarioIdLabel.Size = new System.Drawing.Size(58, 13);
            usuarioIdLabel.TabIndex = 1;
            usuarioIdLabel.Text = "Usuario Id:";
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.Location = new System.Drawing.Point(76, 37);
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(133, 20);
            this.usuarioIdTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 66);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(76, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(242, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(12, 92);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 5;
            claveLabel.Text = "Clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(76, 89);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(242, 20);
            this.claveTextBox.TabIndex = 6;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(244, 34);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 169);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(134, 169);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(244, 169);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 215);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(usuarioIdLabel);
            this.Controls.Add(this.usuarioIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}