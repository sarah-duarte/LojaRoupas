namespace LojaRoupas
{
    partial class frmListaProdutos
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
            this.components = new System.ComponentModel.Container();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.AutoGenerateColumns = false;
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigoBarras,
            this.descricao,
            this.corProduto,
            this.tamProduto,
            this.precoCusto,
            this.precoVenda,
            this.qtdEstoque});
            this.dgvListaProduto.Location = new System.Drawing.Point(12, 12);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.Size = new System.Drawing.Size(745, 348);
            this.dgvListaProduto.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // codigoBarras
            // 
            this.codigoBarras.DataPropertyName = "codigoBarras";
            this.codigoBarras.HeaderText = "codigoBarras";
            this.codigoBarras.Name = "codigoBarras";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            // 
            // corProduto
            // 
            this.corProduto.DataPropertyName = "corProduto";
            this.corProduto.HeaderText = "corProduto";
            this.corProduto.Name = "corProduto";
            // 
            // tamProduto
            // 
            this.tamProduto.DataPropertyName = "tamProduto";
            this.tamProduto.HeaderText = "tamProduto";
            this.tamProduto.Name = "tamProduto";
            // 
            // precoCusto
            // 
            this.precoCusto.DataPropertyName = "precoCusto";
            this.precoCusto.HeaderText = "precoCusto";
            this.precoCusto.Name = "precoCusto";
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "precoVenda";
            this.precoVenda.Name = "precoVenda";
            // 
            // qtdEstoque
            // 
            this.qtdEstoque.DataPropertyName = "qtdEstoque";
            this.qtdEstoque.HeaderText = "qtdEstoque";
            this.qtdEstoque.Name = "qtdEstoque";
            // 
            // frmListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 372);
            this.Controls.Add(this.dgvListaProduto);
            this.Name = "frmListaProdutos";
            this.Text = "frmListaProdutos";
            this.Load += new System.EventHandler(this.frmListaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoque;
    }
}