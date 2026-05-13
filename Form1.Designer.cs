namespace WindowsFormsApp7
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCidadeEdicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btGravarEdicao = new System.Windows.Forms.Button();
            this.txbNomeEdicao = new System.Windows.Forms.TextBox();
            this.btConsultarEdicao = new System.Windows.Forms.Button();
            this.txbIdEdicao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(29, 60);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(29, 126);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSalvar.Location = new System.Drawing.Point(29, 170);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(43, 360);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 7;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(43, 334);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 8;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(124, 360);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbCidadeEdicao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btGravarEdicao);
            this.groupBox1.Controls.Add(this.txbNomeEdicao);
            this.groupBox1.Controls.Add(this.btConsultarEdicao);
            this.groupBox1.Controls.Add(this.txbIdEdicao);
            this.groupBox1.Location = new System.Drawing.Point(783, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 323);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade";
            // 
            // txbCidadeEdicao
            // 
            this.txbCidadeEdicao.Location = new System.Drawing.Point(6, 163);
            this.txbCidadeEdicao.Name = "txbCidadeEdicao";
            this.txbCidadeEdicao.Size = new System.Drawing.Size(100, 20);
            this.txbCidadeEdicao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // btGravarEdicao
            // 
            this.btGravarEdicao.Location = new System.Drawing.Point(9, 211);
            this.btGravarEdicao.Name = "btGravarEdicao";
            this.btGravarEdicao.Size = new System.Drawing.Size(75, 23);
            this.btGravarEdicao.TabIndex = 3;
            this.btGravarEdicao.Text = "Gravar";
            this.btGravarEdicao.UseVisualStyleBackColor = true;
            this.btGravarEdicao.Click += new System.EventHandler(this.btGravarEdicao_Click);
            // 
            // txbNomeEdicao
            // 
            this.txbNomeEdicao.Location = new System.Drawing.Point(6, 109);
            this.txbNomeEdicao.Name = "txbNomeEdicao";
            this.txbNomeEdicao.Size = new System.Drawing.Size(100, 20);
            this.txbNomeEdicao.TabIndex = 2;
            // 
            // btConsultarEdicao
            // 
            this.btConsultarEdicao.Location = new System.Drawing.Point(122, 45);
            this.btConsultarEdicao.Name = "btConsultarEdicao";
            this.btConsultarEdicao.Size = new System.Drawing.Size(75, 23);
            this.btConsultarEdicao.TabIndex = 1;
            this.btConsultarEdicao.Text = "Consultar";
            this.btConsultarEdicao.UseVisualStyleBackColor = true;
            this.btConsultarEdicao.Click += new System.EventHandler(this.btConsultarEdicao_Click);
            // 
            // txbIdEdicao
            // 
            this.txbIdEdicao.Location = new System.Drawing.Point(6, 45);
            this.txbIdEdicao.Name = "txbIdEdicao";
            this.txbIdEdicao.Size = new System.Drawing.Size(100, 20);
            this.txbIdEdicao.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravarEdicao;
        private System.Windows.Forms.TextBox txbNomeEdicao;
        private System.Windows.Forms.Button btConsultarEdicao;
        private System.Windows.Forms.TextBox txbIdEdicao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCidadeEdicao;
    }
}

