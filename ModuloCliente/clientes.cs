using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente
{
    public class clientes
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, \n" +
                 $"CPF: {this.Cpf}, \n " +
                 $"E-mail: {this.Email}, \n" +
                 $"Idade: {this.Idade}";

        }
    }
}
