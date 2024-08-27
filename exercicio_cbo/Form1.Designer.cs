namespace exercicio_cbo
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
            this.lblTodos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNorte = new System.Windows.Forms.Label();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.lblCentro = new System.Windows.Forms.Label();
            this.lblSudeste = new System.Windows.Forms.Label();
            this.lblSul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os estados";
            // 
            // lblTodos
            // 
            this.lblTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTodos.Location = new System.Drawing.Point(514, 43);
            this.lblTodos.Name = "lblTodos";
            this.lblTodos.Size = new System.Drawing.Size(100, 23);
            this.lblTodos.TabIndex = 1;
            this.lblTodos.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(126, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Norte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(126, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Nordeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(126, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Centro-Oeste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(126, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sudeste";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " Acre - AC",
            " Alagoas - AL",
            " Amapá - AP",
            " Amazonas -  AM",
            " Bahia - BA",
            " Ceará - CE",
            " Distrito Federal - DF",
            " Espírito Santo - ES",
            " Goiás - GO",
            " Maranhão - MA",
            " Mato Grosso - MT",
            " Mato Grosso do Sul\t- MS",
            " Minas Gerais - MG",
            " Pará - PA",
            " Paraíba - PB",
            " Paraná - PR",
            " Pernambuco - PE",
            " Piauí - PI",
            " Rio de Janeiro - RJ",
            " Rio Grande do Norte\t - RN",
            " Rio Grande do Sul - RS",
            " Rondônia\t- RO",
            " Roraima - RR",
            " Santa Catarina - SC",
            " São Paulo - SP",
            " Sergipe - SE",
            " Tocantins - TO"});
            this.comboBox1.Location = new System.Drawing.Point(259, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(426, 38);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(54, 23);
            this.btnTodos.TabIndex = 7;
            this.btnTodos.Text = "—";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(259, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(259, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(259, 180);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(259, 229);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 11;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(259, 277);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 12;
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(426, 85);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(54, 23);
            this.btnNorte.TabIndex = 13;
            this.btnNorte.Text = "—";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // btnNordeste
            // 
            this.btnNordeste.Location = new System.Drawing.Point(426, 132);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(54, 23);
            this.btnNordeste.TabIndex = 14;
            this.btnNordeste.Text = "—";
            this.btnNordeste.UseVisualStyleBackColor = true;
            this.btnNordeste.Click += new System.EventHandler(this.btnNordeste_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.Location = new System.Drawing.Point(426, 183);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(54, 23);
            this.btnCentro.TabIndex = 15;
            this.btnCentro.Text = "—";
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.Location = new System.Drawing.Point(426, 229);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(54, 23);
            this.btnSudeste.TabIndex = 16;
            this.btnSudeste.Text = "—";
            this.btnSudeste.UseVisualStyleBackColor = true;
            this.btnSudeste.Click += new System.EventHandler(this.btnSudeste_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(426, 277);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(54, 23);
            this.btnSul.TabIndex = 17;
            this.btnSul.Text = "—";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(126, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Região Sul";
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNorte.Location = new System.Drawing.Point(514, 93);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(0, 13);
            this.lblNorte.TabIndex = 19;
            this.lblNorte.Click += new System.EventHandler(this.lblNorte_Click);
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNordeste.Location = new System.Drawing.Point(514, 137);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(0, 13);
            this.lblNordeste.TabIndex = 20;
            this.lblNordeste.Click += new System.EventHandler(this.lblNordeste_Click);
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCentro.Location = new System.Drawing.Point(514, 188);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(0, 13);
            this.lblCentro.TabIndex = 21;
            this.lblCentro.Click += new System.EventHandler(this.lblCentro_Click);
            // 
            // lblSudeste
            // 
            this.lblSudeste.AutoSize = true;
            this.lblSudeste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSudeste.Location = new System.Drawing.Point(514, 239);
            this.lblSudeste.Name = "lblSudeste";
            this.lblSudeste.Size = new System.Drawing.Size(0, 13);
            this.lblSudeste.TabIndex = 22;
            this.lblSudeste.Click += new System.EventHandler(this.lblSudeste_Click);
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSul.Location = new System.Drawing.Point(514, 287);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(0, 13);
            this.lblSul.TabIndex = 23;
            this.lblSul.Click += new System.EventHandler(this.lblSul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.lblSudeste);
            this.Controls.Add(this.lblCentro);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnSudeste);
            this.Controls.Add(this.btnCentro);
            this.Controls.Add(this.btnNordeste);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTodos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblSudeste;
        private System.Windows.Forms.Label lblSul;
    }
}

