namespace Automacao.DisparaBat
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnSelecionarCaminho = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.gridCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridNomeFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.dataGridExecucao = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridExecucaoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridExecucaoExtensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridExecucaoPasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridExecucaoCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecucao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(22, 28);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(447, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // btnSelecionarCaminho
            // 
            this.btnSelecionarCaminho.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelecionarCaminho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarCaminho.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarCaminho.Location = new System.Drawing.Point(475, 25);
            this.btnSelecionarCaminho.Name = "btnSelecionarCaminho";
            this.btnSelecionarCaminho.Size = new System.Drawing.Size(27, 25);
            this.btnSelecionarCaminho.TabIndex = 1;
            this.btnSelecionarCaminho.Text = "...";
            this.btnSelecionarCaminho.UseVisualStyleBackColor = false;
            this.btnSelecionarCaminho.Click += new System.EventHandler(this.btnSelecionarCaminho_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToOrderColumns = true;
            this.dataGridViewFiles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridCheckbox,
            this.gridNomeFile,
            this.gridExtension,
            this.gridFolder,
            this.gridCaminho});
            this.dataGridViewFiles.Location = new System.Drawing.Point(22, 56);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.Size = new System.Drawing.Size(694, 318);
            this.dataGridViewFiles.TabIndex = 2;
            // 
            // gridCheckbox
            // 
            this.gridCheckbox.HeaderText = "";
            this.gridCheckbox.Name = "gridCheckbox";
            this.gridCheckbox.Width = 50;
            // 
            // gridNomeFile
            // 
            this.gridNomeFile.HeaderText = "Nome Arquivo";
            this.gridNomeFile.Name = "gridNomeFile";
            this.gridNomeFile.ReadOnly = true;
            this.gridNomeFile.Width = 200;
            // 
            // gridExtension
            // 
            this.gridExtension.HeaderText = "Extensão";
            this.gridExtension.Name = "gridExtension";
            this.gridExtension.ReadOnly = true;
            // 
            // gridFolder
            // 
            this.gridFolder.HeaderText = "Pasta";
            this.gridFolder.Name = "gridFolder";
            this.gridFolder.ReadOnly = true;
            this.gridFolder.Width = 150;
            // 
            // gridCaminho
            // 
            this.gridCaminho.HeaderText = "Caminho";
            this.gridCaminho.Name = "gridCaminho";
            this.gridCaminho.ReadOnly = true;
            this.gridCaminho.Width = 150;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(607, 380);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(109, 49);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecionar Pasta:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscarFiles);
            this.panel1.Controls.Add(this.txtCaminho);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewFiles);
            this.panel1.Controls.Add(this.btnSelecionarCaminho);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 433);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.btnExecutar);
            this.panel2.Controls.Add(this.dataGridExecucao);
            this.panel2.Location = new System.Drawing.Point(1, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 443);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.White;
            this.btnExecutar.Location = new System.Drawing.Point(599, 341);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(109, 49);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Iniciar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // dataGridExecucao
            // 
            this.dataGridExecucao.AllowUserToAddRows = false;
            this.dataGridExecucao.AllowUserToDeleteRows = false;
            this.dataGridExecucao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridExecucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExecucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridExecucaoDescricao,
            this.gridExecucaoExtensao,
            this.gridExecucaoPasta,
            this.gridExecucaoCaminho});
            this.dataGridExecucao.Location = new System.Drawing.Point(33, 53);
            this.dataGridExecucao.MultiSelect = false;
            this.dataGridExecucao.Name = "dataGridExecucao";
            this.dataGridExecucao.Size = new System.Drawing.Size(675, 282);
            this.dataGridExecucao.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(33, 341);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 49);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Execução";
            // 
            // gridExecucaoDescricao
            // 
            this.gridExecucaoDescricao.HeaderText = "Nome Arquivo";
            this.gridExecucaoDescricao.Name = "gridExecucaoDescricao";
            this.gridExecucaoDescricao.ReadOnly = true;
            this.gridExecucaoDescricao.Width = 200;
            // 
            // gridExecucaoExtensao
            // 
            this.gridExecucaoExtensao.HeaderText = "Extensão";
            this.gridExecucaoExtensao.Name = "gridExecucaoExtensao";
            this.gridExecucaoExtensao.ReadOnly = true;
            // 
            // gridExecucaoPasta
            // 
            this.gridExecucaoPasta.HeaderText = "Pasta";
            this.gridExecucaoPasta.Name = "gridExecucaoPasta";
            this.gridExecucaoPasta.ReadOnly = true;
            this.gridExecucaoPasta.Width = 150;
            // 
            // gridExecucaoCaminho
            // 
            this.gridExecucaoCaminho.HeaderText = "Caminho";
            this.gridExecucaoCaminho.Name = "gridExecucaoCaminho";
            this.gridExecucaoCaminho.ReadOnly = true;
            this.gridExecucaoCaminho.Width = 180;
            // 
            // btnBuscarFiles
            // 
            this.btnBuscarFiles.BackColor = System.Drawing.Color.Black;
            this.btnBuscarFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFiles.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFiles.Location = new System.Drawing.Point(508, 25);
            this.btnBuscarFiles.Name = "btnBuscarFiles";
            this.btnBuscarFiles.Size = new System.Drawing.Size(51, 25);
            this.btnBuscarFiles.TabIndex = 5;
            this.btnBuscarFiles.Text = "Buscar";
            this.btnBuscarFiles.UseVisualStyleBackColor = false;
            this.btnBuscarFiles.Click += new System.EventHandler(this.btnBuscarFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Disparador de Executaveis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnSelecionarCaminho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNomeFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCaminho;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.DataGridView dataGridExecucao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridExecucaoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridExecucaoExtensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridExecucaoPasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridExecucaoCaminho;
        private System.Windows.Forms.Button btnBuscarFiles;
    }
}

