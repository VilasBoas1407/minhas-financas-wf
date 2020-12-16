using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class UsuarioModel
    {
        public DB_FINANCAS_Entities db = new DB_FINANCAS_Entities();
        public Usuario GetUsuario(string UserName, string Senha)
        {
            Usuario user = new Usuario();
            try
            {
                user = db.Usuario.Where(u => u.UserName.Equals(UserName) && u.Senha.Equals(Senha)).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
