namespace G05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbAdicao = new System.Windows.Forms.RadioButton();
            this.rbSubtracao = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbDivisao = new System.Windows.Forms.RadioButton();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 1;
            // 
            // rbAdicao
            // 
            this.rbAdicao.AutoSize = true;
            this.rbAdicao.BackColor = System.Drawing.Color.Black;
            this.rbAdicao.Checked = true;
            this.rbAdicao.Location = new System.Drawing.Point(12, 83);
            this.rbAdicao.Name = "rbAdicao";
            this.rbAdicao.Size = new System.Drawing.Size(59, 19);
            this.rbAdicao.TabIndex = 2;
            this.rbAdicao.TabStop = true;
            this.rbAdicao.Text = "SOMA";
            this.rbAdicao.UseVisualStyleBackColor = false;
            // 
            // rbSubtracao
            // 
            this.rbSubtracao.AutoSize = true;
            this.rbSubtracao.BackColor = System.Drawing.Color.Black;
            this.rbSubtracao.Location = new System.Drawing.Point(12, 108);
            this.rbSubtracao.Name = "rbSubtracao";
            this.rbSubtracao.Size = new System.Drawing.Size(78, 19);
            this.rbSubtracao.TabIndex = 3;
            this.rbSubtracao.Text = "Subtração";
            this.rbSubtracao.UseVisualStyleBackColor = false;
            // 
            // rbMultiplicacao
            // 
            this.rbMultiplicacao.AutoSize = true;
            this.rbMultiplicacao.BackColor = System.Drawing.Color.Black;
            this.rbMultiplicacao.Location = new System.Drawing.Point(12, 133);
            this.rbMultiplicacao.Name = "rbMultiplicacao";
            this.rbMultiplicacao.Size = new System.Drawing.Size(97, 19);
            this.rbMultiplicacao.TabIndex = 4;
            this.rbMultiplicacao.Text = "Multiplicação";
            this.rbMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // rbDivisao
            // 
            this.rbDivisao.AutoSize = true;
            this.rbDivisao.BackColor = System.Drawing.Color.Black;
            this.rbDivisao.Location = new System.Drawing.Point(12, 158);
            this.rbDivisao.Name = "rbDivisao";
            this.rbDivisao.Size = new System.Drawing.Size(63, 19);
            this.rbDivisao.TabIndex = 5;
            this.rbDivisao.Text = "Divisão";
            this.rbDivisao.UseVisualStyleBackColor = false;
            this.rbDivisao.CheckedChanged += new System.EventHandler(this.rbDivisao_CheckedChanged);
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Location = new System.Drawing.Point(102, 191);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(170, 23);
            this.txtRes.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(12, 190);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(278, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.rbDivisao);
            this.Controls.Add(this.rbMultiplicacao);
            this.Controls.Add(this.rbSubtracao);
            this.Controls.Add(this.rbAdicao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbAdicao;
        private System.Windows.Forms.RadioButton rbSubtracao;
        private System.Windows.Forms.RadioButton rbMultiplicacao;
        private System.Windows.Forms.RadioButton rbDivisao;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
