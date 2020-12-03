namespace LojaRoupas
{
    partial class frmListaCompra
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
            this.lstListaCompra = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vlrtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtditens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnItensDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Blue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(678, 90);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 28);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.Blue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(678, 15);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 32);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Comprar";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstListaCompra
            // 
            this.lstListaCompra.BackColor = System.Drawing.Color.Silver;
            this.lstListaCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.data,
            this.vlrtotal,
            this.desconto,
            this.qtditens,
            this.fornecedor});
            this.lstListaCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstListaCompra.ForeColor = System.Drawing.Color.Blue;
            this.lstListaCompra.FullRowSelect = true;
            this.lstListaCompra.HideSelection = false;
            this.lstListaCompra.Location = new System.Drawing.Point(0, 0);
            this.lstListaCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstListaCompra.Name = "lstListaCompra";
            this.lstListaCompra.Size = new System.Drawing.Size(659, 554);
            this.lstListaCompra.TabIndex = 27;
            this.lstListaCompra.UseCompatibleStateImageBehavior = false;
            this.lstListaCompra.View = System.Windows.Forms.View.Details;
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
            // fornecedor
            // 
            this.fornecedor.Text = "FORNECEDOR";
            this.fornecedor.Width = 164;
            // 
            // btnItensDoc
            // 
            this.btnItensDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItensDoc.BackColor = System.Drawing.Color.Blue;
            this.btnItensDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItensDoc.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnItensDoc.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnItensDoc.Location = new System.Drawing.Point(678, 54);
            this.btnItensDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnItensDoc.Name = "btnItensDoc";
            this.btnItensDoc.Size = new System.Drawing.Size(127, 28);
            this.btnItensDoc.TabIndex = 30;
            this.btnItensDoc.Text = "Criptomoedas";
            this.btnItensDoc.UseVisualStyleBackColor = false;
            this.btnItensDoc.Click += new System.EventHandler(this.btnItensDoc_Click);
            // 
            // frmListaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.btnItensDoc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaCompra);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmListaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmListaCompra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lstListaCompra;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader vlrtotal;
        private System.Windows.Forms.ColumnHeader desconto;
        private System.Windows.Forms.ColumnHeader qtditens;
        private System.Windows.Forms.ColumnHeader fornecedor;
        private System.Windows.Forms.Button btnItensDoc;
    }
}