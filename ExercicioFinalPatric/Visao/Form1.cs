using ExercicioFinalPatric.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioFinalPatric
{
    public partial class Login : Form
    {
        UsuarioControlador _UsuarioControlador;
        public Login()
        {
            InitializeComponent();
            _UsuarioControlador = new UsuarioControlador();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var retorno = _UsuarioControlador.realizaLogin(Convert.ToString(txtnome.Text), txtsenha.Text);
                if (retorno.sucesso)
                {
                    MessageBox.Show("Login feito com Sucesso!");
                }
                else
                    MessageBox.Show(retorno.descricao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
