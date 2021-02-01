
namespace DieTop.Views
{
    partial class Historic
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
            this.ButtonVoltar = new System.Windows.Forms.Button();
            this.selectDay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonVoltar
            // 
            this.ButtonVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonVoltar.Location = new System.Drawing.Point(747, 515);
            this.ButtonVoltar.Name = "ButtonVoltar";
            this.ButtonVoltar.Size = new System.Drawing.Size(197, 47);
            this.ButtonVoltar.TabIndex = 41;
            this.ButtonVoltar.Text = "Voltar";
            this.ButtonVoltar.UseVisualStyleBackColor = false;
            this.ButtonVoltar.Click += new System.EventHandler(this.ButtonVoltar_Click);
            // 
            // selectDay
            // 
            this.selectDay.BackColor = System.Drawing.SystemColors.Window;
            this.selectDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDay.FormattingEnabled = true;
            this.selectDay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.selectDay.Location = new System.Drawing.Point(467, 48);
            this.selectDay.Name = "selectDay";
            this.selectDay.Size = new System.Drawing.Size(81, 21);
            this.selectDay.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(31, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 29);
            this.label9.TabIndex = 42;
            this.label9.Text = "Selecione o Dia que Deseja Consultar";
            // 
            // Historic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 574);
            this.Controls.Add(this.selectDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ButtonVoltar);
            this.Name = "Historic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refeição!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonVoltar;
        private System.Windows.Forms.ComboBox selectDay;
        private System.Windows.Forms.Label label9;
    }
}