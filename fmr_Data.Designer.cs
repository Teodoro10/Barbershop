namespace Barbershop
{
    partial class fmr_Data
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
            this.textDIa = new System.Windows.Forms.MaskedTextBox();
            this.textHorario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btMarcar = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btver = new System.Windows.Forms.Button();
            this.btmenu = new System.Windows.Forms.Button();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.MaskedTextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // textDIa
            // 
            this.textDIa.Location = new System.Drawing.Point(167, 145);
            this.textDIa.Name = "textDIa";
            this.textDIa.Size = new System.Drawing.Size(100, 20);
            this.textDIa.TabIndex = 0;
            this.textDIa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textDIa_MaskInputRejected);
            // 
            // textHorario
            // 
            this.textHorario.Location = new System.Drawing.Point(167, 80);
            this.textHorario.Multiline = true;
            this.textHorario.Name = "textHorario";
            this.textHorario.Size = new System.Drawing.Size(100, 20);
            this.textHorario.TabIndex = 1;
            this.textHorario.TextChanged += new System.EventHandler(this.textHorario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dia";
            // 
            // textMes
            // 
            this.textMes.Location = new System.Drawing.Point(167, 203);
            this.textMes.Name = "textMes";
            this.textMes.Size = new System.Drawing.Size(100, 20);
            this.textMes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(63, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mês";
            // 
            // btMarcar
            // 
            this.btMarcar.BackColor = System.Drawing.Color.White;
            this.btMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcar.ForeColor = System.Drawing.Color.Black;
            this.btMarcar.Location = new System.Drawing.Point(182, 359);
            this.btMarcar.Name = "btMarcar";
            this.btMarcar.Size = new System.Drawing.Size(85, 42);
            this.btMarcar.TabIndex = 8;
            this.btMarcar.Text = "Marcar";
            this.btMarcar.UseVisualStyleBackColor = false;
            this.btMarcar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataTable
            // 
            this.dataTable.BackgroundColor = System.Drawing.Color.White;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(389, 40);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(421, 169);
            this.dataTable.TabIndex = 9;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // btver
            // 
            this.btver.BackColor = System.Drawing.Color.White;
            this.btver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btver.Location = new System.Drawing.Point(432, 243);
            this.btver.Name = "btver";
            this.btver.Size = new System.Drawing.Size(164, 42);
            this.btver.TabIndex = 10;
            this.btver.Text = "Consultar Horarios";
            this.btver.UseVisualStyleBackColor = false;
            this.btver.Click += new System.EventHandler(this.btver_Click);
            // 
            // btmenu
            // 
            this.btmenu.BackColor = System.Drawing.Color.White;
            this.btmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenu.Location = new System.Drawing.Point(33, 412);
            this.btmenu.Name = "btmenu";
            this.btmenu.Size = new System.Drawing.Size(95, 30);
            this.btmenu.TabIndex = 12;
            this.btmenu.Text = "Menu";
            this.btmenu.UseVisualStyleBackColor = false;
            this.btmenu.Click += new System.EventHandler(this.btmenu_Click);
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbcodigo.Location = new System.Drawing.Point(28, 253);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(100, 31);
            this.lbcodigo.TabIndex = 13;
            this.lbcodigo.Text = "Código";
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(167, 265);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(100, 20);
            this.textcodigo.TabIndex = 14;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.White;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExcluir.Location = new System.Drawing.Point(700, 240);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 45);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluit_Click);
            // 
            // fmr_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barbershop.Properties.Resources.DuAs_CADEIras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 467);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.btmenu);
            this.Controls.Add(this.btver);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.btMarcar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHorario);
            this.Controls.Add(this.textDIa);
            this.Name = "fmr_Data";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.fmr_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textDIa;
        private System.Windows.Forms.TextBox textHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMarcar;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btver;
        private System.Windows.Forms.Button btmenu;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.MaskedTextBox textcodigo;
        private System.Windows.Forms.Button btExcluir;
    }
}