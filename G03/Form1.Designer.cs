namespace G03
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.BackColor = System.Drawing.Color.Silver;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(21, 27);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(55, 20);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.BackColor = System.Drawing.Color.Silver;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(21, 72);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(55, 20);
            this.lblValor2.TabIndex = 0;
            this.lblValor2.Text = "Valor 2";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(118, 69);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.PlaceholderText = "Digite um valor";
            this.txtValor2.Size = new System.Drawing.Size(121, 23);
            this.txtValor2.TabIndex = 1;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(118, 27);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.PlaceholderText = "Digite um valor";
            this.txtValor1.Size = new System.Drawing.Size(121, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // btnProcessar
            // 
            this.btnProcessar.BackColor = System.Drawing.Color.DarkGray;
            this.btnProcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProcessar.Location = new System.Drawing.Point(118, 119);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(121, 23);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "LET´S GO";
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button btnProcessar;
    }
}
