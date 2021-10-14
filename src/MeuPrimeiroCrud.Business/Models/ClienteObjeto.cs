namespace MeuPrimeiroCrud.Business.Models
{
    using System;
    using System.Collections.Generic;

    public class ClienteObjeto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Sexo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
    }
    public class ClienteColecao : List<ClienteObjeto>
    {
    }
}
