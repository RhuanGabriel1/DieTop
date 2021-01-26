
namespace DieTop
{
    partial class Welcome_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_View));
            this.welcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Cursor = System.Windows.Forms.Cursors.Default;
            this.welcomeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft PhagsPa", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeText.Location = new System.Drawing.Point(201, 48);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(552, 49);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Sejam Bem-Vindos ao DieTop!";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(277, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça o Login para Continuar!";
            // 
            // inputLogin
            // 
            this.inputLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLogin.ForeColor = System.Drawing.Color.Silver;
            this.inputLogin.Location = new System.Drawing.Point(236, 223);
            this.inputLogin.Multiline = true;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(433, 31);
            this.inputLogin.TabIndex = 2;
            this.inputLogin.Tag = "";
            this.inputLogin.Text = "Insira seu Login";
            this.inputLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputLogin.WordWrap = false;
            this.inputLogin.Enter += new System.EventHandler(this.InputLogin_Enter);
            this.inputLogin.Leave += new System.EventHandler(this.InputLogin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(150, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(141, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // inputSenha
            // 
            this.inputSenha.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSenha.ForeColor = System.Drawing.Color.Silver;
            this.inputSenha.Location = new System.Drawing.Point(236, 303);
            this.inputSenha.Multiline = true;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(433, 31);
            this.inputSenha.TabIndex = 6;
            this.inputSenha.Tag = "";
            this.inputSenha.Text = "Insira sua Senha";
            this.inputSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSenha.WordWrap = false;
            this.inputSenha.Enter += new System.EventHandler(this.InputSenha_enter);
            this.inputSenha.Leave += new System.EventHandler(this.InputSenha_leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Window;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(310, 374);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(252, 47);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Logar";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newRegister
            // 
            this.newRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newRegister.AutoSize = true;
            this.newRegister.BackColor = System.Drawing.Color.Transparent;
            this.newRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRegister.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRegister.LinkColor = System.Drawing.Color.Black;
            this.newRegister.Location = new System.Drawing.Point(290, 451);
            this.newRegister.Name = "newRegister";
            this.newRegister.Size = new System.Drawing.Size(296, 28);
            this.newRegister.TabIndex = 8;
            this.newRegister.TabStop = true;
            this.newRegister.Text = "Ainda não tenho Cadastro!";
            this.newRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadRegisterScreen);
            // 
            // Welcome_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.newRegister);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Welcome_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die Top Program!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel newRegister;
    }
}

