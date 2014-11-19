using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritimoDivisaoSetores
{
    public class AlgoritimoSetores
    {
        /*
         * A quantidade de cores não condiz com o repassado ao algoritmo
         * 1 - 1
         * 2 - 6
         * 3 - 18
         * 4 - 28
         * 5 - 49
         */



        private Bitmap ImagemOriginal;
        private int Cores;
        private List<Color> PaletaQuantizada = new List<Color>();
        private Bitmap _imagemQuantizada;
        private TimeSpan tempoQuantizacao;
        
        public TimeSpan TempoTotalQuantizacao
        {
            get { return tempoQuantizacao; }
        }

        /// <summary>
        /// Retorna a imagem Quantizada
        /// </summary>
        public Bitmap ImagemQuantizada
        {
            get { return _imagemQuantizada; }
        }

        /// <summary>
        /// Quantiza a imagem quantizada
        /// </summary>
        /// <param name="_imagem">Imagem a ser quantizada</param>
        /// <param name="bits">Quantidade de cores a ser quantizada</param>
        public AlgoritimoSetores(Bitmap _imagem, int _cores)
        {
            try
            {
                ImagemOriginal = _imagem;
                Cores = _cores;
                Quantizar();
            }
            catch (Exception err)
            {

                throw err;
            }

        }

        /// <summary>
        /// Quantiza a imagem pelo algoritimo de regioes/divisao espacial
        /// 
        /// Referência: http://www.inf.ufrgs.br/~jwkmello/tudo/trab_fpi.html
        /// </summary>
        /// <returns>Imagem quantizada</returns>
        private Bitmap Quantizar()
        {

            try
            {
                var inicial = DateTime.Now;


                if (Cores > 256)
                    Cores = 256;
                else if (Cores <= 0)
                    Cores = 1;

                var distancia = 256 / Cores;
                var largura = ImagemOriginal.Width;
                var altura = ImagemOriginal.Height;

                var novoVermelho = 0;
                var novoVerde = 0;
                var novoAzul = 0;

                var Vermelho = 0;
                var Verde = 0;
                var Azul = 0;

                var novaImagem = new Bitmap(ImagemOriginal.Width, ImagemOriginal.Height);

                int linha, coluna;

                for (linha = 0; linha < largura; linha++)
                {
                    for (coluna = 0; coluna < altura; coluna++)
                    {
                        Vermelho = ImagemOriginal.GetPixel(coluna, linha).R / distancia;
                        Verde = ImagemOriginal.GetPixel(coluna, linha).G / distancia;
                        Azul = ImagemOriginal.GetPixel(coluna, linha).B / distancia;

                        novoVermelho = Vermelho * distancia + (distancia / 2);
                        novoVerde = Verde * distancia + (distancia / 2);
                        novoAzul = Azul * distancia + (distancia / 2);

                        if (novoVermelho > 255)
                            novoVermelho = 255;

                        if (novoVerde > 255)
                            novoVerde = 255;

                        if (novoAzul > 255)
                            novoAzul = 255;

                        novaImagem.SetPixel(coluna, linha, Color.FromArgb(novoVermelho, novoVerde, novoAzul));
                    }
                }

                var final = DateTime.Now;

                tempoQuantizacao = final - inicial;

                _imagemQuantizada = novaImagem;

                return _imagemQuantizada;

            }
            catch (Exception err)
            {

                throw err;
            }



        }


        public List<Color> RecuperaPaletaCorQuantizada()
        {
            if (_imagemQuantizada == null)
                Quantizar();

            for (int linha = 0; linha < _imagemQuantizada.Height; linha++)
            {
                for (int coluna = 0; coluna < _imagemQuantizada.Width; coluna++)
                {
                    var cor = _imagemQuantizada.GetPixel(coluna, linha);
                    if (!PaletaQuantizada.Contains(cor))
                    {
                        PaletaQuantizada.Add(cor);
                    }

                }

            }


            return PaletaQuantizada;
        }
    }
}
