namespace ClubDeportivo
{
    partial class FormAdministrador
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
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelListaActividades = new System.Windows.Forms.Label();
            this.buttonAgregarActividad = new System.Windows.Forms.Button();
            this.buttonModificarActividad = new System.Windows.Forms.Button();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.buttonRefrescarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Location = new System.Drawing.Point(254, 25);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(195, 24);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido de nuevo,";
            // 
            // labelListaActividades
            // 
            this.labelListaActividades.AutoSize = true;
            this.labelListaActividades.ForeColor = System.Drawing.Color.Transparent;
            this.labelListaActividades.Location = new System.Drawing.Point(61, 86);
            this.labelListaActividades.Name = "labelListaActividades";
            this.labelListaActividades.Size = new System.Drawing.Size(102, 13);
            this.labelListaActividades.TabIndex = 2;
            this.labelListaActividades.Text = "Lista de Actividades";
            // 
            // buttonAgregarActividad
            // 
            this.buttonAgregarActividad.Location = new System.Drawing.Point(343, 211);
            this.buttonAgregarActividad.Name = "buttonAgregarActividad";
            this.buttonAgregarActividad.Size = new System.Drawing.Size(106, 23);
            this.buttonAgregarActividad.TabIndex = 3;
            this.buttonAgregarActividad.Text = "Agregar Actividad";
            this.buttonAgregarActividad.UseVisualStyleBackColor = true;
            this.buttonAgregarActividad.Click += new System.EventHandler(this.buttonAgregarActividad_Click);
            // 
            // buttonModificarActividad
            // 
            this.buttonModificarActividad.Location = new System.Drawing.Point(343, 281);
            this.buttonModificarActividad.Name = "buttonModificarActividad";
            this.buttonModificarActividad.Size = new System.Drawing.Size(106, 23);
            this.buttonModificarActividad.TabIndex = 4;
            this.buttonModificarActividad.Text = "Modificar Actividad";
            this.buttonModificarActividad.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.Location = new System.Drawing.Point(343, 356);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(106, 23);
            this.buttonEliminarActividad.TabIndex = 5;
            this.buttonEliminarActividad.Text = "Eliminar Actividad";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(64, 115);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(176, 264);
            this.listBoxActividades.TabIndex = 6;
            // 
            // buttonRefrescarLista
            // 
            this.buttonRefrescarLista.Location = new System.Drawing.Point(64, 397);
            this.buttonRefrescarLista.Name = "buttonRefrescarLista";
            this.buttonRefrescarLista.Size = new System.Drawing.Size(99, 23);
            this.buttonRefrescarLista.TabIndex = 7;
            this.buttonRefrescarLista.Text = "Refrescar lista";
            this.buttonRefrescarLista.UseVisualStyleBackColor = true;
            this.buttonRefrescarLista.Click += new System.EventHandler(this.buttonRefrescarLista_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefrescarLista);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.buttonEliminarActividad);
            this.Controls.Add(this.buttonModificarActividad);
            this.Controls.Add(this.buttonAgregarActividad);
            this.Controls.Add(this.labelListaActividades);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "FormAdministrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelListaActividades;
        private System.Windows.Forms.Button buttonAgregarActividad;
        private System.Windows.Forms.Button buttonModificarActividad;
        private System.Windows.Forms.Button buttonEliminarActividad;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Button buttonRefrescarLista;
    }
}