
using Data;
using Data.Model;
using System;

namespace Minhas_Finanças.Controllers
{
    public class UsuarioController
    {
        public const string STR_OK = "OK";
        public const string STR_NOK = "NOK";

        UsuarioModel usuarioModel = new UsuarioModel();
        public string doLogin(Usuario user)
        {

            try
            {
                if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Senha))
                    throw new Exception("Favor preencher todos os campos!");

                user = usuarioModel.GetUsuario(user.UserName, user.Senha);

                if (user.UserName != null)
                    return STR_OK;
                else
                    return STR_NOK;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
