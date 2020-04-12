namespace LojaRoupas
{
    partial class frmlistaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistaCliente));
            this.lstListaCliente = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comprasrealizada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaCliente
            // 
            this.lstListaCliente.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstListaCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.telefone,
            this.nascimento,
            this.endereco,
            this.comprasrealizada});
            this.lstListaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaCliente.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaCliente.HideSelection = false;
            this.lstListaCliente.Location = new System.Drawing.Point(0, 0);
            this.lstListaCliente.Name = "lstListaCliente";
            this.lstListaCliente.Size = new System.Drawing.Size(956, 450);
            this.lstListaCliente.TabIndex = 0;
            this.lstListaCliente.UseCompatibleStateImageBehavior = false;
            this.lstListaCliente.View = System.Windows.Forms.View.Details;
            this.lstListaCliente.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 42;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 148;
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.Width = 63;
            // 
            // email
            // 
            this.email.Text = "EMAIL";
            this.email.Width = 126;
            // 
            // telefone
            // 
            this.telefone.Text = "TELEFONE";
            this.telefone.Width = 119;
            // 
            // nascimento
            // 
            this.nascimento.Text = "NASCIMENTO";
            this.nascimento.Width = 117;
            // 
            // endereco
            // 
            this.endereco.Text = "ENDEREÇO";
            this.endereco.Width = 156;
            // 
            // comprasrealizada
            // 
            this.comprasrealizada.Text = "COMPRAS REALIZADAS";
            this.comprasrealizada.Width = 375;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.Location = new System.Drawing.Point(826, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 55);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(826, 36);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 55);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "NOVO ITEM";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualiza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAtualiza.Location = new System.Drawing.Point(826, 158);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(118, 55);
            this.btnAtualiza.TabIndex = 24;
            this.btnAtualiza.Text = "ATUALIZA";
            this.btnAtualiza.UseVisualStyleBackColor = false;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // frmlistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlistaCliente";
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.frmlistaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstListaCliente;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader nascimento;
        private System.Windows.Forms.ColumnHeader endereco;
        private System.Windows.Forms.ColumnHeader comprasrealizada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualiza;
    }
}