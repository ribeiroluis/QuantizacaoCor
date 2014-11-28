using AlgoritimoDivisaoSetores;
using CalculaErro;
using FrequenciaCor;
using AlgoritmoOctree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace AnaliseImagens
{
    public partial class AnaliseImagens : Form
    {
        double erroMedioDivisao;
        int qtdCoresDivisao;
        List<LocalImages> listaImagens;
        List<Quantizacao> listaQuantizadoOctree = new List<Quantizacao>();
        List<Quantizacao> listaQuantizadoDivisao = new List<Quantizacao>();
        int i = 0;

        public AnaliseImagens()
        {
            InitializeComponent();
            listaImagens = LeArquivos();
        }

        private void QuantizaDivisao(Bitmap imagem, string nomeArquivo, int qtdCoresOriginal)
        {
            try
            {
                var quantizaDivisao = new AlgoritimoSetores(imagem, 10); //dez setores
                var erro = new ErrodeQuantizacao(imagem, quantizaDivisao.ImagemQuantizada);
                var objQuantizadoDivisao = new Quantizacao();

                this.qtdCoresDivisao = quantizaDivisao.RecuperaPaletaCorQuantizada().Count;
                this.erroMedioDivisao = erro.Media;

                objQuantizadoDivisao.QuantidadeCoresOriginal = qtdCoresOriginal;
                objQuantizadoDivisao.QuantidadeCoresQuantizadas = this.qtdCoresDivisao;

                objQuantizadoDivisao.DesvioPadrao = erro.DesvioPadrao;
                objQuantizadoDivisao.Media = erro.Media;
                objQuantizadoDivisao.Mediana = erro.Mediana;
                objQuantizadoDivisao.Moda = erro.Moda;
                objQuantizadoDivisao.Variancia = erro.Variancia;

                objQuantizadoDivisao.TempoQuantizacao = quantizaDivisao.TempoTotalQuantizacao.Milliseconds;

                objQuantizadoDivisao.ImagemOriginal = imagem;
                objQuantizadoDivisao.ImagemQuantizada = quantizaDivisao.ImagemQuantizada;
                objQuantizadoDivisao.ImagemErro = erro.GeraImagemErrro(erroMedioDivisao);
                objQuantizadoDivisao.ErrosPorPixel = erro.ErroPorPixel;

                listaQuantizadoDivisao.Add(objQuantizadoDivisao);

                var path = @"C:\temp\Divisao\";
                var pathQuantizado = path + nomeArquivo.Substring(0, 7) + "_DivisaoQuantizada.png";
                var pathErro = path + nomeArquivo.Substring(0, 7) + "_DivisaoErro.png";
                
                objQuantizadoDivisao.ImagemQuantizada.Save(pathQuantizado, System.Drawing.Imaging.ImageFormat.Png);
                objQuantizadoDivisao.ImagemErro.Save(pathErro, System.Drawing.Imaging.ImageFormat.Png);

            }


            catch (Exception)
            {

                throw;
            }


        }

        private void QuantizaOctree(Bitmap imagem, string nomeArquivo, int qtdCoresOriginal)
        {
            try
            {
                var quantizaOctree = new Octree(imagem, qtdCoresDivisao); 
                var erro = new ErrodeQuantizacao(imagem, quantizaOctree.ImagemQuantizada);
                var objQuantizadoOctree = new Quantizacao();

                objQuantizadoOctree.QuantidadeCoresOriginal = qtdCoresOriginal;
                objQuantizadoOctree.QuantidadeCoresQuantizadas = this.qtdCoresDivisao;

                objQuantizadoOctree.DesvioPadrao = erro.DesvioPadrao;
                objQuantizadoOctree.Media = erro.Media;
                objQuantizadoOctree.Mediana = erro.Mediana;
                objQuantizadoOctree.Moda = erro.Moda;
                objQuantizadoOctree.Variancia = erro.Variancia;

                objQuantizadoOctree.TempoQuantizacao = quantizaOctree.TempoTotalQuantizacao.Milliseconds;

                objQuantizadoOctree.ImagemOriginal = imagem;
                objQuantizadoOctree.ImagemQuantizada = quantizaOctree.ImagemQuantizada;
                objQuantizadoOctree.ImagemErro = erro.GeraImagemErrro(erroMedioDivisao);
                objQuantizadoOctree.ErrosPorPixel = erro.ErroPorPixel;

                listaQuantizadoOctree.Add(objQuantizadoOctree);

                var path = @"C:\temp\Octree\";
                var pathQuantizado = path + nomeArquivo.Substring(0, 7) + "_OctreeQuantizada.png";
                var pathErro = path + nomeArquivo.Substring(0, 7) + "_OctreeErro.png";

                objQuantizadoOctree.ImagemQuantizada.Save(pathQuantizado, System.Drawing.Imaging.ImageFormat.Png);
                objQuantizadoOctree.ImagemErro.Save(pathErro, System.Drawing.Imaging.ImageFormat.Png);


            }
            catch (Exception)
            {

                throw;
            }
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

        private List<LocalImages> LeArquivos()
        {
            var imagens = new List<LocalImages>();
            var nome = @"C:\temp\ImagensSalvas\obj";
            var extesion = "__0.png";

            var go = true;
            var i = 1;
            do
            {
                var path = nome + i + extesion;
                if (File.Exists(path))
                {
                    var nomeArquivo = Path.GetFileName(path);

                    var image = new LocalImages();
                    image.Imagem = new Bitmap(path);
                    image.Nome = nomeArquivo;
                    imagens.Add(image);
                }
                else
                    go = false;
                i++;

            } while (go);

            return imagens;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i >= 5){
                timer1.Enabled = false;
                dataDivisao.DataSource = listaQuantizadoDivisao;
                var formOctree = new ResultadoOctree(listaQuantizadoOctree);
                formOctree.Show();
                imgOriginal.Visible = false;
            }
                
            else
            {
                var objectImage = listaImagens[i];
                var qtdCoresOriginal = ContaCores(objectImage.Imagem);
                
                imgOriginal.Image = objectImage.Imagem;
                
                QuantizaDivisao(objectImage.Imagem, objectImage.Nome, qtdCoresOriginal);
                QuantizaOctree(objectImage.Imagem, objectImage.Nome, qtdCoresOriginal);
                
                progressSalvamento.Value += 1;
                i++;
            }
        }
    }

    class LocalImages
    {
        public Bitmap Imagem { get; set; }
        public string Nome { get; set; }
    }
}
