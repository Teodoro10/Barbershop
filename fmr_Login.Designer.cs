namespace Barbershop
{
    partial class fmr_Login
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(338, 187);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(183, 20);
            this.textEmail.TabIndex = 12;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(338, 335);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(183, 20);
            this.textSenha.TabIndex = 13;
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEmail.Location = new System.Drawing.Point(333, 121);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(188, 29);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Digite seu Email";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSenha.Location = new System.Drawing.Point(333, 258);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(195, 29);
            this.lbSenha.TabIndex = 15;
            this.lbSenha.Text = "Digite sua Senha";
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.White;
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.ForeColor = System.Drawing.Color.Black;
            this.btEntrar.Location = new System.Drawing.Point(720, 419);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(88, 30);
            this.btEntrar.TabIndex = 16;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // fmr_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barbershop.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 473);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textEmail);
            this.Name = "fmr_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmr_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btEntrar;
    }
}