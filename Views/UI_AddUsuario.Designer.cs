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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 26);
            textBox1.TabIndex = 0;
            textBox1.Text = "Nombre1 Usuario";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 1;
            label1.Text = "Add Usuario";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 26);
            textBox2.TabIndex = 2;
            textBox2.Text = "Nombre2 Usuario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 26);
            textBox3.TabIndex = 3;
            textBox3.Text = "Apellido1 Usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(298, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 26);
            textBox4.TabIndex = 4;
            textBox4.Text = "Apellido2 Usuario";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(298, 276);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 26);
            textBox5.TabIndex = 5;
            textBox5.Text = "Correo Usuario";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(298, 324);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 26);
            textBox6.TabIndex = 6;
            textBox6.Text = "Tipo Usuario";
            // 
            // button1
            // 
            button1.Location = new Point(321, 373);
            button1.Name = "button1";
            button1.Size = new Size(153, 65);
            button1.TabIndex = 7;
            button1.Text = "Insert Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UI_AddUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
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
    }
}