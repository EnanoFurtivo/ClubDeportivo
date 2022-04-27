namespace ClubDeportivo
{
    partial class FormAgregarActividad
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.buttonAgregarActividad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCantMax = new System.Windows.Forms.TextBox();
            this.textBoxHorario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(206, 100);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(135, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(206, 182);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(135, 20);
            this.textBoxDesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo";
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(206, 262);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(132, 20);
            this.textBoxCosto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profesor";
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(493, 100);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfesor.TabIndex = 8;
            // 
            // buttonAgregarActividad
            // 
            this.buttonAgregarActividad.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarActividad.ForeColor = System.Drawing.Color.Black;
            this.buttonAgregarActividad.Location = new System.Drawing.Point(206, 378);
            this.buttonAgregarActividad.Name = "buttonAgregarActividad";
            this.buttonAgregarActividad.Size = new System.Drawing.Size(135, 23);
            this.buttonAgregarActividad.TabIndex = 11;
            this.buttonAgregarActividad.Text = "Agregar Actividad";
            this.buttonAgregarActividad.UseVisualStyleBackColor = false;
            this.buttonAgregarActividad.Click += new System.EventHandler(this.buttonAgregarActividad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dia y Horario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad maxima de participantes";
            // 
            // textBoxCantMax
            // 
            this.textBoxCantMax.Location = new System.Drawing.Point(206, 332);
            this.textBoxCantMax.Name = "textBoxCantMax";
            this.textBoxCantMax.Size = new System.Drawing.Size(132, 20);
            this.textBoxCantMax.TabIndex = 16;
            // 
            // textBoxHorario
            // 
            this.textBoxHorario.Location = new System.Drawing.Point(493, 223);
            this.textBoxHorario.Name = "textBoxHorario";
            this.textBoxHorario.Size = new System.Drawing.Size(149, 20);
            this.textBoxHorario.TabIndex = 17;
            // 
            // FormAgregarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxHorario);
            this.Controls.Add(this.textBoxCantMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAgregarActividad);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormAgregarActividad";
            this.Text = "Agregar Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.Button buttonAgregarActividad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCantMax;
        private System.Windows.Forms.TextBox textBoxHorario;
    }
}