
namespace DieTop.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.user = new System.Windows.Forms.Panel();
            this.ButtonAceitar = new System.Windows.Forms.Button();
            this.ButtonAlterar = new System.Windows.Forms.Button();
            this.ButtonVoltar = new System.Windows.Forms.Button();
            this.inputPeso = new System.Windows.Forms.TextBox();
            this.inputAltura = new System.Windows.Forms.TextBox();
            this.inputSexo = new System.Windows.Forms.TextBox();
            this.inputIdade = new System.Windows.Forms.TextBox();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectDieta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectAtvFisica = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonRefeicao = new System.Windows.Forms.Button();
            this.ButtonFinalizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Controls.Add(this.ButtonAceitar);
            this.user.Controls.Add(this.ButtonAlterar);
            this.user.Controls.Add(this.ButtonVoltar);
            this.user.Controls.Add(this.inputPeso);
            this.user.Controls.Add(this.inputAltura);
            this.user.Controls.Add(this.inputSexo);
            this.user.Controls.Add(this.inputIdade);
            this.user.Controls.Add(this.inputCPF);
            this.user.Controls.Add(this.inputNome);
            this.user.Controls.Add(this.label6);
            this.user.Controls.Add(this.label5);
            this.user.Controls.Add(this.label4);
            this.user.Controls.Add(this.label3);
            this.user.Controls.Add(this.label2);
            this.user.Controls.Add(this.label1);
            this.user.Controls.Add(this.labelUserInformation);
            this.user.Location = new System.Drawing.Point(22, 21);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(424, 531);
            this.user.TabIndex = 0;
            // 
            // ButtonAceitar
            // 
            this.ButtonAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonAceitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAceitar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAceitar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonAceitar.Location = new System.Drawing.Point(233, 461);
            this.ButtonAceitar.Name = "ButtonAceitar";
            this.ButtonAceitar.Size = new System.Drawing.Size(144, 47);
            this.ButtonAceitar.TabIndex = 33;
            this.ButtonAceitar.Text = "Aceitar";
            this.ButtonAceitar.UseVisualStyleBackColor = false;
            this.ButtonAceitar.Visible = false;
            this.ButtonAceitar.Click += new System.EventHandler(this.ButtonAceitar_Click);
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAlterar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonAlterar.Location = new System.Drawing.Point(146, 461);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(159, 42);
            this.ButtonAlterar.TabIndex = 14;
            this.ButtonAlterar.Text = "Alterar";
            this.ButtonAlterar.UseVisualStyleBackColor = false;
            this.ButtonAlterar.Click += new System.EventHandler(this.ButtonAlterar_Click);
            // 
            // ButtonVoltar
            // 
            this.ButtonVoltar.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVoltar.Location = new System.Drawing.Point(68, 459);
            this.ButtonVoltar.Name = "ButtonVoltar";
            this.ButtonVoltar.Size = new System.Drawing.Size(144, 47);
            this.ButtonVoltar.TabIndex = 32;
            this.ButtonVoltar.Text = "Voltar";
            this.ButtonVoltar.UseVisualStyleBackColor = false;
            this.ButtonVoltar.Visible = false;
            this.ButtonVoltar.Click += new System.EventHandler(this.ButtonVoltar_Click);
            // 
            // inputPeso
            // 
            this.inputPeso.Enabled = false;
            this.inputPeso.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPeso.Location = new System.Drawing.Point(127, 403);
            this.inputPeso.Multiline = true;
            this.inputPeso.Name = "inputPeso";
            this.inputPeso.Size = new System.Drawing.Size(270, 25);
            this.inputPeso.TabIndex = 12;
            // 
            // inputAltura
            // 
            this.inputAltura.Enabled = false;
            this.inputAltura.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAltura.Location = new System.Drawing.Point(127, 343);
            this.inputAltura.Multiline = true;
            this.inputAltura.Name = "inputAltura";
            this.inputAltura.Size = new System.Drawing.Size(270, 25);
            this.inputAltura.TabIndex = 11;
            // 
            // inputSexo
            // 
            this.inputSexo.Enabled = false;
            this.inputSexo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSexo.Location = new System.Drawing.Point(127, 288);
            this.inputSexo.Multiline = true;
            this.inputSexo.Name = "inputSexo";
            this.inputSexo.Size = new System.Drawing.Size(270, 25);
            this.inputSexo.TabIndex = 10;
            // 
            // inputIdade
            // 
            this.inputIdade.Enabled = false;
            this.inputIdade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIdade.Location = new System.Drawing.Point(127, 229);
            this.inputIdade.Multiline = true;
            this.inputIdade.Name = "inputIdade";
            this.inputIdade.Size = new System.Drawing.Size(270, 25);
            this.inputIdade.TabIndex = 9;
            // 
            // inputCPF
            // 
            this.inputCPF.Enabled = false;
            this.inputCPF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCPF.Location = new System.Drawing.Point(127, 173);
            this.inputCPF.Multiline = true;
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(270, 25);
            this.inputCPF.TabIndex = 8;
            // 
            // inputNome
            // 
            this.inputNome.Enabled = false;
            this.inputNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNome.Location = new System.Drawing.Point(127, 115);
            this.inputNome.Multiline = true;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(270, 25);
            this.inputNome.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Altura :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // labelUserInformation
            // 
            this.labelUserInformation.AutoSize = true;
            this.labelUserInformation.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInformation.Location = new System.Drawing.Point(15, 23);
            this.labelUserInformation.Name = "labelUserInformation";
            this.labelUserInformation.Size = new System.Drawing.Size(197, 28);
            this.labelUserInformation.TabIndex = 0;
            this.labelUserInformation.Text = "Segue Seus Dados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.selectDieta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.selectAtvFisica);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(452, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 398);
            this.panel1.TabIndex = 13;
            // 
            // selectDieta
            // 
            this.selectDieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDieta.Enabled = false;
            this.selectDieta.FormattingEnabled = true;
            this.selectDieta.Items.AddRange(new object[] {
            "GANHAR PESO",
            "MANTER PESO",
            "PERDER PESO"});
            this.selectDieta.Location = new System.Drawing.Point(83, 142);
            this.selectDieta.Name = "selectDieta";
            this.selectDieta.Size = new System.Drawing.Size(361, 21);
            this.selectDieta.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Dieta Escolhida :";
            // 
            // selectAtvFisica
            // 
            this.selectAtvFisica.BackColor = System.Drawing.SystemColors.Window;
            this.selectAtvFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAtvFisica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAtvFisica.Enabled = false;
            this.selectAtvFisica.FormattingEnabled = true;
            this.selectAtvFisica.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.selectAtvFisica.Items.AddRange(new object[] {
            "NÃO PRATICO ATV FÍSICA",
            "1 A 3 VEZES POR SEMANA",
            "3 A 7 VEZES POR SEMANA",
            "7+ VEZES POR SEMANA"});
            this.selectAtvFisica.Location = new System.Drawing.Point(83, 65);
            this.selectAtvFisica.Name = "selectAtvFisica";
            this.selectAtvFisica.Size = new System.Drawing.Size(361, 21);
            this.selectAtvFisica.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(33, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(427, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Qtd. de Atv. Fís. Práticadas na Semana";
            // 
            // ButtonRefeicao
            // 
            this.ButtonRefeicao.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonRefeicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRefeicao.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefeicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonRefeicao.Location = new System.Drawing.Point(522, 439);
            this.ButtonRefeicao.Name = "ButtonRefeicao";
            this.ButtonRefeicao.Size = new System.Drawing.Size(422, 47);
            this.ButtonRefeicao.TabIndex = 30;
            this.ButtonRefeicao.Text = "Adicionar Refeição";
            this.ButtonRefeicao.UseVisualStyleBackColor = false;
            this.ButtonRefeicao.Click += new System.EventHandler(this.ButtonRefeicao_Click);
            // 
            // ButtonFinalizar
            // 
            this.ButtonFinalizar.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFinalizar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinalizar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonFinalizar.Location = new System.Drawing.Point(711, 505);
            this.ButtonFinalizar.Name = "ButtonFinalizar";
            this.ButtonFinalizar.Size = new System.Drawing.Size(233, 47);
            this.ButtonFinalizar.TabIndex = 34;
            this.ButtonFinalizar.Text = "Finalizar Dia";
            this.ButtonFinalizar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(33, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Atv Física Realizada no Dia :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "NADA",
            "MUSCULAÇÃO",
            "CARDIO"});
            this.comboBox1.Location = new System.Drawing.Point(83, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(33, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Duração (em minutos)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 25);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "60";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.ButtonFinalizar);
            this.Controls.Add(this.ButtonRefeicao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel user;
        private System.Windows.Forms.Label labelUserInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPeso;
        private System.Windows.Forms.TextBox inputAltura;
        private System.Windows.Forms.TextBox inputSexo;
        private System.Windows.Forms.TextBox inputIdade;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonAlterar;
        private System.Windows.Forms.ComboBox selectDieta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectAtvFisica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonRefeicao;
        private System.Windows.Forms.Button ButtonAceitar;
        private System.Windows.Forms.Button ButtonVoltar;
        private System.Windows.Forms.Button ButtonFinalizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}