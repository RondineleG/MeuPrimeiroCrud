using MeuPrimeiroCrud.Business;
using MeuPrimeiroCrud.Business.Models;

using System;
using System.Windows.Forms;

namespace MeuPrimeiroCrud.View.View
{
    public partial class PesquisaClientes : Form
    {
        public PesquisaClientes()
        {
            InitializeComponent();
            dgvCliente.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            var clienteNegocios = new ClienteNegocios();
            var clienteColecao = clienteNegocios.ConsulTarPorNome(txtPesquisa.Text);
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clienteColecao;
            dgvCliente.Update();
            dgvCliente.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) => AtualizaGrid();

        private void btnMininizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnFeichar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "◄ Atenção ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes(EModificador.Inserir, null);
            var dialogResult = cliente.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ValidaSeLinhaSelecionadoNoGrid();
            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);
            var cliente = new Clientes(EModificador.Alterar, clienteSelecionado);
            cliente.ShowDialog();
            AtualizaGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ValidaSeLinhaSelecionadoNoGrid();
            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);
            var cliente = new Clientes(EModificador.Consultar, clienteSelecionado);
            cliente.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ValidaSeLinhaSelecionadoNoGrid();
            var resultado = MessageBox.Show("Tem certeza que deseja excluir cliente selecionado ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Cliente);
            var clienteNegocios = new ClienteNegocios();
            var retorno = clienteNegocios.Excluir(clienteSelecionado);
            try
            {
                var codRetorno = Convert.ToInt32(retorno);
                MessageBox.Show(" Cliente excluido com sucerro !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possivel excluir cliente selecionado. Detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaSeLinhaSelecionadoNoGrid()
        {
            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
