
namespace DieTop
{
    partial class Warning
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.labelAvisoLinha1 = new System.Windows.Forms.Label();
            this.labelAvisloLinha2 = new System.Windows.Forms.Label();
            this.labelAvisoLinha3 = new System.Windows.Forms.Label();
            this.labelAvisoLinha4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAvisoLinha1
            // 
            this.labelAvisoLinha1.AutoSize = true;
            this.labelAvisoLinha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoLinha1.Location = new System.Drawing.Point(205, 235);
            this.labelAvisoLinha1.Name = "labelAvisoLinha1";
            this.labelAvisoLinha1.Size = new System.Drawing.Size(343, 20);
            this.labelAvisoLinha1.TabIndex = 0;
            this.labelAvisoLinha1.Text = "Antes de continuarmos o grupo DieTop adverte";
            // 
            // labelAvisloLinha2
            // 
            this.labelAvisloLinha2.AutoSize = true;
            this.labelAvisloLinha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisloLinha2.Location = new System.Drawing.Point(174, 267);
            this.labelAvisloLinha2.Name = "labelAvisloLinha2";
            this.labelAvisloLinha2.Size = new System.Drawing.Size(413, 20);
            this.labelAvisloLinha2.TabIndex = 1;
            this.labelAvisloLinha2.Text = "que qualquer dieta é de total responsabilidade do usuário";
            // 
            // labelAvisoLinha3
            // 
            this.labelAvisoLinha3.AutoSize = true;
            this.labelAvisoLinha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoLinha3.Location = new System.Drawing.Point(141, 299);
            this.labelAvisoLinha3.Name = "labelAvisoLinha3";
            this.labelAvisoLinha3.Size = new System.Drawing.Size(485, 20);
            this.labelAvisoLinha3.TabIndex = 2;
            this.labelAvisoLinha3.Text = "aconselhamos o acompanhamento de um profissional no asssunto ";
            // 
            // labelAvisoLinha4
            // 
            this.labelAvisoLinha4.AutoSize = true;
            this.labelAvisoLinha4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoLinha4.Location = new System.Drawing.Point(58, 328);
            this.labelAvisoLinha4.Name = "labelAvisoLinha4";
            this.labelAvisoLinha4.Size = new System.Drawing.Size(677, 20);
            this.labelAvisoLinha4.TabIndex = 3;
            this.labelAvisoLinha4.Text = "Pois o mal uso do programa com uma dieta muito rígida pode trazer sérios problema" +
    "s de saúde";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAvisoLinha4);
            this.Controls.Add(this.labelAvisoLinha3);
            this.Controls.Add(this.labelAvisloLinha2);
            this.Controls.Add(this.labelAvisoLinha1);
            this.Name = "Warning";
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvisoLinha1;
        private System.Windows.Forms.Label labelAvisloLinha2;
        private System.Windows.Forms.Label labelAvisoLinha3;
        private System.Windows.Forms.Label labelAvisoLinha4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}