namespace QuantizaImagem
{
    partial class formHistogramas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.histogramaImagemOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.histogramaImagemQuantizadaDivisao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imagemQuantizadaSetores = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.histogramaImagemQuantizadaOctree = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imagemQuantizadaOctree = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizadaDivisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizadaSetores)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizadaOctree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizadaOctree)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemOriginal
            // 
            this.imagemOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemOriginal.Location = new System.Drawing.Point(12, 25);
            this.imagemOriginal.Name = "imagemOriginal";
            this.imagemOriginal.Size = new System.Drawing.Size(200, 200);
            this.imagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemOriginal.TabIndex = 0;
            this.imagemOriginal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.histogramaImagemOriginal);
            this.panel1.Location = new System.Drawing.Point(234, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 200);
            this.panel1.TabIndex = 2;
            // 
            // histogramaImagemOriginal
            // 
            chartArea1.AxisX.Maximum = 255D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Escala de cor";
            chartArea1.AxisY.Title = "Frequência";
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "Area";
            this.histogramaImagemOriginal.ChartAreas.Add(chartArea1);
            this.histogramaImagemOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.histogramaImagemOriginal.Legends.Add(legend1);
            this.histogramaImagemOriginal.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemOriginal.Name = "histogramaImagemOriginal";
            series1.ChartArea = "Area";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Vermelho";
            series1.Name = "Red";
            series2.ChartArea = "Area";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.LegendText = "Verde";
            series2.Name = "Green";
            series3.ChartArea = "Area";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.LegendText = "Azul";
            series3.Name = "Blue";
            this.histogramaImagemOriginal.Series.Add(series1);
            this.histogramaImagemOriginal.Series.Add(series2);
            this.histogramaImagemOriginal.Series.Add(series3);
            this.histogramaImagemOriginal.Size = new System.Drawing.Size(602, 198);
            this.histogramaImagemOriginal.TabIndex = 1;
            title1.Name = "Title1";
            title1.Text = "Histograma Imagem Original";
            this.histogramaImagemOriginal.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.histogramaImagemQuantizadaDivisao);
            this.panel2.Location = new System.Drawing.Point(226, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 200);
            this.panel2.TabIndex = 4;
            // 
            // histogramaImagemQuantizadaDivisao
            // 
            chartArea2.AxisX.Maximum = 255D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Escala de cor";
            chartArea2.AxisY.Title = "Frequência";
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "Area";
            this.histogramaImagemQuantizadaDivisao.ChartAreas.Add(chartArea2);
            this.histogramaImagemQuantizadaDivisao.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.histogramaImagemQuantizadaDivisao.Legends.Add(legend2);
            this.histogramaImagemQuantizadaDivisao.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemQuantizadaDivisao.Name = "histogramaImagemQuantizadaDivisao";
            series4.ChartArea = "Area";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "Vermelho";
            series4.Name = "Red";
            series5.ChartArea = "Area";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.LegendText = "Verde";
            series5.Name = "Green";
            series6.ChartArea = "Area";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.LegendText = "Azul";
            series6.Name = "Blue";
            this.histogramaImagemQuantizadaDivisao.Series.Add(series4);
            this.histogramaImagemQuantizadaDivisao.Series.Add(series5);
            this.histogramaImagemQuantizadaDivisao.Series.Add(series6);
            this.histogramaImagemQuantizadaDivisao.Size = new System.Drawing.Size(602, 198);
            this.histogramaImagemQuantizadaDivisao.TabIndex = 2;
            title2.Name = "Title1";
            title2.Text = "Histograma Imagem Quantizada por Divisão de Setores";
            this.histogramaImagemQuantizadaDivisao.Titles.Add(title2);
            // 
            // imagemQuantizadaSetores
            // 
            this.imagemQuantizadaSetores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemQuantizadaSetores.Location = new System.Drawing.Point(12, 489);
            this.imagemQuantizadaSetores.Name = "imagemQuantizadaSetores";
            this.imagemQuantizadaSetores.Size = new System.Drawing.Size(200, 200);
            this.imagemQuantizadaSetores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemQuantizadaSetores.TabIndex = 3;
            this.imagemQuantizadaSetores.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.histogramaImagemQuantizadaOctree);
            this.panel3.Location = new System.Drawing.Point(227, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 200);
            this.panel3.TabIndex = 6;
            // 
            // histogramaImagemQuantizadaOctree
            // 
            chartArea3.AxisX.Maximum = 255D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Escala de cor";
            chartArea3.AxisY.Title = "Frequência";
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "Area";
            this.histogramaImagemQuantizadaOctree.ChartAreas.Add(chartArea3);
            this.histogramaImagemQuantizadaOctree.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.histogramaImagemQuantizadaOctree.Legends.Add(legend3);
            this.histogramaImagemQuantizadaOctree.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemQuantizadaOctree.Name = "histogramaImagemQuantizadaOctree";
            series7.ChartArea = "Area";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.LegendText = "Vermelho";
            series7.Name = "Red";
            series8.ChartArea = "Area";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.LegendText = "Verde";
            series8.Name = "Green";
            series9.ChartArea = "Area";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.LegendText = "Azul";
            series9.Name = "Blue";
            this.histogramaImagemQuantizadaOctree.Series.Add(series7);
            this.histogramaImagemQuantizadaOctree.Series.Add(series8);
            this.histogramaImagemQuantizadaOctree.Series.Add(series9);
            this.histogramaImagemQuantizadaOctree.Size = new System.Drawing.Size(602, 198);
            this.histogramaImagemQuantizadaOctree.TabIndex = 3;
            title3.Name = "Title1";
            title3.Text = "Histograma Imagem Quantizada por Octree";
            this.histogramaImagemQuantizadaOctree.Titles.Add(title3);
            // 
            // imagemQuantizadaOctree
            // 
            this.imagemQuantizadaOctree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemQuantizadaOctree.Location = new System.Drawing.Point(12, 257);
            this.imagemQuantizadaOctree.Name = "imagemQuantizadaOctree";
            this.imagemQuantizadaOctree.Size = new System.Drawing.Size(200, 200);
            this.imagemQuantizadaOctree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemQuantizadaOctree.TabIndex = 5;
            this.imagemQuantizadaOctree.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Imagem Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imagem Quantizada\r\nDivisão Setores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imagem Quantizada\r\nOctree";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHistogramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.imagemQuantizadaOctree);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.imagemQuantizadaSetores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagemOriginal);
            this.Name = "formHistogramas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogramas";
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizadaDivisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizadaSetores)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizadaOctree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizadaOctree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemOriginal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imagemQuantizadaSetores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imagemQuantizadaOctree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaImagemQuantizadaDivisao;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaImagemQuantizadaOctree;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaImagemOriginal;
    }
}