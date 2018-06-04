namespace ConsumindoAPI_windowsForm
{
    partial class frmAmigo
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
            this.components = new System.ComponentModel.Container();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboAmigos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumToken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerToken = new System.Windows.Forms.Timer(this.components);
            this.btnCopiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 85);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(753, 311);
            this.dgvDados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amigos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(274, 415);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consulta Amigos Proximos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboAmigos
            // 
            this.cboAmigos.FormattingEnabled = true;
            this.cboAmigos.Location = new System.Drawing.Point(12, 45);
            this.cboAmigos.Name = "cboAmigos";
            this.cboAmigos.Size = new System.Drawing.Size(329, 21);
            this.cboAmigos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amigos Próximos";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(359, 46);
            this.txtToken.MaxLength = 17;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(223, 20);
            this.txtToken.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite o Token";
            // 
            // lblNumToken
            // 
            this.lblNumToken.AutoSize = true;
            this.lblNumToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumToken.Location = new System.Drawing.Point(508, 418);
            this.lblNumToken.Name = "lblNumToken";
            this.lblNumToken.Size = new System.Drawing.Size(154, 16);
            this.lblNumToken.TabIndex = 9;
            this.lblNumToken.Text = "13665620W4F64371Q";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Token";
            // 
            // timerToken
            // 
            this.timerToken.Interval = 5000;
            this.timerToken.Tick += new System.EventHandler(this.timerToken_Tick);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(682, 415);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(94, 23);
            this.btnCopiar.TabIndex = 11;
            this.btnCopiar.Text = "Copiar Token";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // frmAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAmigos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.Name = "frmAmigo";
            this.Text = "Consulta Amigos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboAmigos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerToken;
        private System.Windows.Forms.Button btnCopiar;
    }
}

