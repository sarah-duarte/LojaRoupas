namespace LojaRoupas
{
    partial class frmListaVenda
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lstListaVenda = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vlrtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtditens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnItensDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(644, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 55);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(644, 34);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 55);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "REALIZAR VENDA";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstListaVenda
            // 
            this.lstListaVenda.BackColor = System.Drawing.Color.Black;
            this.lstListaVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.data,
            this.vlrtotal,
            this.desconto,
            this.qtditens,
            this.cliente,
            this.operador});
            this.lstListaVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaVenda.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaVenda.HideSelection = false;
            this.lstListaVenda.Location = new System.Drawing.Point(0, 0);
            this.lstListaVenda.Name = "lstListaVenda";
            this.lstListaVenda.Size = new System.Drawing.Size(765, 450);
            this.lstListaVenda.TabIndex = 24;
            this.lstListaVenda.UseCompatibleStateImageBehavior = false;
            this.lstListaVenda.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 76;
            // 
            // vlrtotal
            // 
            this.vlrtotal.Text = "Valor Total";
            this.vlrtotal.Width = 87;
            // 
            // desconto
            // 
            this.desconto.Text = "Desconto";
            this.desconto.Width = 84;
            // 
            // qtditens
            // 
            this.qtditens.Text = "Qtd Itens";
            this.qtditens.Width = 74;
            // 
            // cliente
            // 
            this.cliente.Text = "Cliente";
            this.cliente.Width = 141;
            // 
            // operador
            // 
            this.operador.Text = "Operador";
            this.operador.Width = 125;
            // 
            // btnItensDoc
            // 
            this.btnItensDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItensDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensDoc.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnItensDoc.Location = new System.Drawing.Point(644, 95);
            this.btnItensDoc.Name = "btnItensDoc";
            this.btnItensDoc.Size = new System.Drawing.Size(109, 55);
            this.btnItensDoc.TabIndex = 27;
            this.btnItensDoc.Text = "ITENS DA VENDA";
            this.btnItensDoc.UseVisualStyleBackColor = true;
            this.btnItensDoc.Click += new System.EventHandler(this.btnItensDoc_Click);
            // 
            // frmListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnItensDoc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaVenda);
            this.Name = "frmListaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmListaVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lstListaVenda;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader vlrtotal;
        private System.Windows.Forms.ColumnHeader desconto;
        private System.Windows.Forms.ColumnHeader qtditens;
        private System.Windows.Forms.ColumnHeader cliente;
        private System.Windows.Forms.ColumnHeader operador;
        private System.Windows.Forms.Button btnItensDoc;
    }
}