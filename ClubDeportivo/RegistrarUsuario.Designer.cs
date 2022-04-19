
namespace ClubDeportivo
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.labelLoginTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.textBoxCuota = new System.Windows.Forms.TextBox();
            this.labelCuota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginTitulo
            // 
            this.labelLoginTitulo.AutoSize = true;
            this.labelLoginTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoginTitulo.Location = new System.Drawing.Point(156, 143);
            this.labelLoginTitulo.Name = "labelLoginTitulo";
            this.labelLoginTitulo.Size = new System.Drawing.Size(128, 41);
            this.labelLoginTitulo.TabIndex = 0;
            this.labelLoginTitulo.Text = "Registro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUsuario.Location = new System.Drawing.Point(107, 221);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(223, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxClave
            // 
            this.textBoxClave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxClave.Location = new System.Drawing.Point(107, 263);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(223, 20);
            this.textBoxClave.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsuario.Location = new System.Drawing.Point(107, 205);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(45, 13);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClave.Location = new System.Drawing.Point(107, 247);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(34, 13);
            this.labelClave.TabIndex = 7;
            this.labelClave.Text = "Clave";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDni.Location = new System.Drawing.Point(107, 291);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(24, 13);
            this.labelDni.TabIndex = 9;
            this.labelDni.Text = "Dni";
            // 
            // textBoxDni
            // 
            this.textBoxDni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDni.Location = new System.Drawing.Point(107, 307);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(223, 20);
            this.textBoxDni.TabIndex = 8;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(107, 333);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(223, 21);
            this.comboBoxTipoUsuario.TabIndex = 10;
            this.comboBoxTipoUsuario.Text = "Seleccione el tipo de usuario";
            this.comboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(107, 400);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(223, 23);
            this.buttonRegistro.TabIndex = 11;
            this.buttonRegistro.Text = "Registrar";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // textBoxCuota
            // 
            this.textBoxCuota.Location = new System.Drawing.Point(230, 360);
            this.textBoxCuota.Name = "textBoxCuota";
            this.textBoxCuota.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuota.TabIndex = 12;
            this.textBoxCuota.Visible = false;
            // 
            // labelCuota
            // 
            this.labelCuota.AutoSize = true;
            this.labelCuota.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCuota.Location = new System.Drawing.Point(188, 363);
            this.labelCuota.Name = "labelCuota";
            this.labelCuota.Size = new System.Drawing.Size(36, 13);
            this.labelCuota.TabIndex = 13;
            this.labelCuota.Text = "Cuota";
            this.labelCuota.Visible = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.labelCuota);
            this.Controls.Add(this.textBoxCuota);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLoginTitulo);
            this.Name = "FormRegistro";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.TextBox textBoxCuota;
        private System.Windows.Forms.Label labelCuota;
    }
}

