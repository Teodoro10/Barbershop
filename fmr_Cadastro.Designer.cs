namespace Barbershop
{
    partial class fmr_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.btmenu = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btver2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(56, 196);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(110, 29);
            this.lbTelefone.TabIndex = 3;
            this.lbTelefone.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(678, 383);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 30);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(184, 205);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 7;
            this.textNome.TextChanged += new System.EventHandler(this.textTelefone_TextChanged);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(184, 105);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 20);
            this.textTelefone.TabIndex = 8;
            this.textTelefone.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(184, 158);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(100, 20);
            this.textCPF.TabIndex = 9;
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.White;
            this.btmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(43, 383);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(95, 30);
            this.btmenu.TabIndex = 10;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(184, 257);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Código";
            // 
            // dataTable
            // 
            this.dataTable.BackgroundColor = System.Drawing.Color.White;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(371, 96);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(402, 169);
            this.dataTable.TabIndex = 13;
            // 
            // btver2
            // 
            this.btver2.BackColor = System.Drawing.Color.White;
            this.btver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btver2.Location = new System.Drawing.Point(526, 293);
            this.btver2.Name = "btver2";
            this.btver2.Size = new System.Drawing.Size(95, 30);
            this.btver2.TabIndex = 14;
            this.btver2.Text = "Consultar";
            this.btver2.UseVisualStyleBackColor = false;
            this.btver2.Click += new System.EventHandler(this.btver2_Click);
            // 
            // fmr_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barbershop.Properties.Resources.FOTO;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btver2);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTelefone);
            this.Name = "fmr_Cadastro";
            this.Text = "Cadastro do cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btver2;
    }
}

