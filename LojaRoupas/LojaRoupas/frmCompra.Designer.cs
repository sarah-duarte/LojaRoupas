namespace LojaRoupas
{
    partial class frmCompra
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
            this.pnlDesconto = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.rdbPerc = new System.Windows.Forms.RadioButton();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQtdItens = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstListaItensCompra = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.btnPesqProduto = new System.Windows.Forms.Button();
            this.pnlDesconto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesconto
            // 
            this.pnlDesconto.Controls.Add(this.groupBox1);
            this.pnlDesconto.Location = new System.Drawing.Point(258, 152);
            this.pnlDesconto.Name = "pnlDesconto";
            this.pnlDesconto.Size = new System.Drawing.Size(355, 200);
            this.pnlDesconto.TabIndex = 58;
            this.pnlDesconto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.rdbValor);
            this.groupBox1.Controls.Add(this.rdbPerc);
            this.groupBox1.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnOK.Location = new System.Drawing.Point(247, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 38);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(94, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "DESCONTO";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(98, 74);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(116, 32);
            this.txtDesconto.TabIndex = 22;
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.Checked = true;
            this.rdbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValor.Location = new System.Drawing.Point(23, 45);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(39, 28);
            this.rdbValor.TabIndex = 1;
            this.rdbValor.TabStop = true;
            this.rdbValor.Text = "$";
            this.rdbValor.UseVisualStyleBackColor = true;
            // 
            // rdbPerc
            // 
            this.rdbPerc.AutoSize = true;
            this.rdbPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerc.Location = new System.Drawing.Point(23, 88);
            this.rdbPerc.Name = "rdbPerc";
            this.rdbPerc.Size = new System.Drawing.Size(44, 28);
            this.rdbPerc.TabIndex = 0;
            this.rdbPerc.Text = "%";
            this.rdbPerc.UseVisualStyleBackColor = true;
            // 
            // btnDesconto
            // 
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDesconto.Location = new System.Drawing.Point(667, 15);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(118, 55);
            this.btnDesconto.TabIndex = 57;
            this.btnDesconto.Text = "DESCONTO";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "FORNECEDOR";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(14, 89);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(553, 28);
            this.cmbFornecedor.TabIndex = 53;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblID.Location = new System.Drawing.Point(170, 7);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 39);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "0001";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(668, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 55);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(668, 76);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(118, 55);
            this.btnFinalizarCompra.TabIndex = 50;
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.Coral;
            this.lblDesconto.Location = new System.Drawing.Point(585, 443);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(200, 39);
            this.lblDesconto.TabIndex = 49;
            this.lblDesconto.Text = "R$ 00,00";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(585, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 39);
            this.label8.TabIndex = 48;
            this.label8.Text = "DESCONTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQtdItens
            // 
            this.lblQtdItens.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdItens.ForeColor = System.Drawing.Color.Coral;
            this.lblQtdItens.Location = new System.Drawing.Point(585, 355);
            this.lblQtdItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdItens.Name = "lblQtdItens";
            this.lblQtdItens.Size = new System.Drawing.Size(200, 39);
            this.lblQtdItens.TabIndex = 47;
            this.lblQtdItens.Text = "000";
            this.lblQtdItens.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(585, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 39);
            this.label6.TabIndex = 46;
            this.label6.Text = "QTD ITENS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Coral;
            this.lblTotal.Location = new System.Drawing.Point(585, 267);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 39);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "R$ 000,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(585, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 39);
            this.label2.TabIndex = 44;
            this.label2.Text = "TOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(315, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "QUANTIDADE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(14, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "CÓDIGO DE BARRAS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BurlyWood;
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 39);
            this.label10.TabIndex = 41;
            this.label10.Text = "COMPRA";
            // 
            // lstListaItensCompra
            // 
            this.lstListaItensCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descricao,
            this.Preco,
            this.Qtde,
            this.Total});
            this.lstListaItensCompra.HideSelection = false;
            this.lstListaItensCompra.Location = new System.Drawing.Point(14, 211);
            this.lstListaItensCompra.Name = "lstListaItensCompra";
            this.lstListaItensCompra.Size = new System.Drawing.Size(557, 294);
            this.lstListaItensCompra.TabIndex = 40;
            this.lstListaItensCompra.UseCompatibleStateImageBehavior = false;
            this.lstListaItensCompra.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "CODIGO";
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.Text = "DESCRIÇÃO";
            this.Descricao.Width = 264;
            // 
            // Preco
            // 
            this.Preco.Text = "PREÇO";
            this.Preco.Width = 71;
            // 
            // Qtde
            // 
            this.Qtde.Text = "QTDE";
            this.Qtde.Width = 70;
            // 
            // Total
            // 
            this.Total.Text = "TOTAL";
            this.Total.Width = 76;
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAddItem.Location = new System.Drawing.Point(449, 137);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(118, 55);
            this.btnAddItem.TabIndex = 39;
            this.btnAddItem.Text = "ADICIONAR ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(315, 162);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(116, 32);
            this.txtQtd.TabIndex = 38;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(14, 162);
            this.txtCodBarras.MaxLength = 15;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(258, 32);
            this.txtCodBarras.TabIndex = 37;
            // 
            // btnPesqProduto
            // 
            this.btnPesqProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqProduto.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnPesqProduto.Location = new System.Drawing.Point(278, 163);
            this.btnPesqProduto.Name = "btnPesqProduto";
            this.btnPesqProduto.Size = new System.Drawing.Size(30, 29);
            this.btnPesqProduto.TabIndex = 59;
            this.btnPesqProduto.Text = "...";
            this.btnPesqProduto.UseVisualStyleBackColor = true;
            this.btnPesqProduto.Click += new System.EventHandler(this.btnPesqProduto_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.pnlDesconto);
            this.Controls.Add(this.btnPesqProduto);
            this.Controls.Add(this.lstListaItensCompra);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQtdItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtCodBarras);
            this.Name = "frmCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.pnlDesconto.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesconto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.RadioButton rdbValor;
        private System.Windows.Forms.RadioButton rdbPerc;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQtdItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lstListaItensCompra;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Qtde;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Button btnPesqProduto;
    }
}