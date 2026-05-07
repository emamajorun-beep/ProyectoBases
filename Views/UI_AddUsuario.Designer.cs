namespace Proyecto1.Views
{
    partial class UI_AddUsuario
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBoxDeleteId = new TextBox();
            buttonDelete = new Button();
            labelUpdate = new Label();
            textBoxUpdateId = new TextBox();
            textBoxUpdateCodigo = new TextBox();
            textBoxUpdateNombre = new TextBox();
            textBoxUpdateApellido = new TextBox();
            textBoxUpdateCorreo = new TextBox();
            textBoxUpdateTelefono = new TextBox();
            textBoxUpdatePrograma = new TextBox();
            comboBoxUpdateRol = new ComboBox();
            labelUpdateRol = new Label();
            buttonUpdate = new Button();
            buttonBuscar = new Button();
            textBoxBuscarId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 26);
            textBox1.TabIndex = 0;
            textBox1.Text = "Codigo Usuario";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 1;
            label1.Text = "Añadir Usuario";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 26);
            textBox2.TabIndex = 2;
            textBox2.Text = "Nombre Usuario";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(47, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 26);
            textBox3.TabIndex = 3;
            textBox3.Text = "Apellido Usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(47, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 26);
            textBox4.TabIndex = 4;
            textBox4.Text = "Correo Usuario";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(47, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 26);
            textBox5.TabIndex = 5;
            textBox5.Text = "Telefono Usuario";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(47, 312);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 26);
            textBox6.TabIndex = 6;
            textBox6.Text = "Programa Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(312, 245);
            button1.Name = "button1";
            button1.Size = new Size(180, 65);
            button1.TabIndex = 7;
            button1.Text = "Insert Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 31);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F);
            label2.Location = new Point(312, 133);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 9;
            label2.Text = "Seleccione Rol";
            label2.Click += label2_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(603, 264);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(182, 26);
            textBoxDeleteId.TabIndex = 10;
            textBoxDeleteId.Text = "ID Usuario a Eliminar";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(603, 300);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(182, 50);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete Usuario";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelUpdate
            // 
            labelUpdate.AutoSize = true;
            labelUpdate.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUpdate.Location = new Point(47, 376);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(216, 27);
            labelUpdate.TabIndex = 12;
            labelUpdate.Text = "Actualizar Usuario";
            labelUpdate.Click += labelUpdate_Click;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Location = new Point(47, 420);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.Size = new Size(236, 26);
            textBoxUpdateId.TabIndex = 13;
            textBoxUpdateId.Text = "ID Usuario a Actualizar";
            // 
            // textBoxUpdateCodigo
            // 
            textBoxUpdateCodigo.Location = new Point(47, 460);
            textBoxUpdateCodigo.Name = "textBoxUpdateCodigo";
            textBoxUpdateCodigo.Size = new Size(236, 26);
            textBoxUpdateCodigo.TabIndex = 14;
            textBoxUpdateCodigo.Text = "Nuevo Codigo";
            // 
            // textBoxUpdateNombre
            // 
            textBoxUpdateNombre.Location = new Point(47, 500);
            textBoxUpdateNombre.Name = "textBoxUpdateNombre";
            textBoxUpdateNombre.Size = new Size(236, 26);
            textBoxUpdateNombre.TabIndex = 15;
            textBoxUpdateNombre.Text = "Nuevo Nombre";
            // 
            // textBoxUpdateApellido
            // 
            textBoxUpdateApellido.Location = new Point(47, 540);
            textBoxUpdateApellido.Name = "textBoxUpdateApellido";
            textBoxUpdateApellido.Size = new Size(236, 26);
            textBoxUpdateApellido.TabIndex = 16;
            textBoxUpdateApellido.Text = "Nuevo Apellido";
            // 
            // textBoxUpdateCorreo
            // 
            textBoxUpdateCorreo.Location = new Point(310, 420);
            textBoxUpdateCorreo.Name = "textBoxUpdateCorreo";
            textBoxUpdateCorreo.Size = new Size(236, 26);
            textBoxUpdateCorreo.TabIndex = 17;
            textBoxUpdateCorreo.Text = "Nuevo Correo";
            // 
            // textBoxUpdateTelefono
            // 
            textBoxUpdateTelefono.Location = new Point(310, 460);
            textBoxUpdateTelefono.Name = "textBoxUpdateTelefono";
            textBoxUpdateTelefono.Size = new Size(236, 26);
            textBoxUpdateTelefono.TabIndex = 18;
            textBoxUpdateTelefono.Text = "Nuevo Telefono";
            // 
            // textBoxUpdatePrograma
            // 
            textBoxUpdatePrograma.Location = new Point(310, 500);
            textBoxUpdatePrograma.Name = "textBoxUpdatePrograma";
            textBoxUpdatePrograma.Size = new Size(236, 26);
            textBoxUpdatePrograma.TabIndex = 19;
            textBoxUpdatePrograma.Text = "Nuevo Programa";
            // 
            // comboBoxUpdateRol
            // 
            comboBoxUpdateRol.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxUpdateRol.FormattingEnabled = true;
            comboBoxUpdateRol.Location = new Point(580, 425);
            comboBoxUpdateRol.Name = "comboBoxUpdateRol";
            comboBoxUpdateRol.Size = new Size(220, 29);
            comboBoxUpdateRol.TabIndex = 21;
            // 
            // labelUpdateRol
            // 
            labelUpdateRol.AutoSize = true;
            labelUpdateRol.Font = new Font("Century Gothic", 13.8F);
            labelUpdateRol.Location = new Point(620, 395);
            labelUpdateRol.Name = "labelUpdateRol";
            labelUpdateRol.Size = new Size(129, 27);
            labelUpdateRol.TabIndex = 20;
            labelUpdateRol.Text = "Nuevo Rol";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(0, 102, 204);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(580, 480);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(220, 55);
            buttonUpdate.TabIndex = 22;
            buttonUpdate.Text = "Update Usuario";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Lime;
            buttonBuscar.Location = new Point(603, 174);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(182, 29);
            buttonBuscar.TabIndex = 23;
            buttonBuscar.Text = "Read Usuario";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // textBoxBuscarId
            // 
            textBoxBuscarId.Location = new Point(603, 133);
            textBoxBuscarId.Name = "textBoxBuscarId";
            textBoxBuscarId.Size = new Size(180, 26);
            textBoxBuscarId.TabIndex = 24;
            textBoxBuscarId.Text = "ID usuario a Buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F);
            label3.Location = new Point(565, 87);
            label3.Name = "label3";
            label3.Size = new Size(256, 27);
            label3.TabIndex = 25;
            label3.Text = "Leer datos de Usuario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F);
            label4.Location = new Point(617, 219);
            label4.Name = "label4";
            label4.Size = new Size(166, 27);
            label4.TabIndex = 26;
            label4.Text = "Borrar Usuario";
            // 
            // UI_AddUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 620);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxBuscarId);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxUpdateRol);
            Controls.Add(labelUpdateRol);
            Controls.Add(textBoxUpdatePrograma);
            Controls.Add(textBoxUpdateTelefono);
            Controls.Add(textBoxUpdateCorreo);
            Controls.Add(textBoxUpdateApellido);
            Controls.Add(textBoxUpdateNombre);
            Controls.Add(textBoxUpdateCodigo);
            Controls.Add(textBoxUpdateId);
            Controls.Add(labelUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxDeleteId);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UI_AddUsuario";
            Text = "UI_AddUsuario";
            Load += ShowRoles;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBoxDeleteId;
        private Button buttonDelete;
        private Label labelUpdate;
        private TextBox textBoxUpdateId;
        private TextBox textBoxUpdateCodigo;
        private TextBox textBoxUpdateNombre;
        private TextBox textBoxUpdateApellido;
        private TextBox textBoxUpdateCorreo;
        private TextBox textBoxUpdateTelefono;
        private TextBox textBoxUpdatePrograma;
        private Label labelUpdateRol;
        private ComboBox comboBoxUpdateRol;
        private Button buttonUpdate;
        private Button buttonBuscar;
        private TextBox textBoxBuscarId;
        private Label label3;
        private Label label4;
    }
}