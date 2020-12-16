using Data;
using Minhas_Finanças.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minhas_Finanças
{
    public partial class LoginForm : Form
    {
        public const string STR_OK = "OK";
        public const string STR_NOK = "NOK";

        UsuarioController usuarioController = new UsuarioController();



        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.UserName = this.txtLogin.Text;
            user.Senha = this.txtSenha.Text;

            string result = usuarioController.doLogin(user);

            if (result == STR_OK) {
                //doLogin
            }
            else
            {
                //doError
            }

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroForm form = new CadastroForm();
            form.Show();
        }
    }
}
