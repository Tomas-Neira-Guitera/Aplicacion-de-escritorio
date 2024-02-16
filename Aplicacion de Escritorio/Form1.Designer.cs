namespace Aplicacion_de_Escritorio
{
    partial class VentanaPrincipal
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
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelApellidoBack = new System.Windows.Forms.Label();
            this.labelNombreBack = new System.Windows.Forms.Label();
            this.labelDireccionBack = new System.Windows.Forms.Label();
            this.labelEdadBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(14, 32);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(79, 17);
            this.lbApellido.TabIndex = 0;
            this.lbApellido.Text = "APELLIDO:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(14, 75);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(72, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "NOMBRE:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(14, 117);
            this.lbEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(50, 17);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "EDAD:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(14, 159);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(86, 17);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "DIRECCIÓN:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(14, 207);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(97, 17);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESULTADO:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(105, 29);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(333, 21);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(105, 72);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(333, 21);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(105, 117);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(82, 21);
            this.textBoxEdad.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(105, 156);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(333, 21);
            this.textBoxDireccion.TabIndex = 8;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResultado.Location = new System.Drawing.Point(14, 239);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(424, 141);
            this.textBoxResultado.TabIndex = 9;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAceptar.Location = new System.Drawing.Point(105, 411);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(107, 28);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(228, 411);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 28);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelApellidoBack
            // 
            this.labelApellidoBack.AutoSize = true;
            this.labelApellidoBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelApellidoBack.Location = new System.Drawing.Point(105, 27);
            this.labelApellidoBack.MinimumSize = new System.Drawing.Size(335, 22);
            this.labelApellidoBack.Name = "labelApellidoBack";
            this.labelApellidoBack.Size = new System.Drawing.Size(335, 22);
            this.labelApellidoBack.TabIndex = 12;
            this.labelApellidoBack.Text = "                   ";
            // 
            // labelNombreBack
            // 
            this.labelNombreBack.AutoSize = true;
            this.labelNombreBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelNombreBack.Location = new System.Drawing.Point(105, 70);
            this.labelNombreBack.MinimumSize = new System.Drawing.Size(335, 22);
            this.labelNombreBack.Name = "labelNombreBack";
            this.labelNombreBack.Size = new System.Drawing.Size(335, 22);
            this.labelNombreBack.TabIndex = 13;
            this.labelNombreBack.Text = "                   ";
            // 
            // labelDireccionBack
            // 
            this.labelDireccionBack.AutoSize = true;
            this.labelDireccionBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelDireccionBack.Location = new System.Drawing.Point(105, 154);
            this.labelDireccionBack.MinimumSize = new System.Drawing.Size(335, 22);
            this.labelDireccionBack.Name = "labelDireccionBack";
            this.labelDireccionBack.Size = new System.Drawing.Size(335, 22);
            this.labelDireccionBack.TabIndex = 14;
            this.labelDireccionBack.Text = "                   ";
            // 
            // labelEdadBack
            // 
            this.labelEdadBack.AutoSize = true;
            this.labelEdadBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelEdadBack.Location = new System.Drawing.Point(105, 115);
            this.labelEdadBack.MinimumSize = new System.Drawing.Size(84, 22);
            this.labelEdadBack.Name = "labelEdadBack";
            this.labelEdadBack.Size = new System.Drawing.Size(84, 22);
            this.labelEdadBack.TabIndex = 15;
            this.labelEdadBack.Text = "                   ";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 463);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.labelApellidoBack);
            this.Controls.Add(this.labelNombreBack);
            this.Controls.Add(this.labelDireccionBack);
            this.Controls.Add(this.labelEdadBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(480, 502);
            this.MinimumSize = new System.Drawing.Size(480, 502);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelApellidoBack;
        private System.Windows.Forms.Label labelNombreBack;
        private System.Windows.Forms.Label labelDireccionBack;
        private System.Windows.Forms.Label labelEdadBack;
    }
}

