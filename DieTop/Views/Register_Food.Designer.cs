
namespace DieTop.Views
{
    partial class Register_Food
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
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputAlimento = new System.Windows.Forms.TextBox();
            this.InputCaloria = new System.Windows.Forms.TextBox();
            this.ButtonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCadastrar.Location = new System.Drawing.Point(683, 500);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(261, 47);
            this.ButtonCadastrar.TabIndex = 32;
            this.ButtonCadastrar.Text = "Adicionar Alimento";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome do Alimento :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(352, 64);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(239, 28);
            this.label.TabIndex = 36;
            this.label.Text = "Cadastre um Alimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Calorias do Alimento : ";
            // 
            // InputAlimento
            // 
            this.InputAlimento.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAlimento.Location = new System.Drawing.Point(301, 163);
            this.InputAlimento.Multiline = true;
            this.InputAlimento.Name = "InputAlimento";
            this.InputAlimento.Size = new System.Drawing.Size(519, 25);
            this.InputAlimento.TabIndex = 39;
            // 
            // InputCaloria
            // 
            this.InputCaloria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCaloria.Location = new System.Drawing.Point(301, 228);
            this.InputCaloria.Multiline = true;
            this.InputCaloria.Name = "InputCaloria";
            this.InputCaloria.Size = new System.Drawing.Size(519, 25);
            this.InputCaloria.TabIndex = 40;
            // 
            // ButtonVoltar
            // 
            this.ButtonVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonVoltar.Location = new System.Drawing.Point(480, 500);
            this.ButtonVoltar.Name = "ButtonVoltar";
            this.ButtonVoltar.Size = new System.Drawing.Size(197, 47);
            this.ButtonVoltar.TabIndex = 41;
            this.ButtonVoltar.Text = "Voltar";
            this.ButtonVoltar.UseVisualStyleBackColor = false;
            this.ButtonVoltar.Click += new System.EventHandler(this.ButtonVoltar_Click);
            // 
            // Register_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.ButtonVoltar);
            this.Controls.Add(this.InputCaloria);
            this.Controls.Add(this.InputAlimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ButtonCadastrar);
            this.Name = "Register_Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refeição!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputAlimento;
        private System.Windows.Forms.TextBox InputCaloria;
        private System.Windows.Forms.Button ButtonVoltar;
    }
}

