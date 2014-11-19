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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.imagemQuantizada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tempoQuantizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imagemErro = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.histogramaImagemOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qtdCoresOriginal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.qtdCoresQuantizada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.moda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.TextBox();
            this.mediana = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.desvioPadrao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.variancia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.histogramaImagemQuantizada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paletaCor = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagemQuantizada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErro)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizada)).BeginInit();
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
            chartArea3.AxisX.Maximum = 255D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Escala de cor";
            chartArea3.AxisY.Title = "Frequência";
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "Area";
            this.histogramaImagemOriginal.ChartAreas.Add(chartArea3);
            this.histogramaImagemOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.histogramaImagemOriginal.Legends.Add(legend3);
            this.histogramaImagemOriginal.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemOriginal.Name = "histogramaImagemOriginal";
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
            this.histogramaImagemOriginal.Series.Add(series7);
            this.histogramaImagemOriginal.Series.Add(series8);
            this.histogramaImagemOriginal.Series.Add(series9);
            this.histogramaImagemOriginal.Size = new System.Drawing.Size(667, 237);
            this.histogramaImagemOriginal.TabIndex = 2;
            this.histogramaImagemOriginal.Text = "histogramaImagemOriginal";
            title3.Name = "Title1";
            title3.Text = "Histograma Imagem Original";
            this.histogramaImagemOriginal.Titles.Add(title3);
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
            // moda
            // 
            this.moda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moda.Location = new System.Drawing.Point(93, 96);
            this.moda.Name = "moda";
            this.moda.ReadOnly = true;
            this.moda.Size = new System.Drawing.Size(57, 20);
            this.moda.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Moda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mediana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Média:";
            // 
            // media
            // 
            this.media.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.media.Location = new System.Drawing.Point(91, 44);
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Size = new System.Drawing.Size(59, 20);
            this.media.TabIndex = 17;
            // 
            // mediana
            // 
            this.mediana.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediana.Location = new System.Drawing.Point(91, 70);
            this.mediana.Name = "mediana";
            this.mediana.ReadOnly = true;
            this.mediana.Size = new System.Drawing.Size(59, 20);
            this.mediana.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel4.Size = new System.Drawing.Size(225, 165);
            this.panel4.TabIndex = 18;
            // 
            // desvioPadrao
            // 
            this.desvioPadrao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desvioPadrao.Location = new System.Drawing.Point(91, 18);
            this.desvioPadrao.Name = "desvioPadrao";
            this.desvioPadrao.ReadOnly = true;
            this.desvioPadrao.Size = new System.Drawing.Size(59, 20);
            this.desvioPadrao.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Desvio Padrão:";
            // 
            // variancia
            // 
            this.variancia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.variancia.Location = new System.Drawing.Point(91, 122);
            this.variancia.Name = "variancia";
            this.variancia.ReadOnly = true;
            this.variancia.Size = new System.Drawing.Size(57, 20);
            this.variancia.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Variância:";
            // 
            // histogramaImagemQuantizada
            // 
            chartArea4.AxisX.Maximum = 255D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "Escala de cor";
            chartArea4.AxisY.Title = "Frequência";
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "Area";
            this.histogramaImagemQuantizada.ChartAreas.Add(chartArea4);
            this.histogramaImagemQuantizada.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.histogramaImagemQuantizada.Legends.Add(legend4);
            this.histogramaImagemQuantizada.Location = new System.Drawing.Point(0, 0);
            this.histogramaImagemQuantizada.Name = "histogramaImagemQuantizada";
            series10.ChartArea = "Area";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "Vermelho";
            series10.Name = "Red";
            series11.ChartArea = "Area";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.LegendText = "Verde";
            series11.Name = "Green";
            series12.ChartArea = "Area";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.LegendText = "Azul";
            series12.Name = "Blue";
            this.histogramaImagemQuantizada.Series.Add(series10);
            this.histogramaImagemQuantizada.Series.Add(series11);
            this.histogramaImagemQuantizada.Series.Add(series12);
            this.histogramaImagemQuantizada.Size = new System.Drawing.Size(665, 237);
            this.histogramaImagemQuantizada.TabIndex = 2;
            title4.Name = "Title1";
            title4.Text = "Histograma Imagem Quantizada";
            this.histogramaImagemQuantizada.Titles.Add(title4);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaImagemQuantizada)).EndInit();
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
    }
}