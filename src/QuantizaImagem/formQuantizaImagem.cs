using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using AlgoritimoDivisaoSetores;
using AlgoritmoOctree;
using CalculaErro;
using FrequenciaCor;

namespace QuantizaImagem
{
    public partial class QuantizaImagem : Form
    {
        bool DivisaoQuantizado;
        double erroMedioDivisao;
        Octree quantizaOctree;
        AlgoritimoSetores quantizaDivisao;
        Bitmap ImagemOriginal;
        int quantidadeCoresDivisao = 0;
        Quantizacao objQuantizadoDivisao;
        Quantizacao objQuantizadoOctree;
        Form _formHistogramasObj, _formImagemQuantizadaOctree, _formImagemQuantizadaDivisao, _formImagensGeradas;
        private bool _octreeQuantizado;

        public QuantizaImagem()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuantizaOctree_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantizaDivisao == null)
                    QuantizaDivisao();

                if (quantizaOctree == null)
                    QuantizaOctree();

                if (_formImagemQuantizadaOctree != null)
                {
                    _formImagemQuantizadaOctree.Dispose();
                    _formImagemQuantizadaOctree.Close();
                }


                _formImagemQuantizadaOctree = new formImagemQuantizada("Octree", objQuantizadoOctree);
                _formImagemQuantizadaOctree.Show();


                _octreeQuantizado = true;
                HabilitarDesabilitarPainel();

                

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btnQuantizaDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantizaDivisao == null)
                    QuantizaDivisao();


                if (_formImagemQuantizadaDivisao != null)
                {
                    _formImagemQuantizadaDivisao.Dispose();
                    _formImagemQuantizadaDivisao.Close();
                }



                _formImagemQuantizadaDivisao = new formImagemQuantizada("Divisão Setores", objQuantizadoDivisao);
                _formImagemQuantizadaDivisao.Show();

                

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void novaImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaObjetos();

                var abrirImagem = new OpenFileDialog
                {
                    Filter = "Arquivos de imagem(*.bmp, *.jpg, *.png)|*.bmp;*.jpg; *.png"
                };
                abrirImagem.ShowDialog();
                abrirImagem.Multiselect = false;
                ImagemOriginal = new Bitmap(abrirImagem.FileName);

                imagemOriginal.Image = ImagemOriginal;
                qtdCoresOriginal.Text = ContaCores(ImagemOriginal).ToString();
                
                btnQuantizaOctree.Enabled = true;
                btnQuantizaDivisao.Enabled = true;
                
                

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void HabilitarDesabilitarPainel()
        {
            if (DivisaoQuantizado && _octreeQuantizado)
            {
                pnOpcoes.Visible = true;
            }
            else
            {
                pnOpcoes.Visible = false;
            }
        }

        private void btnImagensGeradas_Click(object sender, EventArgs e)
        {
            try
            {
                if (_formImagensGeradas != null)
                {
                    _formImagensGeradas.Dispose();
                    _formImagensGeradas.Close();
                }



                _formImagensGeradas = new formImagensGeradas(objQuantizadoOctree, objQuantizadoDivisao);
                _formImagensGeradas.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHistogramas_Click(object sender, EventArgs e)
        {
            if (_formHistogramasObj != null)
            {
                _formHistogramasObj.Dispose();
                _formHistogramasObj.Close();
            }



            _formHistogramasObj = new formHistogramas(objQuantizadoOctree, objQuantizadoDivisao);
            _formHistogramasObj.Show();

        }

        private int ContaCores(Bitmap imagem)
        {
            var colors = new HashSet<Color>();
            for (var linha = 0; linha < imagem.Height; linha++)
            {
                for (var coluna = 0; coluna < imagem.Width; coluna++)
                {
                    colors.Add(imagem.GetPixel(coluna, linha));
                }

            }
            return colors.Count;
        }

        private void QuantizaDivisao()
        {
            try
            {
                quantizaDivisao = new AlgoritimoSetores(ImagemOriginal, Convert.ToInt32(numQtdCores.Value));
                var erro = new ErrodeQuantizacao(ImagemOriginal, quantizaDivisao.ImagemQuantizada);
                var histograma = new Frequencia();
                objQuantizadoDivisao = new Quantizacao();

                erroMedioDivisao = erro.Media;
                this.quantidadeCoresDivisao = quantizaDivisao.RecuperaPaletaCorQuantizada().Count;

                objQuantizadoDivisao.QuantidadeCoresOriginal = int.Parse(qtdCoresOriginal.Text);
                objQuantizadoDivisao.QuantidadeCoresQuantizadas = this.quantidadeCoresDivisao;
                objQuantizadoDivisao.CoresQuantizadas = quantizaDivisao.RecuperaPaletaCorQuantizada();

                
                objQuantizadoDivisao.DesvioPadrao = erro.DesvioPadrao;
                objQuantizadoDivisao.Media = erro.Media;
                objQuantizadoDivisao.Mediana = erro.Mediana;
                objQuantizadoDivisao.Moda = erro.Moda;
                objQuantizadoDivisao.Variancia = erro.Variancia;

                objQuantizadoDivisao.TempoQuantizacao = quantizaDivisao.TempoTotalQuantizacao;

                objQuantizadoDivisao.ImagemOriginal = ImagemOriginal;
                objQuantizadoDivisao.ImagemQuantizada = quantizaDivisao.ImagemQuantizada;
                objQuantizadoDivisao.ImagemErro = erro.GeraImagemErrro(erroMedioDivisao);
                objQuantizadoDivisao.ErroPorPixel = erro.ErroPorPixel;
                
                objQuantizadoDivisao.HistogramaImagemOriginal = new List<int[]>();
                objQuantizadoDivisao.HistogramaImagemQuantizada = new List<int[]>();
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "R"));
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "G"));
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "B"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "R"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "G"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "B"));

                DivisaoQuantizado = true;
                HabilitarDesabilitarPainel();

            }


            catch (Exception)
            {

                throw;
            }


        }

        private void QuantizaOctree()
        {
            try
            {
                quantizaOctree = new Octree(ImagemOriginal, this.quantidadeCoresDivisao);
                var erro = new ErrodeQuantizacao(ImagemOriginal, quantizaOctree.ImagemQuantizada);
                var histograma = new Frequencia();
                objQuantizadoOctree = new Quantizacao();


                objQuantizadoOctree.QuantidadeCoresOriginal = int.Parse(qtdCoresOriginal.Text);
                objQuantizadoOctree.QuantidadeCoresQuantizadas = this.quantidadeCoresDivisao;
                objQuantizadoOctree.CoresQuantizadas = quantizaOctree.RecuperaPaletaCorQuantizada();

                
                objQuantizadoOctree.DesvioPadrao = erro.DesvioPadrao;
                objQuantizadoOctree.Media = erro.Media;
                objQuantizadoOctree.Mediana = erro.Mediana;
                objQuantizadoOctree.Moda = erro.Moda;
                objQuantizadoOctree.Variancia = erro.Variancia;

                objQuantizadoOctree.TempoQuantizacao = quantizaOctree.TempoTotalQuantizacao;

                objQuantizadoOctree.ImagemOriginal = ImagemOriginal;
                objQuantizadoOctree.ImagemQuantizada = quantizaOctree.ImagemQuantizada;
                objQuantizadoOctree.ImagemErro = erro.GeraImagemErrro(erroMedioDivisao);
                objQuantizadoOctree.ErroPorPixel = erro.ErroPorPixel;

                objQuantizadoOctree.HistogramaImagemOriginal = new List<int[]>();
                objQuantizadoOctree.HistogramaImagemQuantizada = new List<int[]>();
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "R"));
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "G"));
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "B"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "R"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "G"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "B"));
                

                _octreeQuantizado = true;
                HabilitarDesabilitarPainel();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimpaObjetos()
        {
            
            
            quantizaOctree = null;
            quantizaDivisao = null;
            quantidadeCoresDivisao = 0;
            objQuantizadoDivisao = null;
            objQuantizadoOctree = null;

            DivisaoQuantizado = false;
            _octreeQuantizado = false;
            HabilitarDesabilitarPainel();

            
            if (_formHistogramasObj != null)
            {
                _formHistogramasObj.Dispose();
                _formHistogramasObj.Close();
            }
            if (_formImagemQuantizadaOctree != null)
            {
                _formImagemQuantizadaOctree.Dispose();
                _formImagemQuantizadaOctree.Close();
            }
            if (_formImagemQuantizadaDivisao != null)
            {
                _formImagemQuantizadaDivisao.Dispose();
                _formImagemQuantizadaDivisao.Close();
            }
            if (_formImagensGeradas != null)
            {
                _formImagensGeradas.Dispose();
                _formImagensGeradas.Close();
            }
        }

        private void numQtdCores_ValueChanged(object sender, EventArgs e)
        {
            LimpaObjetos();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sobre = new Sobre();
            sobre.ShowDialog();
        }

    }
}
