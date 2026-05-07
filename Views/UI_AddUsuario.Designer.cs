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
            label1.Location = new Point(83, 32);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 1;
            label1.Text = "Add Usuario";
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
            button1.Location = new Point(384, 174);
            button1.Name = "button1";
            button1.Size = new Size(153, 65);
            button1.TabIndex = 7;
            button1.Text = "Insert Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(620, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 48);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(647, 59);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 9;
            label2.Text = "Sleccione Rol";
            label2.Click += label2_Click;
            //
            // textBoxDeleteId
            //
            textBoxDeleteId.Location = new Point(620, 200);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(182, 26);
            textBoxDeleteId.TabIndex = 10;
            textBoxDeleteId.Text = "ID Usuario a Eliminar";
            //
            // buttonDelete
            //
            buttonDelete.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            buttonDelete.ForeColor = System.Drawing.Color.White;
            buttonDelete.Location = new Point(620, 245);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(182, 50);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete Usuario";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            //
            // UI_AddUsuario
            //
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
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
    }
}