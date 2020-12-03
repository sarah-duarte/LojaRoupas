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
            this.btnCancelar.BackColor = System.Drawing.Color.Blue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Peru;
            this.btnCancelar.Location = new System.Drawing.Point(644, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 28);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.Blue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Peru;
            this.btnNovo.Location = new System.Drawing.Point(644, 24);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 28);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Realizar Venda";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstListaVenda
            // 
            this.lstListaVenda.BackColor = System.Drawing.Color.Silver;
            this.lstListaVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.data,
            this.vlrtotal,
            this.desconto,
            this.qtditens,
            this.cliente,
            this.operador});
            this.lstListaVenda.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaVenda.ForeColor = System.Drawing.Color.Blue;
            this.lstListaVenda.FullRowSelect = true;
            this.lstListaVenda.HideSelection = false;
            this.lstListaVenda.Location = new System.Drawing.Point(0, 0);
            this.lstListaVenda.Name = "lstListaVenda";
            this.lstListaVenda.Size = new System.Drawing.Size(627, 450);
            this.lstListaVenda.TabIndex = 24;
            this.lstListaVenda.UseCompatibleStateImageBehavior = false;
            this.lstListaVenda.View = System.Windows.Forms.View.Details;
            this.lstListaVenda.SelectedIndexChanged += new System.EventHandler(this.lstListaVenda_SelectedIndexChanged);
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
            this.btnItensDoc.BackColor = System.Drawing.Color.Blue;
            this.btnItensDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensDoc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItensDoc.ForeColor = System.Drawing.Color.Peru;
            this.btnItensDoc.Location = new System.Drawing.Point(644, 58);
            this.btnItensDoc.Name = "btnItensDoc";
            this.btnItensDoc.Size = new System.Drawing.Size(109, 28);
            this.btnItensDoc.TabIndex = 27;
            this.btnItensDoc.Text = "Itens da Venda";
            this.btnItensDoc.UseVisualStyleBackColor = false;
            this.btnItensDoc.Click += new System.EventHandler(this.btnItensDoc_Click);
            // 
            // frmListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnItensDoc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaVenda);
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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