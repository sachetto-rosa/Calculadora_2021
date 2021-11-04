namespace Calculadora_2021
{
    partial class Form1
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
            this.tBmensagem = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.tBsoma1 = new System.Windows.Forms.TextBox();
            this.tBsoma2 = new System.Windows.Forms.TextBox();
            this.tBSomaResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBmensagem
            // 
            this.tBmensagem.BackColor = System.Drawing.SystemColors.Info;
            this.tBmensagem.Location = new System.Drawing.Point(12, 188);
            this.tBmensagem.Name = "tBmensagem";
            this.tBmensagem.Size = new System.Drawing.Size(476, 20);
            this.tBmensagem.TabIndex = 1;
            this.tBmensagem.Text = "Boa noite!";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(413, 34);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // tBsoma1
            // 
            this.tBsoma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBsoma1.Location = new System.Drawing.Point(12, 34);
            this.tBsoma1.Name = "tBsoma1";
            this.tBsoma1.Size = new System.Drawing.Size(100, 29);
            this.tBsoma1.TabIndex = 2;
            this.tBsoma1.Text = "0";
            this.tBsoma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBsoma2
            // 
            this.tBsoma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBsoma2.Location = new System.Drawing.Point(152, 34);
            this.tBsoma2.Name = "tBsoma2";
            this.tBsoma2.Size = new System.Drawing.Size(100, 29);
            this.tBsoma2.TabIndex = 2;
            this.tBsoma2.Text = "0";
            this.tBsoma2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBSomaResult
            // 
            this.tBSomaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSomaResult.Location = new System.Drawing.Point(295, 33);
            this.tBSomaResult.Name = "tBSomaResult";
            this.tBSomaResult.ReadOnly = true;
            this.tBSomaResult.Size = new System.Drawing.Size(100, 29);
            this.tBSomaResult.TabIndex = 2;
            this.tBSomaResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 220);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBSomaResult);
            this.Controls.Add(this.tBsoma2);
            this.Controls.Add(this.tBsoma1);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.tBmensagem);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBmensagem;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox tBsoma1;
        private System.Windows.Forms.TextBox tBsoma2;
        private System.Windows.Forms.TextBox tBSomaResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

