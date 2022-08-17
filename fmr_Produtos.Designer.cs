namespace Barbershop
{
    partial class fmr_Produtos
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
            this.lbNome = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.lbmarca = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btver = new System.Windows.Forms.Button();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textvalidade = new System.Windows.Forms.TextBox();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.textmarca = new System.Windows.Forms.TextBox();
            this.btmenu = new System.Windows.Forms.Button();
            this.lbquantidade = new System.Windows.Forms.Label();
            this.textquantidade = new System.Windows.Forms.TextBox();
            this.btexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNome.Location = new System.Drawing.Point(12, 53);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(178, 24);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome dos Produtos";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.BackColor = System.Drawing.Color.Transparent;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.ForeColor = System.Drawing.Color.White;
            this.codigo.Location = new System.Drawing.Point(119, 98);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(71, 24);
            this.codigo.TabIndex = 1;
            this.codigo.Text = "Codigo";
            // 
            // lbmarca
            // 
            this.lbmarca.AutoSize = true;
            this.lbmarca.BackColor = System.Drawing.Color.Transparent;
            this.lbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmarca.ForeColor = System.Drawing.Color.White;
            this.lbmarca.Location = new System.Drawing.Point(128, 141);
            this.lbmarca.Name = "lbmarca";
            this.lbmarca.Size = new System.Drawing.Size(62, 24);
            this.lbmarca.TabIndex = 2;
            this.lbmarca.Text = "Marca";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(106, 186);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 24);
            this.lb.TabIndex = 3;
            this.lb.Text = "Validade";
            // 
            // dataTable
            // 
            this.dataTable.BackgroundColor = System.Drawing.Color.White;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(411, 58);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(383, 152);
            this.dataTable.TabIndex = 8;
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.White;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.Black;
            this.btcadastrar.Location = new System.Drawing.Point(250, 344);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(101, 36);
            this.btcadastrar.TabIndex = 9;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btver
            // 
            this.btver.BackColor = System.Drawing.Color.White;
            this.btver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btver.ForeColor = System.Drawing.Color.Black;
            this.btver.Location = new System.Drawing.Point(411, 241);
            this.btver.Name = "btver";
            this.btver.Size = new System.Drawing.Size(198, 39);
            this.btver.TabIndex = 10;
            this.btver.Text = "Consultar produtos";
            this.btver.UseVisualStyleBackColor = false;
            this.btver.Click += new System.EventHandler(this.btver_Click);
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(250, 58);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(100, 20);
            this.textnome.TabIndex = 11;
            this.textnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // textvalidade
            // 
            this.textvalidade.Location = new System.Drawing.Point(250, 191);
            this.textvalidade.Name = "textvalidade";
            this.textvalidade.Size = new System.Drawing.Size(100, 20);
            this.textvalidade.TabIndex = 12;
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(250, 103);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(100, 20);
            this.textcodigo.TabIndex = 12;
            this.textcodigo.TextChanged += new System.EventHandler(this.textcodigo_TextChanged);
            // 
            // textmarca
            // 
            this.textmarca.Location = new System.Drawing.Point(250, 146);
            this.textmarca.Name = "textmarca";
            this.textmarca.Size = new System.Drawing.Size(100, 20);
            this.textmarca.TabIndex = 13;
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.White;
            this.btmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.ForeColor = System.Drawing.Color.Black;
            this.btmenu.Location = new System.Drawing.Point(39, 408);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(88, 30);
            this.btmenu.TabIndex = 14;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btsair_Click);
            // 
            // lbquantidade
            // 
            this.lbquantidade.AutoSize = true;
            this.lbquantidade.BackColor = System.Drawing.Color.Transparent;
            this.lbquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquantidade.ForeColor = System.Drawing.Color.White;
            this.lbquantidade.Location = new System.Drawing.Point(106, 236);
            this.lbquantidade.Name = "lbquantidade";
            this.lbquantidade.Size = new System.Drawing.Size(108, 24);
            this.lbquantidade.TabIndex = 15;
            this.lbquantidade.Text = "Quantidade";
            // 
            // textquantidade
            // 
            this.textquantidade.Location = new System.Drawing.Point(250, 241);
            this.textquantidade.Name = "textquantidade";
            this.textquantidade.Size = new System.Drawing.Size(100, 20);
            this.textquantidade.TabIndex = 16;
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.White;
            this.btexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.Black;
            this.btexcluir.Location = new System.Drawing.Point(674, 241);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(120, 39);
            this.btexcluir.TabIndex = 17;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // fmr_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barbershop.Properties.Resources.Produtos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 463);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.textquantidade);
            this.Controls.Add(this.lbquantidade);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.textmarca);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.textvalidade);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.btver);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbmarca);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.lbNome);
            this.Name = "fmr_Produtos";
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label lbmarca;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btver;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textvalidade;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textmarca;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.Label lbquantidade;
        private System.Windows.Forms.TextBox textquantidade;
        private System.Windows.Forms.Button btexcluir;
    }
}