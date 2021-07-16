namespace ExercicioFinalPatric
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(95, 42);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(163, 20);
            this.txtnome.TabIndex = 2;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(95, 76);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(163, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(38, 117);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(95, 30);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(163, 117);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(95, 30);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 176);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btnsair;
    }
}

