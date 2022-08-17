namespace Barbershop
{
    partial class fmr_Menu
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
            this.Produtos = new System.Windows.Forms.Button();
            this.Agenda = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Produtos
            // 
            this.Produtos.BackColor = System.Drawing.Color.White;
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produtos.Location = new System.Drawing.Point(92, 246);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(95, 30);
            this.Produtos.TabIndex = 15;
            this.Produtos.Text = "Produtos";
            this.Produtos.UseVisualStyleBackColor = false;
            this.Produtos.Click += new System.EventHandler(this.Produtos_Click);
            // 
            // Agenda
            // 
            this.Agenda.BackColor = System.Drawing.Color.White;
            this.Agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agenda.Location = new System.Drawing.Point(92, 167);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(95, 30);
            this.Agenda.TabIndex = 16;
            this.Agenda.Text = "Agenda";
            this.Agenda.UseVisualStyleBackColor = false;
            this.Agenda.Click += new System.EventHandler(this.Agenda_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.Color.White;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(92, 84);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(95, 30);
            this.Cadastro.TabIndex = 17;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = false;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.White;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(24, 425);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(95, 30);
            this.Sair.TabIndex = 18;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // fmr_Menu
            // 
            this.BackgroundImage = global::Barbershop.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 467);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.Produtos);
            this.Name = "fmr_Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Produtos;
        private System.Windows.Forms.Button Agenda;
        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Button Sair;
    }
}