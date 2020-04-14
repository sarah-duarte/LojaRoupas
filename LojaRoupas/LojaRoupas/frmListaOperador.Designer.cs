namespace LojaRoupas
{
    partial class frmListaOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaOperador));
            this.lstListaOperador = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaOperador
            // 
            this.lstListaOperador.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstListaOperador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.cpf,
            this.email,
            this.telefone,
            this.nascimento,
            this.endereco,
            this.turno});
            this.lstListaOperador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaOperador.ForeColor = System.Drawing.Color.BurlyWood;
            this.lstListaOperador.HideSelection = false;
            this.lstListaOperador.Location = new System.Drawing.Point(0, 0);
            this.lstListaOperador.Name = "lstListaOperador";
            this.lstListaOperador.Size = new System.Drawing.Size(800, 450);
            this.lstListaOperador.TabIndex = 0;
            this.lstListaOperador.UseCompatibleStateImageBehavior = false;
            this.lstListaOperador.View = System.Windows.Forms.View.Details;
            this.lstListaOperador.SelectedIndexChanged += new System.EventHandler(this.lstListaOperador_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            // 
            // cpf
            // 
            this.cpf.Text = "Cpf";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            // 
            // nascimento
            // 
            this.nascimento.Text = "Nascimento";
            // 
            // endereco
            // 
            this.endereco.Text = "Endereço";
            // 
            // turno
            // 
            this.turno.Text = "Turno";
            this.turno.Width = 175;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnNovo.Location = new System.Drawing.Point(670, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 55);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "NOVO ";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmListaOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstListaOperador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaOperador";
            this.Text = "Lista de Operadores";
            this.Load += new System.EventHandler(this.frmListaOperador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstListaOperador;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader nascimento;
        private System.Windows.Forms.ColumnHeader endereco;
        private System.Windows.Forms.ColumnHeader turno;
        private System.Windows.Forms.Button btnNovo;
    }
}