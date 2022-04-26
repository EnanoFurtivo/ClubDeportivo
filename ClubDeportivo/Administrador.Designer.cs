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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxActividades = new System.Windows.Forms.GroupBox();
            this.listBoxActividadesSocio = new System.Windows.Forms.ListBox();
            this.groupBoxModificarUsuario = new System.Windows.Forms.GroupBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxModificarActividad = new System.Windows.Forms.GroupBox();
            this.buttonEliminarActividadLista = new System.Windows.Forms.Button();
            this.buttonAgregarActividad = new System.Windows.Forms.Button();
            this.buttonModificarActividad = new System.Windows.Forms.Button();
            this.groupBoxAsignarActividad = new System.Windows.Forms.GroupBox();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.comboBoxAsignarActividad = new System.Windows.Forms.ComboBox();
            this.buttonAsignarActividad = new System.Windows.Forms.Button();
            this.groupBoxRegistrarPago = new System.Windows.Forms.GroupBox();
            this.buttonRegistrarPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonGenerarDeuda = new System.Windows.Forms.ToolStripButton();
            this.groupBoxActividades.SuspendLayout();
            this.groupBoxModificarUsuario.SuspendLayout();
            this.groupBoxModificarActividad.SuspendLayout();
            this.groupBoxAsignarActividad.SuspendLayout();
            this.groupBoxRegistrarPago.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Location = new System.Drawing.Point(18, 35);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(195, 24);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido de nuevo,";
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.ForeColor = System.Drawing.Color.Transparent;
            this.labelLista.Location = new System.Drawing.Point(6, 17);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(47, 13);
            this.labelLista.TabIndex = 2;
            this.labelLista.Text = "Lista de ";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(24, 38);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(108, 23);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar x";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(24, 67);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(108, 23);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar x";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(176, 264);
            this.listBox.TabIndex = 6;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // groupBoxActividades
            // 
            this.groupBoxActividades.Controls.Add(this.listBoxActividadesSocio);
            this.groupBoxActividades.Controls.Add(this.listBox);
            this.groupBoxActividades.Controls.Add(this.labelLista);
            this.groupBoxActividades.Location = new System.Drawing.Point(16, 62);
            this.groupBoxActividades.Name = "groupBoxActividades";
            this.groupBoxActividades.Size = new System.Drawing.Size(350, 305);
            this.groupBoxActividades.TabIndex = 8;
            this.groupBoxActividades.TabStop = false;
            // 
            // listBoxActividadesSocio
            // 
            this.listBoxActividadesSocio.FormattingEnabled = true;
            this.listBoxActividadesSocio.Location = new System.Drawing.Point(196, 124);
            this.listBoxActividadesSocio.Name = "listBoxActividadesSocio";
            this.listBoxActividadesSocio.Size = new System.Drawing.Size(139, 173);
            this.listBoxActividadesSocio.TabIndex = 13;
            this.listBoxActividadesSocio.SelectedIndexChanged += new System.EventHandler(this.listBoxActividadesSocio_SelectedIndexChanged);
            // 
            // groupBoxModificarUsuario
            // 
            this.groupBoxModificarUsuario.Controls.Add(this.buttonAgregar);
            this.groupBoxModificarUsuario.Controls.Add(this.buttonModificar);
            this.groupBoxModificarUsuario.Controls.Add(this.buttonEliminar);
            this.groupBoxModificarUsuario.Location = new System.Drawing.Point(372, 41);
            this.groupBoxModificarUsuario.Name = "groupBoxModificarUsuario";
            this.groupBoxModificarUsuario.Size = new System.Drawing.Size(148, 96);
            this.groupBoxModificarUsuario.TabIndex = 11;
            this.groupBoxModificarUsuario.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(24, 9);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(108, 23);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar x";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBoxModificarActividad
            // 
            this.groupBoxModificarActividad.Controls.Add(this.buttonEliminarActividadLista);
            this.groupBoxModificarActividad.Controls.Add(this.buttonAgregarActividad);
            this.groupBoxModificarActividad.Controls.Add(this.buttonModificarActividad);
            this.groupBoxModificarActividad.Location = new System.Drawing.Point(372, 143);
            this.groupBoxModificarActividad.Name = "groupBoxModificarActividad";
            this.groupBoxModificarActividad.Size = new System.Drawing.Size(148, 91);
            this.groupBoxModificarActividad.TabIndex = 10;
            this.groupBoxModificarActividad.TabStop = false;
            // 
            // buttonEliminarActividadLista
            // 
            this.buttonEliminarActividadLista.Location = new System.Drawing.Point(24, 65);
            this.buttonEliminarActividadLista.Name = "buttonEliminarActividadLista";
            this.buttonEliminarActividadLista.Size = new System.Drawing.Size(108, 23);
            this.buttonEliminarActividadLista.TabIndex = 14;
            this.buttonEliminarActividadLista.Text = "Eliminar Actividad";
            this.buttonEliminarActividadLista.UseVisualStyleBackColor = true;
            this.buttonEliminarActividadLista.Click += new System.EventHandler(this.buttonEliminarActividadLista_Click);
            // 
            // buttonAgregarActividad
            // 
            this.buttonAgregarActividad.Location = new System.Drawing.Point(24, 7);
            this.buttonAgregarActividad.Name = "buttonAgregarActividad";
            this.buttonAgregarActividad.Size = new System.Drawing.Size(108, 23);
            this.buttonAgregarActividad.TabIndex = 10;
            this.buttonAgregarActividad.Text = "Agregar Actividad";
            this.buttonAgregarActividad.UseVisualStyleBackColor = true;
            this.buttonAgregarActividad.Click += new System.EventHandler(this.buttonAgregarActividad_Click);
            // 
            // buttonModificarActividad
            // 
            this.buttonModificarActividad.Location = new System.Drawing.Point(24, 36);
            this.buttonModificarActividad.Name = "buttonModificarActividad";
            this.buttonModificarActividad.Size = new System.Drawing.Size(108, 23);
            this.buttonModificarActividad.TabIndex = 12;
            this.buttonModificarActividad.Text = "Modificar Actividad";
            this.buttonModificarActividad.UseVisualStyleBackColor = true;
            this.buttonModificarActividad.Click += new System.EventHandler(this.buttonModificarActividad_Click);
            // 
            // groupBoxAsignarActividad
            // 
            this.groupBoxAsignarActividad.Controls.Add(this.buttonEliminarActividad);
            this.groupBoxAsignarActividad.Controls.Add(this.comboBoxAsignarActividad);
            this.groupBoxAsignarActividad.Controls.Add(this.buttonAsignarActividad);
            this.groupBoxAsignarActividad.Location = new System.Drawing.Point(369, 342);
            this.groupBoxAsignarActividad.Name = "groupBoxAsignarActividad";
            this.groupBoxAsignarActividad.Size = new System.Drawing.Size(157, 78);
            this.groupBoxAsignarActividad.TabIndex = 11;
            this.groupBoxAsignarActividad.TabStop = false;
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.Location = new System.Drawing.Point(84, 46);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(64, 23);
            this.buttonEliminarActividad.TabIndex = 10;
            this.buttonEliminarActividad.Text = "Eliminar";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            this.buttonEliminarActividad.Click += new System.EventHandler(this.buttonEliminarActividad_Click);
            // 
            // comboBoxAsignarActividad
            // 
            this.comboBoxAsignarActividad.FormattingEnabled = true;
            this.comboBoxAsignarActividad.Location = new System.Drawing.Point(9, 18);
            this.comboBoxAsignarActividad.Name = "comboBoxAsignarActividad";
            this.comboBoxAsignarActividad.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAsignarActividad.TabIndex = 8;
            // 
            // buttonAsignarActividad
            // 
            this.buttonAsignarActividad.Location = new System.Drawing.Point(9, 45);
            this.buttonAsignarActividad.Name = "buttonAsignarActividad";
            this.buttonAsignarActividad.Size = new System.Drawing.Size(65, 23);
            this.buttonAsignarActividad.TabIndex = 7;
            this.buttonAsignarActividad.Text = "Asignar";
            this.buttonAsignarActividad.UseVisualStyleBackColor = true;
            this.buttonAsignarActividad.Click += new System.EventHandler(this.buttonAsignarActividad_Click);
            // 
            // groupBoxRegistrarPago
            // 
            this.groupBoxRegistrarPago.Controls.Add(this.buttonRegistrarPago);
            this.groupBoxRegistrarPago.Controls.Add(this.label2);
            this.groupBoxRegistrarPago.Controls.Add(this.textBoxMonto);
            this.groupBoxRegistrarPago.Location = new System.Drawing.Point(372, 249);
            this.groupBoxRegistrarPago.Name = "groupBoxRegistrarPago";
            this.groupBoxRegistrarPago.Size = new System.Drawing.Size(154, 78);
            this.groupBoxRegistrarPago.TabIndex = 10;
            this.groupBoxRegistrarPago.TabStop = false;
            // 
            // buttonRegistrarPago
            // 
            this.buttonRegistrarPago.Location = new System.Drawing.Point(9, 45);
            this.buttonRegistrarPago.Name = "buttonRegistrarPago";
            this.buttonRegistrarPago.Size = new System.Drawing.Size(140, 23);
            this.buttonRegistrarPago.TabIndex = 7;
            this.buttonRegistrarPago.Text = "Registrar pago";
            this.buttonRegistrarPago.UseVisualStyleBackColor = true;
            this.buttonRegistrarPago.Click += new System.EventHandler(this.buttonRegistrarPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(49, 19);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(99, 20);
            this.textBoxMonto.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripButtonGenerarDeuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Accion: ";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Modificar actividades",
            "Modificar profesores",
            "Modificar socios del club",
            "Modificar socios de actividades",
            "Registrar pago",
            "Asignar actividad"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripButtonGenerarDeuda
            // 
            this.toolStripButtonGenerarDeuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGenerarDeuda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerarDeuda.Image")));
            this.toolStripButtonGenerarDeuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerarDeuda.Name = "toolStripButtonGenerarDeuda";
            this.toolStripButtonGenerarDeuda.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonGenerarDeuda.Text = "GenerarDeuda";
            this.toolStripButtonGenerarDeuda.Click += new System.EventHandler(this.toolStripButtonGenerarDeuda_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(657, 520);
            this.Controls.Add(this.groupBoxModificarUsuario);
            this.Controls.Add(this.groupBoxAsignarActividad);
            this.Controls.Add(this.groupBoxModificarActividad);
            this.Controls.Add(this.groupBoxRegistrarPago);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.groupBoxActividades);
            this.Name = "FormAdministrador";
            this.Text = "Administrador";
            this.groupBoxActividades.ResumeLayout(false);
            this.groupBoxActividades.PerformLayout();
            this.groupBoxModificarUsuario.ResumeLayout(false);
            this.groupBoxModificarActividad.ResumeLayout(false);
            this.groupBoxAsignarActividad.ResumeLayout(false);
            this.groupBoxRegistrarPago.ResumeLayout(false);
            this.groupBoxRegistrarPago.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBoxActividades;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.GroupBox groupBoxRegistrarPago;
        private System.Windows.Forms.Button buttonRegistrarPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.GroupBox groupBoxAsignarActividad;
        private System.Windows.Forms.ComboBox comboBoxAsignarActividad;
        private System.Windows.Forms.Button buttonAsignarActividad;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonAgregarActividad;
        private System.Windows.Forms.Button buttonModificarActividad;
        private System.Windows.Forms.ListBox listBoxActividadesSocio;
        private System.Windows.Forms.Button buttonEliminarActividad;
        private System.Windows.Forms.Button buttonEliminarActividadLista;
        private System.Windows.Forms.GroupBox groupBoxModificarUsuario;
        private System.Windows.Forms.GroupBox groupBoxModificarActividad;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerarDeuda;
    }
}