namespace PL
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
            this.btnCADASTRAR = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.CnbTipoCliente = new System.Windows.Forms.ComboBox();
            this.DtmDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnMOSTRAR = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCADASTRAR
            // 
            this.btnCADASTRAR.Location = new System.Drawing.Point(151, 287);
            this.btnCADASTRAR.Name = "btnCADASTRAR";
            this.btnCADASTRAR.Size = new System.Drawing.Size(275, 81);
            this.btnCADASTRAR.TabIndex = 0;
            this.btnCADASTRAR.Text = "CADASTRAR";
            this.btnCADASTRAR.UseVisualStyleBackColor = true;
            this.btnCADASTRAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(65, 84);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(443, 22);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(65, 155);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(443, 22);
            this.txtCPF.TabIndex = 1;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(65, 224);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(443, 22);
            this.txtEmailCliente.TabIndex = 1;
            // 
            // CnbTipoCliente
            // 
            this.CnbTipoCliente.FormattingEnabled = true;
            this.CnbTipoCliente.Location = new System.Drawing.Point(469, 316);
            this.CnbTipoCliente.Name = "CnbTipoCliente";
            this.CnbTipoCliente.Size = new System.Drawing.Size(121, 24);
            this.CnbTipoCliente.TabIndex = 2;
            this.CnbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CnbTipoCliente_SelectedIndexChanged);
            // 
            // DtmDataNascimento
            // 
            this.DtmDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmDataNascimento.Location = new System.Drawing.Point(12, 416);
            this.DtmDataNascimento.Name = "DtmDataNascimento";
            this.DtmDataNascimento.Size = new System.Drawing.Size(137, 22);
            this.DtmDataNascimento.TabIndex = 3;
            // 
            // btnMOSTRAR
            // 
            this.btnMOSTRAR.Location = new System.Drawing.Point(828, 12);
            this.btnMOSTRAR.Name = "btnMOSTRAR";
            this.btnMOSTRAR.Size = new System.Drawing.Size(130, 31);
            this.btnMOSTRAR.TabIndex = 4;
            this.btnMOSTRAR.Text = "MOSTRAR";
            this.btnMOSTRAR.UseVisualStyleBackColor = true;
            this.btnMOSTRAR.Click += new System.EventHandler(this.btnMOSTRAR_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(617, 66);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.RowHeadersWidth = 51;
            this.DgvDados.RowTemplate.Height = 24;
            this.DgvDados.Size = new System.Drawing.Size(538, 359);
            this.DgvDados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.btnMOSTRAR);
            this.Controls.Add(this.DtmDataNascimento);
            this.Controls.Add(this.CnbTipoCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnCADASTRAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCADASTRAR;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.ComboBox CnbTipoCliente;
        private System.Windows.Forms.DateTimePicker DtmDataNascimento;
        private System.Windows.Forms.Button btnMOSTRAR;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

