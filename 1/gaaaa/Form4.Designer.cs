
namespace gaaaa
{
    partial class Form4
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TypeNameProductLbl = new System.Windows.Forms.Label();
            this.Nomerl = new System.Windows.Forms.Label();
            this.Procent = new System.Windows.Forms.Label();
            this.Priori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(107, 79);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // TypeNameProductLbl
            // 
            this.TypeNameProductLbl.AutoSize = true;
            this.TypeNameProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeNameProductLbl.Location = new System.Drawing.Point(144, 21);
            this.TypeNameProductLbl.Name = "TypeNameProductLbl";
            this.TypeNameProductLbl.Size = new System.Drawing.Size(141, 16);
            this.TypeNameProductLbl.TabIndex = 2;
            this.TypeNameProductLbl.Text = "Тип | Наименование";
            this.TypeNameProductLbl.Click += new System.EventHandler(this.TypeNameProductLbl_Click);
            // 
            // Nomerl
            // 
            this.Nomerl.AutoSize = true;
            this.Nomerl.Location = new System.Drawing.Point(144, 65);
            this.Nomerl.Name = "Nomerl";
            this.Nomerl.Size = new System.Drawing.Size(41, 13);
            this.Nomerl.TabIndex = 5;
            this.Nomerl.Text = "Номер";
            // 
            // Procent
            // 
            this.Procent.AutoSize = true;
            this.Procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Procent.Location = new System.Drawing.Point(553, 43);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(72, 16);
            this.Procent.TabIndex = 6;
            this.Procent.Text = "Процент";
            // 
            // Priori
            // 
            this.Priori.AutoSize = true;
            this.Priori.Location = new System.Drawing.Point(144, 82);
            this.Priori.Name = "Priori";
            this.Priori.Size = new System.Drawing.Size(90, 13);
            this.Priori.TabIndex = 7;
            this.Priori.Text = "Приоритетность";
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(654, 103);
            this.Controls.Add(this.Priori);
            this.Controls.Add(this.Procent);
            this.Controls.Add(this.Nomerl);
            this.Controls.Add(this.TypeNameProductLbl);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label TypeNameProductLbl;
        private System.Windows.Forms.Label Nomerl;
        private System.Windows.Forms.Label Procent;
        private System.Windows.Forms.Label Priori;
    }
}