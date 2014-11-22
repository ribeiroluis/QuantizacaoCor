using AlgoritimoDivisaoSetores;
using AlgoritmoOctree;
using FrequenciaCor;
using CalculaErro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuantizaImagem;


namespace ColorQuantization
{
    public partial class QuantizaImagem : Form
    {
        bool OctreeQuantizado;
        bool DivisaoQuantizado;
        double erroMedioDivisao;
        Octree quantizaOctree;
        AlgoritimoSetores quantizaDivisao;
        Bitmap ImagemOriginal;
        int quantidadeCoresDivisao = 0;
        Quantizacao objQuantizadoDivisao;
        Quantizacao objQuantizadoOctree;
        Form formHistogramasObj, formImagemQuantizadaOctree, formImagemQuantizadaDivisao, formImagensGeradas;

        public QuantizaImagem()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuantizaOctree_Click(object sender, EventArgs e)
        {
            try
            {
                if (quantizaDivisao == null)
                    QuantizaDivisao();

                if (quantizaOctree == null)
                    QuantizaOctree();

                if (formImagemQuantizadaOctree != null)
                {
                    formImagemQuantizadaOctree.Dispose();
                    formImagemQuantizadaOctree.Close();
                }


                formImagemQuantizadaOctree = new formImagemQuantizada("Octree", objQuantizadoOctree);
                formImagemQuantizadaOctree.Show();


                OctreeQuantizado = true;
                habilitarDesabilitarPainel();

                

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


                if (formImagemQuantizadaDivisao != null)
                {
                    formImagemQuantizadaDivisao.Dispose();
                    formImagemQuantizadaDivisao.Close();
                }



                formImagemQuantizadaDivisao = new formImagemQuantizada("Divisão Setores", objQuantizadoDivisao);
                formImagemQuantizadaDivisao.Show();

                

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

                OpenFileDialog abrirImagem = new OpenFileDialog();
                abrirImagem.Filter = "Arquivos de imagem(*.bmp, *.jpg, *.png)|*.bmp;*.jpg; *.png";
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

        private void habilitarDesabilitarPainel()
        {
            if (DivisaoQuantizado && OctreeQuantizado)
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
                if (formImagensGeradas != null)
                {
                    formImagensGeradas.Dispose();
                    formImagensGeradas.Close();
                }



                formImagensGeradas = new formImagensGeradas(objQuantizadoOctree, objQuantizadoDivisao);
                formImagensGeradas.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHistogramas_Click(object sender, EventArgs e)
        {
            if (formHistogramasObj != null)
            {
                formHistogramasObj.Dispose();
                formHistogramasObj.Close();
            }



            formHistogramasObj = new formHistogramas(objQuantizadoOctree, objQuantizadoDivisao);
            formHistogramasObj.Show();

        }

        private int ContaCores(Bitmap imagem)
        {
            var listaCor = new List<Color>();

            for (int linha = 0; linha < imagem.Height; linha++)
            {
                for (int coluna = 0; coluna < imagem.Width; coluna++)
                {
                    var cor = imagem.GetPixel(coluna, linha);
                    if (!listaCor.Contains(cor))
                    {
                        listaCor.Add(cor);
                    }

                }

            }


            return listaCor.Count;

        }

        private void QuantizaDivisao()
        {
            try
            {
                quantizaDivisao = new AlgoritimoSetores(ImagemOriginal, Convert.ToInt32(numQtdCores.Value));
                var erro = new ErrodeQuantizacao(ImagemOriginal, quantizaDivisao.ImagemQuantizada);
                var histograma = new Frequencia();
                objQuantizadoDivisao = new Quantizacao();

                this.erroMedioDivisao = erro.Media;
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
                
                objQuantizadoDivisao.HistogramaImagemOriginal = new List<int[]>();
                objQuantizadoDivisao.HistogramaImagemQuantizada = new List<int[]>();
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "R"));
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "G"));
                objQuantizadoDivisao.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "B"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "R"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "G"));
                objQuantizadoDivisao.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaDivisao.ImagemQuantizada, "B"));

                DivisaoQuantizado = true;
                habilitarDesabilitarPainel();

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
                quantizaOctree = new Octree(ImagemOriginal, quantidadeCoresDivisao);
                var erro = new ErrodeQuantizacao(ImagemOriginal, quantizaOctree.ImagemQuantizada);
                var histograma = new Frequencia();
                objQuantizadoOctree = new Quantizacao();


                objQuantizadoOctree.QuantidadeCoresOriginal = int.Parse(qtdCoresOriginal.Text);
                objQuantizadoOctree.QuantidadeCoresQuantizadas = quantidadeCoresDivisao;
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

                objQuantizadoOctree.HistogramaImagemOriginal = new List<int[]>();
                objQuantizadoOctree.HistogramaImagemQuantizada = new List<int[]>();
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "R"));
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "G"));
                objQuantizadoOctree.HistogramaImagemOriginal.Add(histograma.GetFrequencia(ImagemOriginal, "B"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "R"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "G"));
                objQuantizadoOctree.HistogramaImagemQuantizada.Add(histograma.GetFrequencia(quantizaOctree.ImagemQuantizada, "B"));
                

                OctreeQuantizado = true;
                habilitarDesabilitarPainel();

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
            OctreeQuantizado = false;
            habilitarDesabilitarPainel();

            
            if (formHistogramasObj != null)
            {
                formHistogramasObj.Dispose();
                formHistogramasObj.Close();
            }
            if (formImagemQuantizadaOctree != null)
            {
                formImagemQuantizadaOctree.Dispose();
                formImagemQuantizadaOctree.Close();
            }
            if (formImagemQuantizadaDivisao != null)
            {
                formImagemQuantizadaDivisao.Dispose();
                formImagemQuantizadaDivisao.Close();
            }
            if (formImagensGeradas != null)
            {
                formImagensGeradas.Dispose();
                formImagensGeradas.Close();
            }
        }

        private void numQtdCores_ValueChanged(object sender, EventArgs e)
        {
            LimpaObjetos();
        }

    }
}
