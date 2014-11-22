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
    public partial class formImagensGeradas : Form
    {
        Quantizacao QuantizadoOctree;
        Quantizacao QuantizadoDivisao;

        public formImagensGeradas(Quantizacao objquantizadoOctree, Quantizacao objQuantizadoDivisao)
        {
            InitializeComponent();
            QuantizadoOctree = objquantizadoOctree;
            QuantizadoDivisao = objQuantizadoDivisao;
            CarregaGrafico();
            CarregaImagens();
            CarregaInformacoes();
        }

        private void CarregaInformacoes()
        {
            desvioPadraoOctree.Text = QuantizadoOctree.DesvioPadrao.ToString();
            mediaOctree.Text = QuantizadoOctree.Media.ToString();
            medianaOctree.Text = QuantizadoOctree.Mediana.ToString();
            modaOctree.Text = QuantizadoOctree.Moda.ToString();
            varianciaOctree.Text = QuantizadoOctree.Variancia.ToString();
            tempoQuantizacaoOctree.Text = QuantizadoOctree.TempoQuantizacao.Milliseconds + "ms";

            desvioPadraoDivisao.Text = QuantizadoDivisao.DesvioPadrao.ToString();
            mediaDivisao.Text = QuantizadoDivisao.Media.ToString();
            medianaDivisao.Text = QuantizadoDivisao.Mediana.ToString();
            modaDivisao.Text = QuantizadoDivisao.Moda.ToString();
            varianciaDivisao.Text = QuantizadoDivisao.Variancia.ToString();
            tempoQuantizacaoDivisao.Text = QuantizadoDivisao.TempoQuantizacao.Milliseconds + "ms";

            qtdCoresOriginal.Text = QuantizadoOctree.QuantidadeCoresOriginal.ToString();
            qtdCoresQuantizada.Text = QuantizadoOctree.QuantidadeCoresQuantizadas.ToString();
        }

        private void CarregaImagens()
        {
            imagemOgirinal.Image = QuantizadoOctree.ImagemOriginal;
            imagemQuantizadaOctree.Image = QuantizadoOctree.ImagemQuantizada;
            imagemErroOctree.Image = QuantizadoOctree.ImagemErro;
            imagemQuantizadaDivisao.Image = QuantizadoDivisao.ImagemQuantizada;
            imagemErroDivisao.Image = QuantizadoDivisao.ImagemErro;
        }

        private void CarregaGrafico()
        {
            //Octree
            graficoErroQuantizacao.Series[0].Points[0].YValues[0]= QuantizadoOctree.DesvioPadrao;
            graficoErroQuantizacao.Series[0].Points[1].YValues[0] = QuantizadoOctree.Media;
            graficoErroQuantizacao.Series[0].Points[2].YValues[0] = QuantizadoOctree.Mediana;
            graficoErroQuantizacao.Series[0].Points[3].YValues[0] = QuantizadoOctree.Moda;
            graficoErroQuantizacao.Series[0].Points[4].YValues[0] = QuantizadoOctree.Variancia;
            //Divisao
            graficoErroQuantizacao.Series[1].Points[0].YValues[0] = QuantizadoDivisao.DesvioPadrao;
            graficoErroQuantizacao.Series[1].Points[1].YValues[0] = QuantizadoDivisao.Media;
            graficoErroQuantizacao.Series[1].Points[2].YValues[0] = QuantizadoDivisao.Mediana;
            graficoErroQuantizacao.Series[1].Points[3].YValues[0] = QuantizadoDivisao.Moda;
            graficoErroQuantizacao.Series[1].Points[4].YValues[0] = QuantizadoDivisao.Variancia;
        }




    }
}
