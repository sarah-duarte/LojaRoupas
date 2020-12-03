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
            this.btnPesq = new System.Windows.Forms.Button();
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
            this.lstListaProduto.BackColor = System.Drawing.Color.Silver;
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
            this.lstListaProduto.ForeColor = System.Drawing.Color.Blue;
            this.lstListaProduto.FullRowSelect = true;
            this.lstListaProduto.HideSelection = false;
            this.lstListaProduto.Location = new System.Drawing.Point(0, 115);
            this.lstListaProduto.Name = "lstListaProduto";
            this.lstListaProduto.Size = new System.Drawing.Size(655, 335);
            this.lstListaProduto.TabIndex = 1;
            this.lstListaProduto.UseCompatibleStateImageBehavior = false;
            this.lstListaProduto.View = System.Windows.Forms.View.Details;
            this.lstListaProduto.DoubleClick += new System.EventHandler(this.lstListaProduto_DoubleClick);
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
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.Blue;
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.ForeColor = System.Drawing.Color.Peru;
            this.btnPesq.Location = new System.Drawing.Point(478, 79);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(113, 27);
            this.btnPesq.TabIndex = 7;
            this.btnPesq.Text = "PESQUISAR";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtPrcVenda
            // 
            this.txtPrcVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrcVenda.ForeColor = System.Drawing.Color.Blue;
            this.txtPrcVenda.Location = new System.Drawing.Point(327, 86);
            this.txtPrcVenda.Name = "txtPrcVenda";
            this.txtPrcVenda.Size = new System.Drawing.Size(78, 20);
            this.txtPrcVenda.TabIndex = 6;
            // 
            // txtPrcCusto
            // 
            this.txtPrcCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrcCusto.ForeColor = System.Drawing.Color.Blue;
            this.txtPrcCusto.Location = new System.Drawing.Point(140, 87);
            this.txtPrcCusto.Name = "txtPrcCusto";
            this.txtPrcCusto.Size = new System.Drawing.Size(78, 20);
            this.txtPrcCusto.TabIndex = 5;
            // 
            // txtTamanho
            // 
            this.txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTamanho.ForeColor = System.Drawing.Color.Blue;
            this.txtTamanho.Location = new System.Drawing.Point(327, 222);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(125, 20);
            this.txtTamanho.TabIndex = 4;
            // 
            // txtCor
            // 
            this.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.ForeColor = System.Drawing.Color.Blue;
            this.txtCor.Location = new System.Drawing.Point(98, 222);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(154, 20);
            this.txtCor.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.ForeColor = System.Drawing.Color.Blue;
            this.txtDescricao.Location = new System.Drawing.Point(98, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(287, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarras.ForeColor = System.Drawing.Color.Blue;
            this.txtCodBarras.Location = new System.Drawing.Point(98, 40);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(167, 20);
            this.txtCodBarras.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(221, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "PRECO ATUAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "PRECO ANTERIOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(221, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "TAMANHO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "DESCRIÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(62, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "COR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "CÓDIGO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Peru;
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "PESQUISA DE PRODUTO";
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.txtPrcVenda);
            this.Controls.Add(this.txtPrcCusto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstListaProduto);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnPesq;
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