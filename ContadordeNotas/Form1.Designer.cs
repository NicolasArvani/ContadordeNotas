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
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(281, 51);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(507, 101);
            this.txtOutput.TabIndex = 1;
            // 
            // btnContarNotas
            // 
            this.btnContarNotas.Location = new System.Drawing.Point(146, 49);
            this.btnContarNotas.Name = "btnContarNotas";
            this.btnContarNotas.Size = new System.Drawing.Size(82, 23);
            this.btnContarNotas.TabIndex = 2;
            this.btnContarNotas.Text = "Contar Notas";
            this.btnContarNotas.UseVisualStyleBackColor = true;
            this.btnContarNotas.Click += new System.EventHandler(this.btnContarNotas_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(702, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvwNotas
            // 
            this.lvwNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lvwNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNotas.FullRowSelect = true;
            this.lvwNotas.GridLines = true;
            this.lvwNotas.HideSelection = false;
            this.lvwNotas.Location = new System.Drawing.Point(281, 195);
            this.lvwNotas.Name = "lvwNotas";
            this.lvwNotas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwNotas.Size = new System.Drawing.Size(506, 243);
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
            // 
            // btnRemoverNota
            // 
            this.btnRemoverNota.Location = new System.Drawing.Point(124, 404);
            this.btnRemoverNota.Name = "btnRemoverNota";
            this.btnRemoverNota.Size = new System.Drawing.Size(87, 23);
            this.btnRemoverNota.TabIndex = 8;
            this.btnRemoverNota.Text = "Remover Nota";
            this.btnRemoverNota.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoverNota);
            this.Controls.Add(this.btnAddNota);
            this.Controls.Add(this.txtAddNota);
            this.Controls.Add(this.lvwTipoNota);
            this.Controls.Add(this.lvwNotas);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnContarNotas);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

