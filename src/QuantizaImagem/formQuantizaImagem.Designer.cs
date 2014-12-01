namespace QuantizaImagem
{
    partial class QuantizaImagem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantizaImagem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdCoresOriginal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnOpcoes = new System.Windows.Forms.Panel();
            this.btnHistogramas = new System.Windows.Forms.Button();
            this.btnImagensGeradas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numQtdCores = new System.Windows.Forms.NumericUpDown();
            this.btnQuantizaDivisao = new System.Windows.Forms.Button();
            this.btnQuantizaOctree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdCores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaImagemToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novaImagemToolStripMenuItem
            // 
            this.novaImagemToolStripMenuItem.Name = "novaImagemToolStripMenuItem";
            this.novaImagemToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novaImagemToolStripMenuItem.Text = "Nova Imagem";
            this.novaImagemToolStripMenuItem.Click += new System.EventHandler(this.novaImagemToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.qtdCoresOriginal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pnOpcoes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numQtdCores);
            this.panel1.Controls.Add(this.btnQuantizaDivisao);
            this.panel1.Controls.Add(this.btnQuantizaOctree);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imagemOriginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 332);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(321, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "?";
            this.toolTipInfo.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // qtdCoresOriginal
            // 
            this.qtdCoresOriginal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtdCoresOriginal.Location = new System.Drawing.Point(150, 263);
            this.qtdCoresOriginal.Name = "qtdCoresOriginal";
            this.qtdCoresOriginal.ReadOnly = true;
            this.qtdCoresOriginal.Size = new System.Drawing.Size(62, 20);
            this.qtdCoresOriginal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Qtd Cores Original:";
            // 
            // pnOpcoes
            // 
            this.pnOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOpcoes.Controls.Add(this.btnHistogramas);
            this.pnOpcoes.Controls.Add(this.btnImagensGeradas);
            this.pnOpcoes.Location = new System.Drawing.Point(221, 166);
            this.pnOpcoes.Name = "pnOpcoes";
            this.pnOpcoes.Size = new System.Drawing.Size(273, 52);
            this.pnOpcoes.TabIndex = 14;
            this.pnOpcoes.Visible = false;
            // 
            // btnHistogramas
            // 
            this.btnHistogramas.Location = new System.Drawing.Point(154, 3);
            this.btnHistogramas.Name = "btnHistogramas";
            this.btnHistogramas.Size = new System.Drawing.Size(85, 40);
            this.btnHistogramas.TabIndex = 16;
            this.btnHistogramas.Text = "Histogramas";
            this.btnHistogramas.UseVisualStyleBackColor = true;
            this.btnHistogramas.Click += new System.EventHandler(this.btnHistogramas_Click);
            // 
            // btnImagensGeradas
            // 
            this.btnImagensGeradas.Location = new System.Drawing.Point(30, 3);
            this.btnImagensGeradas.Name = "btnImagensGeradas";
            this.btnImagensGeradas.Size = new System.Drawing.Size(85, 40);
            this.btnImagensGeradas.TabIndex = 15;
            this.btnImagensGeradas.Text = "Imagens Geradas";
            this.btnImagensGeradas.UseVisualStyleBackColor = true;
            this.btnImagensGeradas.Click += new System.EventHandler(this.btnImagensGeradas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de setores";
            // 
            // numQtdCores
            // 
            this.numQtdCores.Location = new System.Drawing.Point(232, 51);
            this.numQtdCores.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numQtdCores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdCores.Name = "numQtdCores";
            this.numQtdCores.Size = new System.Drawing.Size(56, 20);
            this.numQtdCores.TabIndex = 12;
            this.numQtdCores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdCores.ValueChanged += new System.EventHandler(this.numQtdCores_ValueChanged);
            // 
            // btnQuantizaDivisao
            // 
            this.btnQuantizaDivisao.Enabled = false;
            this.btnQuantizaDivisao.Location = new System.Drawing.Point(344, 98);
            this.btnQuantizaDivisao.Name = "btnQuantizaDivisao";
            this.btnQuantizaDivisao.Size = new System.Drawing.Size(150, 23);
            this.btnQuantizaDivisao.TabIndex = 11;
            this.btnQuantizaDivisao.Text = "Quantizar \"Divisão Setores\"";
            this.btnQuantizaDivisao.UseVisualStyleBackColor = true;
            this.btnQuantizaDivisao.Click += new System.EventHandler(this.btnQuantizaDivisao_Click);
            // 
            // btnQuantizaOctree
            // 
            this.btnQuantizaOctree.Enabled = false;
            this.btnQuantizaOctree.Location = new System.Drawing.Point(221, 98);
            this.btnQuantizaOctree.Name = "btnQuantizaOctree";
            this.btnQuantizaOctree.Size = new System.Drawing.Size(117, 23);
            this.btnQuantizaOctree.TabIndex = 10;
            this.btnQuantizaOctree.Text = "Quantizar Octree";
            this.btnQuantizaOctree.UseVisualStyleBackColor = true;
            this.btnQuantizaOctree.Click += new System.EventHandler(this.btnQuantizaOctree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imagem Original";
            // 
            // imagemOriginal
            // 
            this.imagemOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemOriginal.Location = new System.Drawing.Point(12, 51);
            this.imagemOriginal.Name = "imagemOriginal";
            this.imagemOriginal.Size = new System.Drawing.Size(200, 200);
            this.imagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemOriginal.TabIndex = 0;
            this.imagemOriginal.TabStop = false;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutoPopDelay = 15000;
            this.toolTipInfo.InitialDelay = 500;
            this.toolTipInfo.ReshowDelay = 100;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // QuantizaImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QuantizaImagem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantização de Cor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQtdCores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQtdCores;
        private System.Windows.Forms.Button btnQuantizaDivisao;
        private System.Windows.Forms.Button btnQuantizaOctree;
        private System.Windows.Forms.PictureBox imagemOriginal;
        private System.Windows.Forms.Panel pnOpcoes;
        private System.Windows.Forms.Button btnHistogramas;
        private System.Windows.Forms.Button btnImagensGeradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtdCoresOriginal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Label label3;
    }
}

