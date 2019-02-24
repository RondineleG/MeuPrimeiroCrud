namespace ObjetoTransferencia
{
    using System;
    using System.Collections.Generic;

    public class ClienteObjeto
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public Boolean Sexo { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String CEP { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Complemento { get; set; }
        public String Email { get; set; }
        public String Obs { get; set; }
    }
    public class ClienteColecao : List<ClienteObjeto>
    {
    }
}
