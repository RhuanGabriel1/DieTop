
namespace DieTop.Views
{
    partial class Register_ATV
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
            this.label = new System.Windows.Forms.Label();
            this.ButtonVoltar = new System.Windows.Forms.Button();
            this.inputTempo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selectTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.ButtonCadastrar.Text = "Adicionar Atividade";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(281, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(416, 28);
            this.label.TabIndex = 36;
            this.label.Text = "O que você fez hoje de Atividade Física?";
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
            // inputTempo
            // 
            this.inputTempo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTempo.Location = new System.Drawing.Point(120, 298);
            this.inputTempo.Multiline = true;
            this.inputTempo.Name = "inputTempo";
            this.inputTempo.Size = new System.Drawing.Size(723, 25);
            this.inputTempo.TabIndex = 45;
            this.inputTempo.Text = "60";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(70, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duração (em minutos)";
            // 
            // selectTipo
            // 
            this.selectTipo.BackColor = System.Drawing.SystemColors.Window;
            this.selectTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTipo.FormattingEnabled = true;
            this.selectTipo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.selectTipo.Items.AddRange(new object[] {
            "NADA",
            "MUSCULAÇÃO",
            "CARDIO"});
            this.selectTipo.Location = new System.Drawing.Point(120, 208);
            this.selectTipo.Name = "selectTipo";
            this.selectTipo.Size = new System.Drawing.Size(723, 21);
            this.selectTipo.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(70, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 29);
            this.label9.TabIndex = 42;
            this.label9.Text = "Atv Física Realizada no Dia :";
            // 
            // Register_ATV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.inputTempo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.selectTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ButtonVoltar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ButtonCadastrar);
            this.Name = "Register_ATV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refeição!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ButtonVoltar;
        private System.Windows.Forms.TextBox inputTempo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox selectTipo;
        private System.Windows.Forms.Label label9;
    }
}