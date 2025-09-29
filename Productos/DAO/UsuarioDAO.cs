using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.DAO
{
    public class UsuarioDAO
    {
        public String[] users = { "admin", "user1", "user2" };
        public String[] pws = { "admin123", "user123", "user223" };

        public Boolean Validar(String user, String pw)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if(users[i] == (user) && (pws[i].Equals(pw)))
                {
                    return true;
                }
            }return false;
        }
    }
}
