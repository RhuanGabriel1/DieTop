
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
            this.button1 = new System.Windows.Forms.Button();
            this.user.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.Button button1;
    }
}