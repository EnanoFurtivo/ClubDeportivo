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
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBoxActividades = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.groupBoxRegistrarPago = new System.Windows.Forms.GroupBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarPago = new System.Windows.Forms.Button();
            this.groupBoxAsignarActividad = new System.Windows.Forms.GroupBox();
            this.buttonAsignarActividad = new System.Windows.Forms.Button();
            this.comboBoxAsignarActividad = new System.Windows.Forms.ComboBox();
            this.groupBoxActividades.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxRegistrarPago.SuspendLayout();
            this.groupBoxAsignarActividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Location = new System.Drawing.Point(12, 21);
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
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(188, 33);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(154, 23);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar x";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(188, 62);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(154, 23);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar x";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(188, 91);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(154, 23);
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
            // 
            // groupBoxActividades
            // 
            this.groupBoxActividades.Controls.Add(this.groupBoxAsignarActividad);
            this.groupBoxActividades.Controls.Add(this.groupBoxRegistrarPago);
            this.groupBoxActividades.Controls.Add(this.listBox);
            this.groupBoxActividades.Controls.Add(this.labelLista);
            this.groupBoxActividades.Controls.Add(this.buttonEliminar);
            this.groupBoxActividades.Controls.Add(this.buttonAgregar);
            this.groupBoxActividades.Controls.Add(this.buttonModificar);
            this.groupBoxActividades.Location = new System.Drawing.Point(16, 62);
            this.groupBoxActividades.Name = "groupBoxActividades";
            this.groupBoxActividades.Size = new System.Drawing.Size(350, 305);
            this.groupBoxActividades.TabIndex = 8;
            this.groupBoxActividades.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // groupBoxRegistrarPago
            // 
            this.groupBoxRegistrarPago.Controls.Add(this.buttonRegistrarPago);
            this.groupBoxRegistrarPago.Controls.Add(this.label2);
            this.groupBoxRegistrarPago.Controls.Add(this.textBoxMonto);
            this.groupBoxRegistrarPago.Location = new System.Drawing.Point(188, 33);
            this.groupBoxRegistrarPago.Name = "groupBoxRegistrarPago";
            this.groupBoxRegistrarPago.Size = new System.Drawing.Size(154, 78);
            this.groupBoxRegistrarPago.TabIndex = 10;
            this.groupBoxRegistrarPago.TabStop = false;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(49, 19);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(99, 20);
            this.textBoxMonto.TabIndex = 0;
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
            // groupBoxAsignarActividad
            // 
            this.groupBoxAsignarActividad.Controls.Add(this.comboBoxAsignarActividad);
            this.groupBoxAsignarActividad.Controls.Add(this.buttonAsignarActividad);
            this.groupBoxAsignarActividad.Location = new System.Drawing.Point(187, 36);
            this.groupBoxAsignarActividad.Name = "groupBoxAsignarActividad";
            this.groupBoxAsignarActividad.Size = new System.Drawing.Size(157, 78);
            this.groupBoxAsignarActividad.TabIndex = 11;
            this.groupBoxAsignarActividad.TabStop = false;
            // 
            // buttonAsignarActividad
            // 
            this.buttonAsignarActividad.Location = new System.Drawing.Point(9, 45);
            this.buttonAsignarActividad.Name = "buttonAsignarActividad";
            this.buttonAsignarActividad.Size = new System.Drawing.Size(140, 23);
            this.buttonAsignarActividad.TabIndex = 7;
            this.buttonAsignarActividad.Text = "Asignar actividad";
            this.buttonAsignarActividad.UseVisualStyleBackColor = true;
            this.buttonAsignarActividad.Click += new System.EventHandler(this.buttonAsignarActividad_Click);
            // 
            // comboBoxAsignarActividad
            // 
            this.comboBoxAsignarActividad.FormattingEnabled = true;
            this.comboBoxAsignarActividad.Location = new System.Drawing.Point(9, 18);
            this.comboBoxAsignarActividad.Name = "comboBoxAsignarActividad";
            this.comboBoxAsignarActividad.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAsignarActividad.TabIndex = 8;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.groupBoxActividades);
            this.Name = "FormAdministrador";
            this.Text = "Administrador";
            this.groupBoxActividades.ResumeLayout(false);
            this.groupBoxActividades.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxRegistrarPago.ResumeLayout(false);
            this.groupBoxRegistrarPago.PerformLayout();
            this.groupBoxAsignarActividad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Button buttonAgregar;
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
    }
}