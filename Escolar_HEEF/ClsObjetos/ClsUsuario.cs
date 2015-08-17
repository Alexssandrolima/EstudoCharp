using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escolar_HEEF.ClsObjetos
{
    class ClsUsuario : ClsPessoa
    {
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string acesso;

        public string Acesso
        {
            get { return acesso; }
            set { acesso = value; }
        }

    }
}
