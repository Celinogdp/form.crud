
namespace form.crud
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
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.idAluno = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.nomeAluno = new System.Windows.Forms.Label();
            this.rgAluno = new System.Windows.Forms.Label();
            this.enderecoAluno = new System.Windows.Forms.Label();
            this.telefoneAluno = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAluno.Location = new System.Drawing.Point(12, 56);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(776, 205);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAluno_CellMouseDoubleClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(410, 107);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 57);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // idAluno
            // 
            this.idAluno.AutoSize = true;
            this.idAluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAluno.Location = new System.Drawing.Point(22, 30);
            this.idAluno.Name = "idAluno";
            this.idAluno.Size = new System.Drawing.Size(29, 21);
            this.idAluno.TabIndex = 2;
            this.idAluno.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(120, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // nomeAluno
            // 
            this.nomeAluno.AutoSize = true;
            this.nomeAluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAluno.Location = new System.Drawing.Point(22, 68);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(55, 21);
            this.nomeAluno.TabIndex = 4;
            this.nomeAluno.Text = "Nome";
            // 
            // rgAluno
            // 
            this.rgAluno.AutoSize = true;
            this.rgAluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgAluno.Location = new System.Drawing.Point(22, 107);
            this.rgAluno.Name = "rgAluno";
            this.rgAluno.Size = new System.Drawing.Size(37, 21);
            this.rgAluno.TabIndex = 5;
            this.rgAluno.Text = "RG";
            // 
            // enderecoAluno
            // 
            this.enderecoAluno.AutoSize = true;
            this.enderecoAluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoAluno.Location = new System.Drawing.Point(369, 30);
            this.enderecoAluno.Name = "enderecoAluno";
            this.enderecoAluno.Size = new System.Drawing.Size(81, 21);
            this.enderecoAluno.TabIndex = 6;
            this.enderecoAluno.Text = "Endereço";
            // 
            // telefoneAluno
            // 
            this.telefoneAluno.AutoSize = true;
            this.telefoneAluno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneAluno.Location = new System.Drawing.Point(369, 68);
            this.telefoneAluno.Name = "telefoneAluno";
            this.telefoneAluno.Size = new System.Drawing.Size(74, 21);
            this.telefoneAluno.TabIndex = 7;
            this.telefoneAluno.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(120, 107);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(473, 31);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(12, 390);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(150, 48);
            this.btnCadastrarAluno.TabIndex = 12;
            this.btnCadastrarAluno.Text = "Cadastrar aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dados dos alunos";
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlAlterar.Controls.Add(this.txtTelefone);
            this.pnlAlterar.Controls.Add(this.txtID);
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Controls.Add(this.idAluno);
            this.pnlAlterar.Controls.Add(this.nomeAluno);
            this.pnlAlterar.Controls.Add(this.txtEndereco);
            this.pnlAlterar.Controls.Add(this.rgAluno);
            this.pnlAlterar.Controls.Add(this.txtRG);
            this.pnlAlterar.Controls.Add(this.enderecoAluno);
            this.pnlAlterar.Controls.Add(this.txtNome);
            this.pnlAlterar.Controls.Add(this.telefoneAluno);
            this.pnlAlterar.Location = new System.Drawing.Point(168, 267);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(585, 171);
            this.pnlAlterar.TabIndex = 14;
            this.pnlAlterar.Visible = false;
            this.pnlAlterar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAlterar_Paint);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(473, 67);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.dgvAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.pnlAlterar.ResumeLayout(false);
            this.pnlAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label idAluno;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label nomeAluno;
        private System.Windows.Forms.Label rgAluno;
        private System.Windows.Forms.Label enderecoAluno;
        private System.Windows.Forms.Label telefoneAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAlterar;
        private System.Windows.Forms.TextBox txtTelefone;
    }
}

