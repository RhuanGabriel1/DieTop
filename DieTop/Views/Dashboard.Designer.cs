
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
            this.labelUserInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.inputIdade = new System.Windows.Forms.TextBox();
            this.inputSexo = new System.Windows.Forms.TextBox();
            this.inputAltura = new System.Windows.Forms.TextBox();
            this.inputPeso = new System.Windows.Forms.TextBox();
            this.user.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.user);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
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
    }
}