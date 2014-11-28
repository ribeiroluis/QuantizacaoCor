using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantizaImagem
{
    public partial class formImagemQuantizada : Form
    {

        private Quantizacao objquantizacao;

        public Quantizacao ObjetoQuantizado
        {
            get { return objquantizacao; }            
        }
        

        public formImagemQuantizada(string nomeQuantizacao, Quantizacao objQuantizacao)
        {
            InitializeComponent();
            this.Text += nomeQuantizacao;
            objquantizacao = objQuantizacao;
            CarregaHistogramas();
            CarregaInformacoes();
            PreenchePaletaCor();
            CarregaImagens();

        }

        private void CarregaImagens()
        {
            imagemErro.Image = objquantizacao.ImagemErro;
            imagemOriginal.Image = objquantizacao.ImagemOriginal;
            imagemQuantizada.Image = objquantizacao.ImagemQuantizada;
        }

        private void CarregaInformacoes()
        {
            desvioPadrao.Text = objquantizacao.DesvioPadrao.ToString();
            media.Text = objquantizacao.Media.ToString();
            mediana.Text = objquantizacao.Mediana.ToString();
            moda.Text = objquantizacao.Moda.ToString();
            variancia.Text = objquantizacao.Variancia.ToString();
            tempoQuantizacao.Text = objquantizacao.TempoQuantizacao.Milliseconds.ToString() + "ms";
            qtdCoresOriginal.Text = objquantizacao.QuantidadeCoresOriginal.ToString();
            qtdCoresQuantizada.Text = objquantizacao.CoresQuantizadas.Count.ToString();
            erroPorPixel.Text = objquantizacao.ErroPorPixel.ToString("P");
        }

        private void CarregaHistogramas()
        {
            var histogramaVermelhoOriginal = objquantizacao.HistogramaImagemOriginal[0];
            var histogramaVerdeOriginal = objquantizacao.HistogramaImagemOriginal[1];
            var histogramaAzulOriginal = objquantizacao.HistogramaImagemOriginal[2];

            var histogramaVermelhoQuantizada = objquantizacao.HistogramaImagemQuantizada[0];
            var histogramaVerdeQuantizada = objquantizacao.HistogramaImagemQuantizada[1];
            var histogramaAzulQuantizada = objquantizacao.HistogramaImagemQuantizada[2];
            
            for (int i = 0; i < 255; i++)
            {
                histogramaImagemOriginal.Series[0].Points.AddXY(i, histogramaVermelhoOriginal[i]);
                histogramaImagemOriginal.Series[1].Points.AddXY(i, histogramaVerdeOriginal[i]);
                histogramaImagemOriginal.Series[2].Points.AddXY(i, histogramaAzulOriginal[i]);

                histogramaImagemQuantizada.Series[0].Points.AddXY(i, histogramaVermelhoQuantizada[i]);
                histogramaImagemQuantizada.Series[1].Points.AddXY(i, histogramaVerdeQuantizada[i]);
                histogramaImagemQuantizada.Series[2].Points.AddXY(i, histogramaAzulQuantizada[i]);

            }
        }

        private void PreenchePaletaCor()
        {
            foreach (Color cor in objquantizacao.CoresQuantizadas)
            {
                var miniCaixa = new Panel();
                miniCaixa.Width = 30;
                miniCaixa.Height = 30;
                miniCaixa.BackColor = cor;
                this.toolTipInfo.SetToolTip(miniCaixa, "RGB("+cor.R +","+ cor.G +","+ cor.B + ")");
                
                paletaCor.Controls.Add(miniCaixa);
            }
        }
    }
}
