using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOctree
{
    public class Octree
    {
        #region AlgoritimoOriginal
        private QuantizaOctree quantiza = new QuantizaOctree();
        private List<Color> paletaQuantizada = new List<Color>();
        private Bitmap imagemOriginal;
        
        private int largura, altura;
        private Bitmap imagemQuantizada;
        private TimeSpan tempoQuantizacao;


        public TimeSpan TempoTotalQuantizacao
        {
            get { return tempoQuantizacao; }
        }

        public Bitmap ImagemQuantizada { get { return imagemQuantizada; } }

        public Octree(Bitmap _imagemOriginal, int quantCores)
        {
            imagemOriginal = _imagemOriginal;

            altura = imagemOriginal.Height;
            largura = imagemOriginal.Width;
            quantiza.LimpaArvore();


            var inicial = DateTime.Now;

            for (int linha = 0; linha < largura; linha++)
                for (int coluna = 0; coluna < altura; coluna++)
                {
                    Color c = imagemOriginal.GetPixel(linha, coluna);
                    quantiza.AdicionaCor(c);
                }

            paletaQuantizada = quantiza.GeraPaletaCor(quantCores);
            imagemQuantizada = new Bitmap(largura, altura);
            
            for (var y = 0; y < altura; y++)
                for (var x = 0; x < largura; x++)
                {
                    imagemQuantizada.SetPixel(x, y, paletaQuantizada[quantiza.RecuperaIndicePaletaCor(imagemOriginal.GetPixel(x, y))]);
                }
            var final = DateTime.Now;

            tempoQuantizacao = final - inicial;
        }

        public List<Color> RecuperaPaletaCorQuantizada()
        {
            return paletaQuantizada;
        }

        #endregion      

    }
}
