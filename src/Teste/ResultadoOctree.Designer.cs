namespace AnaliseImagens
{
    partial class ResultadoOctree
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
            this.dataOctree = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataOctree)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOctree
            // 
            this.dataOctree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOctree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOctree.Location = new System.Drawing.Point(0, 0);
            this.dataOctree.Name = "dataOctree";
            this.dataOctree.Size = new System.Drawing.Size(1065, 414);
            this.dataOctree.TabIndex = 0;
            // 
            // ResultadoOctree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 414);
            this.Controls.Add(this.dataOctree);
            this.Name = "ResultadoOctree";
            this.Text = "ResultadoOctree";
            ((System.ComponentModel.ISupportInitialize)(this.dataOctree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOctree;
    }
}