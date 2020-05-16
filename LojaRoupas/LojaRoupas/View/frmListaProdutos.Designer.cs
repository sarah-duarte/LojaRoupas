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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProdutos));
            this.lstListaProduto = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoBarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoCusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtdEstProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaProduto
            // 
            this.lstListaProduto.BackColor = System.Drawing.Color.Black;
            this.lstListaProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.codigoBarras,
            this.descricao,
            this.corProduto,
            this.tamProduto,
            this.precoCusto,
            this.precoVenda,
            this.qtdEstProduto});
            this.lstListaProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProduto.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaProduto.HideSelection = false;
            this.lstListaProduto.Location = new System.Drawing.Point(0, 0);
            this.lstListaProduto.Name = "lstListaProduto";
            this.lstListaProduto.Size = new System.Drawing.Size(780, 481);
            this.lstListaProduto.TabIndex = 0;
            this.lstListaProduto.UseCompatibleStateImageBehavior = false;
            this.lstListaProduto.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // codigoBarras
            // 
            this.codigoBarras.Text = "Codigo Barras";
            this.codigoBarras.Width = 103;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 146;
            // 
            // corProduto
            // 
            this.corProduto.Text = "Cor";
            this.corProduto.Width = 84;
            // 
            // tamProduto
            // 
            this.tamProduto.Text = "Tamanho";
            // 
            // precoCusto
            // 
            this.precoCusto.Text = "Custo";
            this.precoCusto.Width = 70;
            // 
            // precoVenda
            // 
            this.precoVenda.Text = "Venda";
            this.precoVenda.Width = 77;
            // 
            // qtdEstProduto
            // 
            this.qtdEstProduto.Text = "Estoque";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(650, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 55);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "NOVO ITEM";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(650, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 55);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(780, 481);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaProduto);
            this.MaximizeBox = false;
            this.Name = "frmListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.frmListaProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstListaProduto;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader codigoBarras;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader corProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ColumnHeader tamProduto;
        private System.Windows.Forms.ColumnHeader precoCusto;
        private System.Windows.Forms.ColumnHeader precoVenda;
        private System.Windows.Forms.ColumnHeader qtdEstProduto;
        private System.Windows.Forms.Button btnCancelar;
    }
}