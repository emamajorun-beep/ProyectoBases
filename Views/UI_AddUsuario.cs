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
using System.Diagnostics;
using Org.BouncyCastle.Pqc.Crypto.Frodo;

namespace Proyecto1.Views
{
    public partial class UI_AddUsuario : Form
    {
        List<Rol> _Listroles = null;
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

            string codigoE = textBox1.Text;
            string nombre1Usuario = textBox2.Text;
            string apellido1Usuario = textBox3.Text;
            string correoUsuario = textBox4.Text;
            string telefonoE = textBox5.Text;
            string programa = textBox6.Text;
            int idRolFK = 0;

            string rolSeleccionado = comboBox1.SelectedItem.ToString();
            for (int i = 0; i < _Listroles.Count; i++)
            {
                if (rolSeleccionado.Equals(_Listroles[i].NombreRol))
                {
                    idRolFK = _Listroles[i].IdRol;

                }
            }

            Usuario objUsuario = new Usuario(codigoE, nombre1Usuario,
                                     apellido1Usuario, correoUsuario,
                                     telefonoE, programa, idRolFK);

            ControllerUsuario objCUsuario = new ControllerUsuario();

            bool resultado = objCUsuario.InsertUsuario(objUsuario);

            if (resultado)
            {
                MessageBox.Show("Usuario agregada correctamente");
            }
            else
            {
                MessageBox.Show("Error al agregar usuario");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowRoles(object sender, EventArgs e)
        {
            ControllerRol objCRol = new ControllerRol();
            _Listroles = objCRol.GetRoles();

            foreach (Rol rol in _Listroles)
            {
                comboBox1.Items.Add(rol.NombreRol);
                comboBoxUpdateRol.Items.Add(rol.NombreRol);
            }

            //Debug.WriteLine("Mostrando roles...");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxUpdateId.Text, out int idUsuario))
            {
                MessageBox.Show("Por favor ingrese un ID válido (número entero).");
                return;
            }

            if (comboBoxUpdateRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un rol.");
                return;
            }

            int idRolFK = 0;
            string rolSeleccionado = comboBoxUpdateRol.SelectedItem.ToString();
            for (int i = 0; i < _Listroles.Count; i++)
            {
                if (rolSeleccionado.Equals(_Listroles[i].NombreRol))
                    idRolFK = _Listroles[i].IdRol;
            }

            Usuario objUsuario = new Usuario(
                textBoxUpdateCodigo.Text,
                textBoxUpdateNombre.Text,
                textBoxUpdateApellido.Text,
                textBoxUpdateCorreo.Text,
                textBoxUpdateTelefono.Text,
                textBoxUpdatePrograma.Text,
                idRolFK);

            ControllerUsuario objCUsuario = new ControllerUsuario();
            bool resultado = objCUsuario.UpdateUsuario(idUsuario, objUsuario);

            if (resultado)
            {
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario. Verifique que el ID exista.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDeleteId.Text, out int idUsuario))
            {
                MessageBox.Show("Por favor ingrese un ID válido (número entero).");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar el usuario con ID {idUsuario}? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                ControllerUsuario objCUsuario = new ControllerUsuario();
                bool resultado = objCUsuario.DeleteUsuario(idUsuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    textBoxDeleteId.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario. Verifique que el ID exista.");
                }
            }
        }
    }
}
