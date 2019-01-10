using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.entidades
{
    public class Pessoa
    {
        #region Atributos
        private int idPessoa;
        private string nome;
        #endregion


        public int IdPessoa
        {
            set { IdPessoa = value; }
            get { return  IdPessoa; }
     
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome; }

        }


    }
}
