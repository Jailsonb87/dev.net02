using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.entidades
{
    public class Endereco
    {
        #region Atributos
        private int idEndereco;
        private string Logradouro;
        private string Estado;
        private string Cidade;
        private string Cep;
        #endregion

        #region Metodos
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Logradouro1 { get => Logradouro; set => Logradouro = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Cidade1 { get => Cidade; set => Cidade = value; }
        public string Cep1 { get => Cep; set => Cep = value; }
        #endregion
    }
}
