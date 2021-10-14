namespace BurgerPDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnMininizar = new System.Windows.Forms.Button();
            this.btnFeichar = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.categoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesuisarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopo.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlTopo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.lblCliente);
            this.pnlTopo.Controls.Add(this.btnMininizar);
            this.pnlTopo.Controls.Add(this.btnFeichar);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(802, 30);
            this.pnlTopo.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "PDV - Burger Prince";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 24);
            this.lblCliente.TabIndex = 30;
            // 
            // btnMininizar
            // 
            this.btnMininizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMininizar.BackColor = System.Drawing.Color.Maroon;
            this.btnMininizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMininizar.ForeColor = System.Drawing.Color.White;
            this.btnMininizar.Location = new System.Drawing.Point(746, 1);
            this.btnMininizar.Name = "btnMininizar";
            this.btnMininizar.Size = new System.Drawing.Size(30, 30);
            this.btnMininizar.TabIndex = 1;
            this.btnMininizar.Text = "--";
            this.btnMininizar.UseVisualStyleBackColor = false;
            this.btnMininizar.Click += new System.EventHandler(this.btnMininizar_Click);
            // 
            // btnFeichar
            // 
            this.btnFeichar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeichar.BackColor = System.Drawing.Color.Maroon;
            this.btnFeichar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeichar.ForeColor = System.Drawing.Color.White;
            this.btnFeichar.Location = new System.Drawing.Point(773, 1);
            this.btnFeichar.Name = "btnFeichar";
            this.btnFeichar.Size = new System.Drawing.Size(30, 30);
            this.btnFeichar.TabIndex = 2;
            this.btnFeichar.Text = "X";
            this.btnFeichar.UseVisualStyleBackColor = false;
            this.btnFeichar.Click += new System.EventHandler(this.btnFeichar_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaMenu,
            this.produtoMenu,
            this.menuCliente,
            this.menuEstoque});
            this.menu.Location = new System.Drawing.Point(0, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(802, 54);
            this.menu.TabIndex = 47;
            // 
            // categoriaMenu
            // 
            this.categoriaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarCategoria});
            this.categoriaMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaMenu.Image = ((System.Drawing.Image)(resources.GetObject("categoriaMenu.Image")));
            this.categoriaMenu.Name = "categoriaMenu";
            this.categoriaMenu.Padding = new System.Windows.Forms.Padding(0);
            this.categoriaMenu.Size = new System.Drawing.Size(99, 50);
            this.categoriaMenu.Text = "Categoria";
            // 
            // btnGerenciarCategoria
            // 
            this.btnGerenciarCategoria.Name = "btnGerenciarCategoria";
            this.btnGerenciarCategoria.Size = new System.Drawing.Size(180, 22);
            this.btnGerenciarCategoria.Text = "Gerenciar";
            // 
            // produtoMenu
            // 
            this.produtoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarProduto,
            this.btnPesuisarProduto});
            this.produtoMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoMenu.Image = ((System.Drawing.Image)(resources.GetObject("produtoMenu.Image")));
            this.produtoMenu.Name = "produtoMenu";
            this.produtoMenu.Padding = new System.Windows.Forms.Padding(0);
            this.produtoMenu.Size = new System.Drawing.Size(85, 50);
            this.produtoMenu.Text = "Produto";
            // 
            // btnGerenciarProduto
            // 
            this.btnGerenciarProduto.Name = "btnGerenciarProduto";
            this.btnGerenciarProduto.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarProduto.Text = "Gerenciar";
            // 
            // btnPesuisarProduto
            // 
            this.btnPesuisarProduto.Name = "btnPesuisarProduto";
            this.btnPesuisarProduto.Size = new System.Drawing.Size(148, 22);
            this.btnPesuisarProduto.Text = "Pesquisar";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarCliente});
            this.menuCliente.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = ((System.Drawing.Image)(resources.GetObject("menuCliente.Image")));
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Padding = new System.Windows.Forms.Padding(0);
            this.menuCliente.Size = new System.Drawing.Size(79, 50);
            this.menuCliente.Text = "Cliente";
            // 
            // btnGerenciarCliente
            // 
            this.btnGerenciarCliente.Name = "btnGerenciarCliente";
            this.btnGerenciarCliente.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarCliente.Text = "Gerenciar";
            // 
            // menuEstoque
            // 
            this.menuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarEstoque});
            this.menuEstoque.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEstoque.Image = ((System.Drawing.Image)(resources.GetObject("menuEstoque.Image")));
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Padding = new System.Windows.Forms.Padding(0);
            this.menuEstoque.Size = new System.Drawing.Size(87, 50);
            this.menuEstoque.Text = "Estoque";
            // 
            // btnGerenciarEstoque
            // 
            this.btnGerenciarEstoque.Name = "btnGerenciarEstoque";
            this.btnGerenciarEstoque.Size = new System.Drawing.Size(148, 22);
            this.btnGerenciarEstoque.Text = "Gerenciar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 301);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnMininizar;
        private System.Windows.Forms.Button btnFeichar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem categoriaMenu;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarCategoria;
        private System.Windows.Forms.ToolStripMenuItem produtoMenu;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarProduto;
        private System.Windows.Forms.ToolStripMenuItem btnPesuisarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarEstoque;
    }
}

