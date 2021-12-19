
namespace gaaaa
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RangeLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 102);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Попрыгунчик";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 664);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 72);
            this.panel2.TabIndex = 21;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(525, 26);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 34);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.red.Location = new System.Drawing.Point(0, 626);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(166, 32);
            this.red.TabIndex = 29;
            this.red.Text = "Редактирование";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(gaaaa.Agent);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(590, 633);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 29);
            this.button5.TabIndex = 33;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(561, 633);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 29);
            this.button4.TabIndex = 34;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(532, 633);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 29);
            this.button3.TabIndex = 35;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(501, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 29);
            this.button2.TabIndex = 36;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(475, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RightBtn
            // 
            this.RightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.Location = new System.Drawing.Point(618, 626);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(23, 36);
            this.RightBtn.TabIndex = 31;
            this.RightBtn.Text = ">";
            this.RightBtn.UseVisualStyleBackColor = false;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBtn.Location = new System.Drawing.Point(446, 626);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(23, 36);
            this.LeftBtn.TabIndex = 32;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = false;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLbl.Location = new System.Drawing.Point(183, 635);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(229, 17);
            this.RangeLbl.TabIndex = 38;
            this.RangeLbl.Text = "Товары с ....  по .... (из всего ..... )";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 512);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 736);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RangeLbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.red);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Label RangeLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}