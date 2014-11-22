namespace AnaliseImagens
{
    partial class AnaliseImagens
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressSalvamento = new System.Windows.Forms.ProgressBar();
            this.dataDivisao = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDivisao)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressSalvamento
            // 
            this.progressSalvamento.Location = new System.Drawing.Point(12, 329);
            this.progressSalvamento.Name = "progressSalvamento";
            this.progressSalvamento.Size = new System.Drawing.Size(696, 23);
            this.progressSalvamento.TabIndex = 0;
            // 
            // dataDivisao
            // 
            this.dataDivisao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDivisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDivisao.Location = new System.Drawing.Point(0, 0);
            this.dataDivisao.Name = "dataDivisao";
            this.dataDivisao.Size = new System.Drawing.Size(739, 304);
            this.dataDivisao.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgOriginal);
            this.panel1.Controls.Add(this.dataDivisao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 304);
            this.panel1.TabIndex = 2;
            // 
            // imgOriginal
            // 
            this.imgOriginal.Location = new System.Drawing.Point(203, 12);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(290, 264);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOriginal.TabIndex = 2;
            this.imgOriginal.TabStop = false;
            // 
            // AnaliseImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressSalvamento);
            this.Name = "AnaliseImagens";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataDivisao)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressSalvamento;
        private System.Windows.Forms.DataGridView dataDivisao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgOriginal;
    }
}

