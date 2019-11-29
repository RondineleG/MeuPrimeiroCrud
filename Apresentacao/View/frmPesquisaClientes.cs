using System;
using System.Windows.Forms;
using Apresentacao.Models;
using ObjetoTransferencia;
using RegraNegocios;

namespace Apresentacao.View
{
    public partial class frmPesquisaClientes : Form
    {
        public frmPesquisaClientes()
        {
            InitializeComponent();
            
            // Não gerar linhas automaticas.
                       dgvCliente.AutoGenerateColumns = false;
        }

        private void AtualizaGrid()
         {
             ClienteNegocios clienteNegocios = new ClienteNegocios();

             ClienteColecao clienteColecao = new ClienteColecao();

             clienteColecao = clienteNegocios.ConsulTarPorNome(txtPesquisa.Text);

             dgvCliente.DataSource = null;
             dgvCliente.DataSource = clienteColecao;

             dgvCliente.Update();
             dgvCliente.Refresh();
         }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();

        }
         
        private void btnMininizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFeichar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Sair ?", "◄ Atenção | CIA3R ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();

            }
        }

       private void btnCadastrar_Click(object sender, EventArgs e)
        {

            frmClientes cliente = new frmClientes (Modificador.Inserir,null);
            DialogResult dialogResult = new DialogResult();
            dialogResult = cliente.ShowDialog();
            
            if (dialogResult == DialogResult.Yes)
            {
                AtualizaGrid();
            }
            

        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            var cliente = new frmClientes(Modificador.Alterar, clienteSelecionado);
            var dialogResult = cliente.ShowDialog();

            AtualizaGrid();
            
                     
       }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verificar se existe dados selecionados.
            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Clinte selecionado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            var clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            var cliente = new frmClientes(Modificador.Consultar, clienteSelecionado);
            cliente.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            // Verificar se existe dados selecionados.

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cleinte selecionado !","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Connfirmar a exclusão.

            DialogResult resultado;

           resultado = MessageBox.Show("Tem certeza que deseja excluir cliente selecionado ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( resultado == DialogResult.No)
            {
                return;

            }

            // Pegar cliente selecionado no Datagrid.

            var clienteSelecionado = ( dgvCliente.SelectedRows[0].DataBoundItem as ClienteObjeto);

            // Intânciar regra de negocios.
            ClienteNegocios clienteNegocios = new ClienteNegocios ();
            
            // Usar o metodo excluir.
          string retorno = clienteNegocios.Excluir(clienteSelecionado);

           // Verificar Se excluiu com sucesso

            try
            {
                int codRetorno = Convert.ToInt32(retorno);

                MessageBox.Show(" Cliente excluido com sucerro !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                 AtualizaGrid();
   
            }
            catch
            {
                MessageBox.Show(" Não foi possivel excluir cliente selecionado. Detalhes: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

         

         
    }

    }
