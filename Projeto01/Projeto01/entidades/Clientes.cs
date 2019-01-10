using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.entidades
{
    public class Clientes
    {
        #region Atributos
        private string cpf;
        private string email;
        #endregion

        #region Emcapsulamento
        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
        public string Nome
        {
            set { Nome = value; }
            get { return Nome; }
        }
        public Endereco endereco
        {
            set { endereco = value; }
            get { return endereco; }
        }
        #endregion
    }
}
