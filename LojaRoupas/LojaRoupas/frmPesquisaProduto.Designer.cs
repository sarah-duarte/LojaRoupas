namespace LojaRoupas
{
    partial class frmPesquisaProduto
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
            this.lstListaProduto = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoBarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoCusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtdEstProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPrcVenda = new System.Windows.Forms.TextBox();
            this.txtPrcCusto = new System.Windows.Forms.TextBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.lstListaProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstListaProduto.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaProduto.HideSelection = false;
            this.lstListaProduto.Location = new System.Drawing.Point(0, 115);
            this.lstListaProduto.Name = "lstListaProduto";
            this.lstListaProduto.Size = new System.Drawing.Size(655, 335);
            this.lstListaProduto.TabIndex = 1;
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
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnSalvar.Location = new System.Drawing.Point(509, 63);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 44);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "PESQUISAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtPrcVenda
            // 
            this.txtPrcVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrcVenda.Location = new System.Drawing.Point(327, 89);
            this.txtPrcVenda.Name = "txtPrcVenda";
            this.txtPrcVenda.Size = new System.Drawing.Size(78, 20);
            this.txtPrcVenda.TabIndex = 28;
            // 
            // txtPrcCusto
            // 
            this.txtPrcCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrcCusto.Location = new System.Drawing.Point(127, 89);
            this.txtPrcCusto.Name = "txtPrcCusto";
            this.txtPrcCusto.Size = new System.Drawing.Size(78, 20);
            this.txtPrcCusto.TabIndex = 26;
            // 
            // txtTamanho
            // 
            this.txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTamanho.Location = new System.Drawing.Point(315, 63);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(125, 20);
            this.txtTamanho.TabIndex = 24;
            // 
            // txtCor
            // 
            this.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.Location = new System.Drawing.Point(60, 63);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(154, 20);
            this.txtCor.TabIndex = 22;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(356, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(287, 20);
            this.txtDescricao.TabIndex = 20;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarras.Location = new System.Drawing.Point(85, 37);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(167, 20);
            this.txtCodBarras.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(210, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "PRECO VENDA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "PRECO CUSTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(221, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "TAMANHO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(259, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "DESCRIÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "COR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "BARRAS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BurlyWood;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "PESQUISA DE PRODUTO";
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPrcVenda);
            this.Controls.Add(this.txtPrcCusto);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstListaProduto);
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstListaProduto;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader codigoBarras;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader corProduto;
        private System.Windows.Forms.ColumnHeader tamProduto;
        private System.Windows.Forms.ColumnHeader precoCusto;
        private System.Windows.Forms.ColumnHeader precoVenda;
        private System.Windows.Forms.ColumnHeader qtdEstProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPrcVenda;
        private System.Windows.Forms.TextBox txtPrcCusto;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}