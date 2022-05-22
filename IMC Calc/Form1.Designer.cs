
namespace IMC_Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CampNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CampPeso = new System.Windows.Forms.TextBox();
            this.CampAltura = new System.Windows.Forms.TextBox();
            this.Masculino = new System.Windows.Forms.CheckBox();
            this.Feminino = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResultIMC = new System.Windows.Forms.TextBox();
            this.ResultPideal = new System.Windows.Forms.TextBox();
            this.ResultCondicao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Centaur", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Paciente";
            // 
            // CampNome
            // 
            this.CampNome.Location = new System.Drawing.Point(7, 127);
            this.CampNome.Name = "CampNome";
            this.CampNome.Size = new System.Drawing.Size(220, 20);
            this.CampNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso";
            // 
            // CampPeso
            // 
            this.CampPeso.Location = new System.Drawing.Point(74, 203);
            this.CampPeso.Multiline = true;
            this.CampPeso.Name = "CampPeso";
            this.CampPeso.Size = new System.Drawing.Size(59, 27);
            this.CampPeso.TabIndex = 5;
            // 
            // CampAltura
            // 
            this.CampAltura.Location = new System.Drawing.Point(76, 168);
            this.CampAltura.Multiline = true;
            this.CampAltura.Name = "CampAltura";
            this.CampAltura.Size = new System.Drawing.Size(58, 28);
            this.CampAltura.TabIndex = 6;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.BackColor = System.Drawing.Color.Transparent;
            this.Masculino.Location = new System.Drawing.Point(56, 249);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(74, 17);
            this.Masculino.TabIndex = 7;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = false;
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.BackColor = System.Drawing.Color.Transparent;
            this.Feminino.Location = new System.Drawing.Point(131, 249);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(68, 17);
            this.Feminino.TabIndex = 8;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Informações";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.Location = new System.Drawing.Point(154, 340);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(138, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(651, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "IMC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Condição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Peso Ideal";
            // 
            // ResultIMC
            // 
            this.ResultIMC.Location = new System.Drawing.Point(580, 191);
            this.ResultIMC.Name = "ResultIMC";
            this.ResultIMC.Size = new System.Drawing.Size(198, 20);
            this.ResultIMC.TabIndex = 17;
            // 
            // ResultPideal
            // 
            this.ResultPideal.Location = new System.Drawing.Point(581, 249);
            this.ResultPideal.Name = "ResultPideal";
            this.ResultPideal.Size = new System.Drawing.Size(198, 20);
            this.ResultPideal.TabIndex = 18;
            // 
            // ResultCondicao
            // 
            this.ResultCondicao.Location = new System.Drawing.Point(580, 303);
            this.ResultCondicao.Name = "ResultCondicao";
            this.ResultCondicao.Size = new System.Drawing.Size(198, 20);
            this.ResultCondicao.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 395);
            this.Controls.Add(this.ResultCondicao);
            this.Controls.Add(this.ResultPideal);
            this.Controls.Add(this.ResultIMC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Feminino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.CampAltura);
            this.Controls.Add(this.CampPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CampNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CampNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CampPeso;
        private System.Windows.Forms.TextBox CampAltura;
        private System.Windows.Forms.CheckBox Masculino;
        private System.Windows.Forms.CheckBox Feminino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ResultIMC;
        private System.Windows.Forms.TextBox ResultPideal;
        private System.Windows.Forms.TextBox ResultCondicao;
    }
}

