namespace atv_frank07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.radioButtonAdicao = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtracao = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radioButtonDivisao = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor1.ForeColor = System.Drawing.Color.White;
            this.textBoxValor1.Location = new System.Drawing.Point(282, 57);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(100, 13);
            this.textBoxValor1.TabIndex = 4;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor2.Location = new System.Drawing.Point(282, 83);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(100, 13);
            this.textBoxValor2.TabIndex = 5;
            // 
            // radioButtonAdicao
            // 
            this.radioButtonAdicao.AutoSize = true;
            this.radioButtonAdicao.Location = new System.Drawing.Point(265, 153);
            this.radioButtonAdicao.Name = "radioButtonAdicao";
            this.radioButtonAdicao.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAdicao.TabIndex = 6;
            this.radioButtonAdicao.TabStop = true;
            this.radioButtonAdicao.Text = "+";
            this.radioButtonAdicao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtracao
            // 
            this.radioButtonSubtracao.AutoSize = true;
            this.radioButtonSubtracao.Location = new System.Drawing.Point(340, 153);
            this.radioButtonSubtracao.Name = "radioButtonSubtracao";
            this.radioButtonSubtracao.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSubtracao.TabIndex = 7;
            this.radioButtonSubtracao.TabStop = true;
            this.radioButtonSubtracao.Text = "-";
            this.radioButtonSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplicacao
            // 
            this.radioButtonMultiplicacao.AutoSize = true;
            this.radioButtonMultiplicacao.Location = new System.Drawing.Point(411, 153);
            this.radioButtonMultiplicacao.Name = "radioButtonMultiplicacao";
            this.radioButtonMultiplicacao.Size = new System.Drawing.Size(30, 17);
            this.radioButtonMultiplicacao.TabIndex = 8;
            this.radioButtonMultiplicacao.TabStop = true;
            this.radioButtonMultiplicacao.Text = "x";
            this.radioButtonMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivisao
            // 
            this.radioButtonDivisao.AutoSize = true;
            this.radioButtonDivisao.Location = new System.Drawing.Point(464, 153);
            this.radioButtonDivisao.Name = "radioButtonDivisao";
            this.radioButtonDivisao.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDivisao.TabIndex = 9;
            this.radioButtonDivisao.TabStop = true;
            this.radioButtonDivisao.Text = "/";
            this.radioButtonDivisao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(475, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 90);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(262, 258);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDivisao);
            this.Controls.Add(this.radioButtonMultiplicacao);
            this.Controls.Add(this.radioButtonSubtracao);
            this.Controls.Add(this.radioButtonAdicao);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.RadioButton radioButtonAdicao;
        private System.Windows.Forms.RadioButton radioButtonSubtracao;
        private System.Windows.Forms.RadioButton radioButtonMultiplicacao;
        private System.Windows.Forms.RadioButton radioButtonDivisao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResultado;
    }
}

