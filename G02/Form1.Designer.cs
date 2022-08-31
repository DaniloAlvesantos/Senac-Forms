namespace G02
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Padding = new System.Windows.Forms.Padding(5);
            this.lblNome.Size = new System.Drawing.Size(50, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.DimGray;
            this.lblSobrenome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 53);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Padding = new System.Windows.Forms.Padding(5);
            this.lblSobrenome.Size = new System.Drawing.Size(78, 25);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.SystemColors.Info;
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado.ForeColor = System.Drawing.Color.Black;
            this.resultado.Location = new System.Drawing.Point(27, 137);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(78, 20);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "Resultado:";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(27, 99);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(160, 23);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Processo";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(27, 70);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(160, 23);
            this.txtSobreNome.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(947, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Concatena nome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Button button1;
    }
}
