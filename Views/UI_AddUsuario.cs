using Proyecto1.Modelos;
using Proyecto1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1.Views
{
    public partial class UI_AddUsuario : Form
    {
        public UI_AddUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombre1Usuario = textBox1.Text;
            string nombre2Usuario = textBox2.Text;
            string apellido1Usuario = textBox3.Text;
            string apellido2Usuario = textBox4.Text;
            string correoUsuario = textBox5.Text;
            string tipoUsuario = textBox6.Text;

            Usuario objUsuario = new Usuario(nombre1Usuario, nombre2Usuario,
                                     apellido1Usuario, apellido2Usuario,
                                     correoUsuario, tipoUsuario);

            ControllerUsuario objCUsuario = new ControllerUsuario();

            bool resultado = objCUsuario.InsertUsuario(objUsuario);
        }
    }
}
