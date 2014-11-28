namespace QuantizaImagem
{
    partial class formImagemQuantizada
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
            this.imagemQuantizada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qtdCoresQuantizada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qtdCoresOriginal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tempoQuantizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imagemErro = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.histogramaImagemQuantizada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.histogramaImagemOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.moda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.TextBox();
            this.mediana = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.erroPorPixel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.variancia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.desvioPadrao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.paletaCor = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizada)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagemQuantizada
            // 
            this.imagemQuantizada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemQuantizada.Location = new System.Drawing.Point(233, 25);
            this.imagemQuantizada.Name = "imagemQuantizada";
            this.imagemQuantizada.Size = new System.Drawing.Size(200, 200);
            this.imagemQuantizada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemQuantizada.TabIndex = 0;
            this.imagemQuantizada.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imagem Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informações";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.qtdCoresQuantizada);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.qtdCoresOriginal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tempoQuantizacao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 94);
            this.panel1.TabIndex = 6;
            // 
            // qtdCoresQuantizada
            // 
            this.qtdCoresQuantizada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtdCoresQuantizada.Location = new System.Drawing.Point(125, 63);
            this.qtdCoresQuantizada.Name = "qtdCoresQuantizada";
            this.qtdCoresQuantizada.ReadOnly = true;
            this.qtdCoresQuantizada.Size = new System.Drawing.Size(62, 20);
            this.qtdCoresQuantizada.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Qtd Cores Quantizada:";
            // 
            // qtdCoresOriginal
            // 
            this.qtdCoresOriginal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtdCoresOriginal.Location = new System.Drawing.Point(125, 37);
            this.qtdCoresOriginal.Name = "qtdCoresOriginal";
            this.qtdCoresOriginal.ReadOnly = true;
            this.qtdCoresOriginal.Size = new System.Drawing.Size(62, 20);
            this.qtdCoresOriginal.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Qtd Cores Original:";
            // 
            // tempoQuantizacao
            // 
            this.tempoQuantizacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tempoQuantizacao.Location = new System.Drawing.Point(125, 11);
            this.tempoQuantizacao.Name = "tempoQuantizacao";
            this.tempoQuantizacao.ReadOnly = true;
            this.tempoQuantizacao.Size = new System.Drawing.Size(62, 20);
            this.tempoQuantizacao.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tempo p/ quantizar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Erros";
            // 
            // imagemErro
            // 
            this.imagemErro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemErro.Location = new System.Drawing.Point(452, 25);
            this.imagemErro.Name = "imagemErro";
            this.imagemErro.Size = new System.Drawing.Size(200, 200);
            this.imagemErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemErro.TabIndex = 7;
            this.imagemErro.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Imagem Erro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Paleta de cor - Quantizada";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.histogramaImagemQuantizada);
            this.panel3.Location = new System.Drawing.Point(257, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 239);
            this.panel3.TabIndex = 10;
            // 
            // histogramaImagemQuantizada
            // 
            chartArea1.AxisX.Maximum = 255D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Escala de cor";
            chartArea1.AxisY.Title = "Frequência";
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "Area";
            this.histogramaImagemQuantizada.ChartAreas.Add(chartArea1);
            this.histogramaImagemQuantizada.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.histogramaImagemQuantizada.Legends.Add(legend1);
            this.histogramaImagemQuantizada.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemQuantizada.Name = "histogramaImagemQuantizada";
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
            this.histogramaImagemQuantizada.Series.Add(series1);
            this.histogramaImagemQuantizada.Series.Add(series2);
            this.histogramaImagemQuantizada.Series.Add(series3);
            this.histogramaImagemQuantizada.Size = new System.Drawing.Size(665, 237);
            this.histogramaImagemQuantizada.TabIndex = 2;
            title1.Name = "Title1";
            title1.Text = "Histograma Imagem Quantizada";
            this.histogramaImagemQuantizada.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.histogramaImagemOriginal);
            this.panel2.Location = new System.Drawing.Point(256, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 239);
            this.panel2.TabIndex = 9;
            // 
            // histogramaImagemOriginal
            // 
            chartArea2.AxisX.Maximum = 255D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Escala de cor";
            chartArea2.AxisY.Title = "Frequência";
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "Area";
            this.histogramaImagemOriginal.ChartAreas.Add(chartArea2);
            this.histogramaImagemOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.histogramaImagemOriginal.Legends.Add(legend2);
            this.histogramaImagemOriginal.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemOriginal.Name = "histogramaImagemOriginal";
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
            this.histogramaImagemOriginal.Series.Add(series4);
            this.histogramaImagemOriginal.Series.Add(series5);
            this.histogramaImagemOriginal.Series.Add(series6);
            this.histogramaImagemOriginal.Size = new System.Drawing.Size(667, 237);
            this.histogramaImagemOriginal.TabIndex = 2;
            this.histogramaImagemOriginal.Text = "histogramaImagemOriginal";
            title2.Name = "Title1";
            title2.Text = "Histograma Imagem Original";
            this.histogramaImagemOriginal.Titles.Add(title2);
            // 
            // imagemOriginal
            // 
            this.imagemOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemOriginal.Location = new System.Drawing.Point(12, 25);
            this.imagemOriginal.Name = "imagemOriginal";
            this.imagemOriginal.Size = new System.Drawing.Size(200, 200);
            this.imagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemOriginal.TabIndex = 11;
            this.imagemOriginal.TabStop = false;
            this.toolTipInfo.SetToolTip(this.imagemOriginal, "Imagem Original");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Imagem Quantizada";
            // 
            // moda
            // 
            this.moda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moda.Location = new System.Drawing.Point(93, 119);
            this.moda.Name = "moda";
            this.moda.ReadOnly = true;
            this.moda.Size = new System.Drawing.Size(59, 20);
            this.moda.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Moda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mediana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Média:";
            // 
            // media
            // 
            this.media.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.media.Location = new System.Drawing.Point(93, 67);
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Size = new System.Drawing.Size(59, 20);
            this.media.TabIndex = 17;
            // 
            // mediana
            // 
            this.mediana.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediana.Location = new System.Drawing.Point(93, 93);
            this.mediana.Name = "mediana";
            this.mediana.ReadOnly = true;
            this.mediana.Size = new System.Drawing.Size(59, 20);
            this.mediana.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.erroPorPixel);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.variancia);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.desvioPadrao);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.media);
            this.panel4.Controls.Add(this.moda);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.mediana);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(12, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 186);
            this.panel4.TabIndex = 18;
            // 
            // erroPorPixel
            // 
            this.erroPorPixel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.erroPorPixel.Location = new System.Drawing.Point(95, 12);
            this.erroPorPixel.Name = "erroPorPixel";
            this.erroPorPixel.ReadOnly = true;
            this.erroPorPixel.Size = new System.Drawing.Size(59, 20);
            this.erroPorPixel.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Erro:";
            // 
            // variancia
            // 
            this.variancia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.variancia.Location = new System.Drawing.Point(93, 145);
            this.variancia.Name = "variancia";
            this.variancia.ReadOnly = true;
            this.variancia.Size = new System.Drawing.Size(59, 20);
            this.variancia.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Variância:";
            // 
            // desvioPadrao
            // 
            this.desvioPadrao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desvioPadrao.Location = new System.Drawing.Point(95, 41);
            this.desvioPadrao.Name = "desvioPadrao";
            this.desvioPadrao.ReadOnly = true;
            this.desvioPadrao.Size = new System.Drawing.Size(59, 20);
            this.desvioPadrao.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Desvio Padrão:";
            // 
            // paletaCor
            // 
            this.paletaCor.AutoScroll = true;
            this.paletaCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paletaCor.Location = new System.Drawing.Point(672, 25);
            this.paletaCor.Name = "paletaCor";
            this.paletaCor.Size = new System.Drawing.Size(251, 200);
            this.paletaCor.TabIndex = 0;
            // 
            // formImagemQuantizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 741);
            this.Controls.Add(this.paletaCor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.imagemOriginal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imagemErro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imagemQuantizada);
            this.Controls.Add(this.panel1);
            this.Name = "formImagemQuantizada";
            this.ShowIcon = false;
            this.Text = "Imagem Quantizada - ";
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErro)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizada)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemQuantizada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imagemErro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tempoQuantizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaImagemOriginal;
        private System.Windows.Forms.PictureBox imagemOriginal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qtdCoresQuantizada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox qtdCoresOriginal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox moda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox media;
        private System.Windows.Forms.TextBox mediana;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox variancia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox desvioPadrao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaImagemQuantizada;
        private System.Windows.Forms.FlowLayoutPanel paletaCor;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.TextBox erroPorPixel;
        private System.Windows.Forms.Label label15;
    }
}