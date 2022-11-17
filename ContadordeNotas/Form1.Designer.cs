namespace ContadordeNotas
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnContarNotas = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvwNotas = new System.Windows.Forms.ListView();
            this.qtdNotas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd100 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwTipoNota = new System.Windows.Forms.ListView();
            this.txtAddNota = new System.Windows.Forms.TextBox();
            this.btnAddNota = new System.Windows.Forms.Button();
            this.btnRemoverNota = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(18, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(520, 121);
            this.txtOutput.TabIndex = 1;
            // 
            // btnContarNotas
            // 
            this.btnContarNotas.Location = new System.Drawing.Point(129, 49);
            this.btnContarNotas.Name = "btnContarNotas";
            this.btnContarNotas.Size = new System.Drawing.Size(82, 23);
            this.btnContarNotas.TabIndex = 2;
            this.btnContarNotas.Text = "Contar Notas";
            this.btnContarNotas.UseVisualStyleBackColor = true;
            this.btnContarNotas.Click += new System.EventHandler(this.btnContarNotas_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(711, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvwNotas
            // 
            this.lvwNotas.BackColor = System.Drawing.SystemColors.Window;
            this.lvwNotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qtdNotas,
            this.qtd100,
            this.qtd50,
            this.qtd20,
            this.qtd10,
            this.qtd5,
            this.qtd2,
            this.qtd1});
            this.lvwNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNotas.FullRowSelect = true;
            this.lvwNotas.GridLines = true;
            this.lvwNotas.HideSelection = false;
            this.lvwNotas.Location = new System.Drawing.Point(0, 0);
            this.lvwNotas.Name = "lvwNotas";
            this.lvwNotas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwNotas.Size = new System.Drawing.Size(520, 249);
            this.lvwNotas.TabIndex = 4;
            this.lvwNotas.UseCompatibleStateImageBehavior = false;
            this.lvwNotas.View = System.Windows.Forms.View.Details;
            // 
            // qtdNotas
            // 
            this.qtdNotas.Text = "Qtd Notas";
            this.qtdNotas.Width = 105;
            // 
            // qtd100
            // 
            this.qtd100.Text = "100";
            this.qtd100.Width = 38;
            // 
            // qtd50
            // 
            this.qtd50.Text = "50";
            this.qtd50.Width = 29;
            // 
            // qtd20
            // 
            this.qtd20.Text = "20";
            this.qtd20.Width = 32;
            // 
            // qtd10
            // 
            this.qtd10.Text = "10";
            this.qtd10.Width = 32;
            // 
            // qtd5
            // 
            this.qtd5.Text = "5";
            this.qtd5.Width = 29;
            // 
            // qtd2
            // 
            this.qtd2.Text = "2";
            this.qtd2.Width = 27;
            // 
            // qtd1
            // 
            this.qtd1.Text = "1";
            this.qtd1.Width = 32;
            // 
            // lvwTipoNota
            // 
            this.lvwTipoNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwTipoNota.HideSelection = false;
            this.lvwTipoNota.Location = new System.Drawing.Point(18, 158);
            this.lvwTipoNota.Name = "lvwTipoNota";
            this.lvwTipoNota.Size = new System.Drawing.Size(193, 240);
            this.lvwTipoNota.TabIndex = 5;
            this.lvwTipoNota.UseCompatibleStateImageBehavior = false;
            this.lvwTipoNota.View = System.Windows.Forms.View.List;
            // 
            // txtAddNota
            // 
            this.txtAddNota.Location = new System.Drawing.Point(18, 132);
            this.txtAddNota.Name = "txtAddNota";
            this.txtAddNota.Size = new System.Drawing.Size(100, 20);
            this.txtAddNota.TabIndex = 6;
            // 
            // btnAddNota
            // 
            this.btnAddNota.Location = new System.Drawing.Point(124, 130);
            this.btnAddNota.Name = "btnAddNota";
            this.btnAddNota.Size = new System.Drawing.Size(87, 23);
            this.btnAddNota.TabIndex = 7;
            this.btnAddNota.Text = "Adicionar Nota";
            this.btnAddNota.UseVisualStyleBackColor = true;
            this.btnAddNota.Click += new System.EventHandler(this.btnAddNota_Click);
            // 
            // btnRemoverNota
            // 
            this.btnRemoverNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverNota.Location = new System.Drawing.Point(124, 415);
            this.btnRemoverNota.Name = "btnRemoverNota";
            this.btnRemoverNota.Size = new System.Drawing.Size(87, 23);
            this.btnRemoverNota.TabIndex = 8;
            this.btnRemoverNota.Text = "Remover Nota";
            this.btnRemoverNota.UseVisualStyleBackColor = true;
            this.btnRemoverNota.Click += new System.EventHandler(this.btnRemoverNota_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetarNotasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // resetarNotasToolStripMenuItem
            // 
            this.resetarNotasToolStripMenuItem.Name = "resetarNotasToolStripMenuItem";
            this.resetarNotasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.resetarNotasToolStripMenuItem.Text = "Resetar Notas";
            this.resetarNotasToolStripMenuItem.Click += new System.EventHandler(this.resetarNotasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrantesToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            this.integrantesToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(8, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 335);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas Utilizadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contador de Notas";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(264, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOutput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwNotas);
            this.splitContainer1.Size = new System.Drawing.Size(524, 382);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoverNota);
            this.Controls.Add(this.btnAddNota);
            this.Controls.Add(this.txtAddNota);
            this.Controls.Add(this.lvwTipoNota);
            this.Controls.Add(this.btnContarNotas);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Contador de Notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnContarNotas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvwNotas;
        private System.Windows.Forms.ColumnHeader qtdNotas;
        private System.Windows.Forms.ColumnHeader qtd100;
        private System.Windows.Forms.ColumnHeader qtd50;
        private System.Windows.Forms.ColumnHeader qtd20;
        private System.Windows.Forms.ColumnHeader qtd10;
        private System.Windows.Forms.ColumnHeader qtd5;
        private System.Windows.Forms.ColumnHeader qtd2;
        private System.Windows.Forms.ColumnHeader qtd1;
        private System.Windows.Forms.ListView lvwTipoNota;
        private System.Windows.Forms.TextBox txtAddNota;
        private System.Windows.Forms.Button btnAddNota;
        private System.Windows.Forms.Button btnRemoverNota;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

