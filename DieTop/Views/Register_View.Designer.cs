
namespace Register_View
{
    partial class Register_View
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
            System.Windows.Forms.GroupBox sexoGroup;
            this.radioFemea = new System.Windows.Forms.RadioButton();
            this.radioMacho = new System.Windows.Forms.RadioButton();
            this.labelNome = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.labelIdade = new System.Windows.Forms.Label();
            this.inputIdade = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.inputPeso = new System.Windows.Forms.TextBox();
            this.inputAltura = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.inputConfirmarSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            sexoGroup = new System.Windows.Forms.GroupBox();
            sexoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sexoGroup
            // 
            sexoGroup.BackColor = System.Drawing.Color.Transparent;
            sexoGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            sexoGroup.CausesValidation = false;
            sexoGroup.Controls.Add(this.radioFemea);
            sexoGroup.Controls.Add(this.radioMacho);
            sexoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            sexoGroup.ForeColor = System.Drawing.Color.Black;
            sexoGroup.Location = new System.Drawing.Point(172, 207);
            sexoGroup.Name = "sexoGroup";
            sexoGroup.Size = new System.Drawing.Size(229, 31);
            sexoGroup.TabIndex = 10;
            sexoGroup.TabStop = false;
            // 
            // radioFemea
            // 
            this.radioFemea.AutoSize = true;
            this.radioFemea.Checked = true;
            this.radioFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemea.Location = new System.Drawing.Point(114, 7);
            this.radioFemea.Name = "radioFemea";
            this.radioFemea.Size = new System.Drawing.Size(92, 24);
            this.radioFemea.TabIndex = 1;
            this.radioFemea.TabStop = true;
            this.radioFemea.Text = "Feminino";
            this.radioFemea.UseVisualStyleBackColor = true;
            // 
            // radioMacho
            // 
            this.radioMacho.AutoSize = true;
            this.radioMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMacho.Location = new System.Drawing.Point(7, 7);
            this.radioMacho.Name = "radioMacho";
            this.radioMacho.Size = new System.Drawing.Size(98, 24);
            this.radioMacho.TabIndex = 0;
            this.radioMacho.Text = "Masculino";
            this.radioMacho.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNome.Location = new System.Drawing.Point(54, 69);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(101, 31);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome :";
            // 
            // inputNome
            // 
            this.inputNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNome.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.ForeColor = System.Drawing.Color.Silver;
            this.inputNome.Location = new System.Drawing.Point(172, 69);
            this.inputNome.Multiline = true;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(229, 31);
            this.inputNome.TabIndex = 6;
            this.inputNome.Tag = "";
            this.inputNome.Text = "Insira seu Nome";
            this.inputNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNome.WordWrap = false;
            this.inputNome.Click += new System.EventHandler(this.onClickNome);
            this.inputNome.Leave += new System.EventHandler(this.leaveNome);
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.BackColor = System.Drawing.Color.Transparent;
            this.labelIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdade.Location = new System.Drawing.Point(54, 137);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(97, 31);
            this.labelIdade.TabIndex = 7;
            this.labelIdade.Text = "Idade :";
            // 
            // inputIdade
            // 
            this.inputIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputIdade.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIdade.ForeColor = System.Drawing.Color.Silver;
            this.inputIdade.Location = new System.Drawing.Point(172, 138);
            this.inputIdade.Multiline = true;
            this.inputIdade.Name = "inputIdade";
            this.inputIdade.Size = new System.Drawing.Size(229, 31);
            this.inputIdade.TabIndex = 8;
            this.inputIdade.Tag = "";
            this.inputIdade.Text = "Insira sua Idade";
            this.inputIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputIdade.WordWrap = false;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.Transparent;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSexo.Location = new System.Drawing.Point(54, 207);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(97, 31);
            this.labelSexo.TabIndex = 9;
            this.labelSexo.Text = "Sexo  :";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPeso.Location = new System.Drawing.Point(54, 279);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(91, 31);
            this.labelPeso.TabIndex = 11;
            this.labelPeso.Text = "Peso :";
            // 
            // inputPeso
            // 
            this.inputPeso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPeso.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPeso.ForeColor = System.Drawing.Color.Silver;
            this.inputPeso.Location = new System.Drawing.Point(179, 280);
            this.inputPeso.Multiline = true;
            this.inputPeso.Name = "inputPeso";
            this.inputPeso.Size = new System.Drawing.Size(229, 31);
            this.inputPeso.TabIndex = 12;
            this.inputPeso.Tag = "";
            this.inputPeso.Text = "Insira seu Peso";
            this.inputPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPeso.WordWrap = false;
            // 
            // inputAltura
            // 
            this.inputAltura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAltura.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAltura.ForeColor = System.Drawing.Color.Silver;
            this.inputAltura.Location = new System.Drawing.Point(179, 345);
            this.inputAltura.Multiline = true;
            this.inputAltura.Name = "inputAltura";
            this.inputAltura.Size = new System.Drawing.Size(229, 31);
            this.inputAltura.TabIndex = 14;
            this.inputAltura.Tag = "";
            this.inputAltura.Text = "Insira sua Altura";
            this.inputAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputAltura.WordWrap = false;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.BackColor = System.Drawing.Color.Transparent;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAltura.Location = new System.Drawing.Point(54, 345);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(100, 31);
            this.labelAltura.TabIndex = 13;
            this.labelAltura.Text = "Altura :";
            // 
            // inputConfirmarSenha
            // 
            this.inputConfirmarSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputConfirmarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputConfirmarSenha.ForeColor = System.Drawing.Color.Silver;
            this.inputConfirmarSenha.Location = new System.Drawing.Point(682, 134);
            this.inputConfirmarSenha.Multiline = true;
            this.inputConfirmarSenha.Name = "inputConfirmarSenha";
            this.inputConfirmarSenha.Size = new System.Drawing.Size(229, 31);
            this.inputConfirmarSenha.TabIndex = 18;
            this.inputConfirmarSenha.Tag = "";
            this.inputConfirmarSenha.Text = "Confirme sua Senha";
            this.inputConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputConfirmarSenha.WordWrap = false;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConfirmarSenha.Location = new System.Drawing.Point(471, 136);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(205, 29);
            this.labelConfirmarSenha.TabIndex = 17;
            this.labelConfirmarSenha.Text = "Confirmar Senha :";
            // 
            // inputSenha
            // 
            this.inputSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSenha.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSenha.ForeColor = System.Drawing.Color.Silver;
            this.inputSenha.Location = new System.Drawing.Point(682, 69);
            this.inputSenha.Multiline = true;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(229, 31);
            this.inputSenha.TabIndex = 16;
            this.inputSenha.Tag = "";
            this.inputSenha.Text = "Insira sua  Senha";
            this.inputSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSenha.WordWrap = false;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSenha.Location = new System.Drawing.Point(557, 68);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(107, 31);
            this.labelSenha.TabIndex = 15;
            this.labelSenha.Text = "Senha :";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelar.Location = new System.Drawing.Point(519, 490);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(181, 47);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.handleCancelSubmit);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmar.Location = new System.Drawing.Point(745, 490);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(181, 47);
            this.buttonConfirmar.TabIndex = 20;
            this.buttonConfirmar.Text = "Cofirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.handleFormSubmit);
            // 
            // Register_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.inputConfirmarSenha);
            this.Controls.Add(this.labelConfirmarSenha);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.inputAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.inputPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(sexoGroup);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.inputIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.labelNome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Register_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            sexoGroup.ResumeLayout(false);
            sexoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox inputIdade;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioFemea;
        private System.Windows.Forms.RadioButton radioMacho;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox inputPeso;
        private System.Windows.Forms.TextBox inputAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox inputConfirmarSenha;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}