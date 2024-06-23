using MeuPrimeiroCrud.Business;
using MeuPrimeiroCrud.Business.Models;

using System;
using System.Windows.Forms;

namespace MeuPrimeiroCrud.View.View
{
    public partial class Clientes : Form
    {
        EModificador telaSelecionada;

        public Clientes(EModificador modificador, Cliente cliente)
        {
            InitializeComponent();
            {
                telaSelecionada = modificador;
                if (modificador == EModificador.Alterar)
                {
                    lblCliente.Text = "Alterar Cliente";
                    txtCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    dtpDataNascimento.Value = cliente.DataNascimento;
                    rdbMasculino.Checked = cliente.Sexo;
                    rdbFeminino.Checked = !cliente.Sexo;
                    txtTelefone.Text = cliente.Telefone;
                    txtCelular.Text = cliente.Celular;
                    txtEmail.Text = cliente.Email;
                    txtCEP.Text = cliente.CEP;
                    txtEndereco.Text = cliente.Endereco;
                    txtCidade.Text = cliente.Cidade;
                    txtBairro.Text = cliente.Bairro;
                    txtEstado.Text = cliente.Estado;
                    txtComplemento.Text = cliente.Complemento;
                    txtObs.Text = cliente.Obs;
                }
                else if (modificador == EModificador.Consultar)
                {
                    lblCliente.Text = "Consultar Cliente";
                    txtCodigo.Text = cliente.Codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    dtpDataNascimento.Value = cliente.DataNascimento;
                    rdbMasculino.Checked = cliente.Sexo;
                    rdbFeminino.Checked = !cliente.Sexo;
                    txtTelefone.Text = cliente.Telefone;
                    txtCelular.Text = cliente.Celular;
                    txtEmail.Text = cliente.Email;
                    txtCEP.Text = cliente.CEP;
                    txtCidade.Text = cliente.Cidade;
                    txtEndereco.Text = cliente.Endereco;
                    txtBairro.Text = cliente.Bairro;
                    txtEstado.Text = cliente.Estado;
                    txtComplemento.Text = cliente.Complemento;
                    txtObs.Text = cliente.Obs;

                    // Desabilitar campos para somenete leitura.
                    txtCodigo.Enabled = false;
                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    dtpDataNascimento.Enabled = false;
                    rdbFeminino.Enabled = false;
                    rdbMasculino.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtCelular.Enabled = false;
                    txtCEP.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtEmail.Enabled = false;
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false;
                    txtEstado.Enabled = false;
                    txtComplemento.Enabled = false;
                    txtObs.Enabled = false;
                    btnSalvar.Visible = false;
                    btnCancelar.Visible = false;
                }
                else if (modificador == EModificador.Inserir)
                {
                    lblCliente.Text = " Inserir Cliente";
                }
            }
        }

        private void btnFeichar_Click(object sender, EventArgs e) => Close();

        private void btnMininizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var pesquisaClientes = new PesquisaClientes();
            pesquisaClientes.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificar se e inserçao ou alteraçao.
            if (telaSelecionada == EModificador.Inserir)
            {
                var clienteObjeto = new Cliente();
                var clienteNegocios = new ClienteNegocios();
                clienteObjeto.Nome = txtNome.Text;
                clienteObjeto.CPF = txtCPF.Text;
                clienteObjeto.DataNascimento = dtpDataNascimento.Value;
                rdbMasculino.Checked = clienteObjeto.Sexo;
                rdbFeminino.Checked = !clienteObjeto.Sexo;
                clienteObjeto.Telefone = txtTelefone.Text;
                clienteObjeto.Celular = txtCelular.Text;
                clienteObjeto.Email = txtEmail.Text;
                clienteObjeto.CEP = txtCEP.Text;
                clienteObjeto.Endereco = txtEndereco.Text;
                clienteObjeto.Cidade = txtCidade.Text;
                clienteObjeto.Bairro = txtBairro.Text;
                clienteObjeto.Estado = txtEstado.Text;
                clienteObjeto.Complemento = txtComplemento.Text;
                clienteObjeto.Obs = txtObs.Text;
                var retorno = clienteNegocios.Inserir(clienteObjeto);
                try
                {
                    var codRetorno = Convert.ToInt32(retorno);
                    MessageBox.Show(" Cliente inserido com sucesso. Código : " + codRetorno.ToString());
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show(" Não foi possivel inserir cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }
            }

            else if (telaSelecionada == EModificador.Alterar)
            {
                var cliente = new Cliente();
                cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                rdbMasculino.Checked = cliente.Sexo;
                rdbFeminino.Checked = !cliente.Sexo;
                cliente.Telefone = txtTelefone.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Email = txtEmail.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Estado = txtEstado.Text;
                cliente.Complemento = txtComplemento.Text;
                cliente.Obs = txtObs.Text;
                var clienteNegocios = new ClienteNegocios();
                var retorno = clienteNegocios.Alterar(cliente);
                try
                {
                    var codRetorno = Convert.ToInt32(retorno);
                    MessageBox.Show(" Cliente alterado com sucerro. Código : " + codRetorno.ToString());
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar cliente. Detalhes : " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }
            }
            else if (telaSelecionada == EModificador.Consultar)
            {
            }
        }
    }
}