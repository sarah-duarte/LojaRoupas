namespace LojaRoupas
{
    partial class frmVenda
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
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstListaItensVenda = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQtdItens = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(20, 97);
            this.txtCodBarras.MaxLength = 15;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(226, 32);
            this.txtCodBarras.TabIndex = 4;
            // 
            // txtQtd
            // 
            this.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(252, 97);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(112, 32);
            this.txtQtd.TabIndex = 6;
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAddItem.Location = new System.Drawing.Point(382, 72);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(118, 55);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "ADICIONAR ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lstListaItensVenda
            // 
            this.lstListaItensVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descricao,
            this.Preco,
            this.Qtde,
            this.Total});
            this.lstListaItensVenda.HideSelection = false;
            this.lstListaItensVenda.Location = new System.Drawing.Point(12, 144);
            this.lstListaItensVenda.Name = "lstListaItensVenda";
            this.lstListaItensVenda.Size = new System.Drawing.Size(557, 294);
            this.lstListaItensVenda.TabIndex = 18;
            this.lstListaItensVenda.UseCompatibleStateImageBehavior = false;
            this.lstListaItensVenda.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "CODIGO";
            this.Codigo.Width = 66;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.BurlyWood;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 39);
            this.label10.TabIndex = 19;
            this.label10.Text = "VENDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "CÓDIGO DE BARRAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(248, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "QUANTIDADE";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(587, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "TOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Coral;
            this.lblTotal.Location = new System.Drawing.Point(587, 197);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 39);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "R$ 000,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQtdItens
            // 
            this.lblQtdItens.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdItens.ForeColor = System.Drawing.Color.Coral;
            this.lblQtdItens.Location = new System.Drawing.Point(587, 293);
            this.lblQtdItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdItens.Name = "lblQtdItens";
            this.lblQtdItens.Size = new System.Drawing.Size(200, 39);
            this.lblQtdItens.TabIndex = 25;
            this.lblQtdItens.Text = "000";
            this.lblQtdItens.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(587, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "QTD ITENS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.Coral;
            this.lblDesconto.Location = new System.Drawing.Point(587, 382);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(200, 39);
            this.lblDesconto.TabIndex = 27;
            this.lblDesconto.Text = "R$ 00,00";
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(587, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 39);
            this.label8.TabIndex = 26;
            this.label8.Text = "DESCONTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(516, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 28;
            this.button1.Text = "FINALIZAR VENDA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.BurlyWood;
            this.button2.Location = new System.Drawing.Point(649, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 55);
            this.button2.TabIndex = 29;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Sylfaen", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblID.Location = new System.Drawing.Point(146, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 39);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "0001";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQtdItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstListaItensVenda);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtCodBarras);
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListView lstListaItensVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Qtde;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQtdItens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
    }
}