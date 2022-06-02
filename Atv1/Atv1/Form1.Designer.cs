namespace Atv1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMaior = new System.Windows.Forms.RadioButton();
            this.rdbDiferenca = new System.Windows.Forms.RadioButton();
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(67, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor1.Location = new System.Drawing.Point(160, 49);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(135, 20);
            this.txtValor1.TabIndex = 1;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor2.Location = new System.Drawing.Point(160, 108);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(135, 20);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(67, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // rdbMaior
            // 
            this.rdbMaior.AutoSize = true;
            this.rdbMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaior.Location = new System.Drawing.Point(72, 163);
            this.rdbMaior.Name = "rdbMaior";
            this.rdbMaior.Size = new System.Drawing.Size(121, 20);
            this.rdbMaior.TabIndex = 4;
            this.rdbMaior.TabStop = true;
            this.rdbMaior.Text = "Qual o maior?";
            this.rdbMaior.UseVisualStyleBackColor = true;
            // 
            // rdbDiferenca
            // 
            this.rdbDiferenca.AutoSize = true;
            this.rdbDiferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiferenca.Location = new System.Drawing.Point(72, 207);
            this.rdbDiferenca.Name = "rdbDiferenca";
            this.rdbDiferenca.Size = new System.Drawing.Size(147, 20);
            this.rdbDiferenca.TabIndex = 5;
            this.rdbDiferenca.TabStop = true;
            this.rdbDiferenca.Text = "Qual a diferença?";
            this.rdbDiferenca.UseVisualStyleBackColor = true;
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntre.Location = new System.Drawing.Point(72, 251);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(196, 20);
            this.rdbEntre.TabIndex = 6;
            this.rdbEntre.TabStop = true;
            this.rdbEntre.Text = "Quais os números entre?";
            this.rdbEntre.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Ivory;
            this.btnVerificar.Location = new System.Drawing.Point(72, 294);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(234, 71);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.SeaShell;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(72, 382);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(60, 10, 70, 10);
            this.lblResultado.Size = new System.Drawing.Size(233, 44);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdbEntre);
            this.Controls.Add(this.rdbDiferenca);
            this.Controls.Add(this.rdbMaior);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMaior;
        private System.Windows.Forms.RadioButton rdbDiferenca;
        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
    }
}

