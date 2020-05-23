namespace Cayley
{
    partial class Draw
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Depth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Leng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Perr = new System.Windows.Forms.TextBox();
            this.Perl = new System.Windows.Forms.TextBox();
            this.Angler = new System.Windows.Forms.TextBox();
            this.Anglel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.draw_Click);
            // 
            // Depth
            // 
            this.Depth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Depth.Location = new System.Drawing.Point(659, 58);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(135, 25);
            this.Depth.TabIndex = 1;
            this.Depth.TextChanged += new System.EventHandler(this.depth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depth";
            // 
            // Leng
            // 
            this.Leng.Location = new System.Drawing.Point(659, 99);
            this.Leng.Name = "Leng";
            this.Leng.Size = new System.Drawing.Size(135, 25);
            this.Leng.TabIndex = 3;
            this.Leng.TextChanged += new System.EventHandler(this.Leng_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // Perr
            // 
            this.Perr.Location = new System.Drawing.Point(659, 144);
            this.Perr.Name = "Perr";
            this.Perr.Size = new System.Drawing.Size(135, 25);
            this.Perr.TabIndex = 6;
            this.Perr.TextChanged += new System.EventHandler(this.Perr_TextChanged);
            // 
            // Perl
            // 
            this.Perl.Location = new System.Drawing.Point(659, 190);
            this.Perl.Name = "Perl";
            this.Perl.Size = new System.Drawing.Size(135, 25);
            this.Perl.TabIndex = 7;
            this.Perl.TextChanged += new System.EventHandler(this.Perl_TextChanged);
            // 
            // Angler
            // 
            this.Angler.Location = new System.Drawing.Point(657, 237);
            this.Angler.Name = "Angler";
            this.Angler.Size = new System.Drawing.Size(136, 25);
            this.Angler.TabIndex = 8;
            this.Angler.TextChanged += new System.EventHandler(this.Angler_TextChanged);
            // 
            // Anglel
            // 
            this.Anglel.Location = new System.Drawing.Point(656, 282);
            this.Anglel.Name = "Anglel";
            this.Anglel.Size = new System.Drawing.Size(137, 25);
            this.Anglel.TabIndex = 9;
            this.Anglel.TextChanged += new System.EventHandler(this.Anglel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Per Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Angle Right";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Angle Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Per Right";
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.FullOpen = true;
            // 
            // ColorSet
            // 
            this.ColorSet.Location = new System.Drawing.Point(656, 327);
            this.ColorSet.Name = "ColorSet";
            this.ColorSet.Size = new System.Drawing.Size(137, 25);
            this.ColorSet.TabIndex = 15;
            this.ColorSet.Text = "Color";
            this.ColorSet.UseVisualStyleBackColor = true;
            this.ColorSet.Click += new System.EventHandler(this.ColorSet_Click);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Anglel);
            this.Controls.Add(this.Angler);
            this.Controls.Add(this.Perl);
            this.Controls.Add(this.Perr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Leng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.button1);
            this.Name = "Draw";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Leng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Perr;
        private System.Windows.Forms.TextBox Perl;
        private System.Windows.Forms.TextBox Angler;
        private System.Windows.Forms.TextBox Anglel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button ColorSet;
    }
}

