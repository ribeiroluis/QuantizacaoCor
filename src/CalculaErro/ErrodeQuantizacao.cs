using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Collections;

namespace CalculaErro
{
    /// <summary>
    /// Classe para cálculo dos erros de quantização
    /// de uma imagem Bitmap.
    /// </summary>
    public class ErrodeQuantizacao
    {
        private Bitmap _imagemOriginal;
        private Bitmap _imagemQuantizada;

        private List<double> _erroPixel;
        private Bitmap _imagemErroQuantizacao;
        private double[,] _matrizErroGerada;
        private double _mediaErroQuantizacao;
        private double _medianaErroQuantizacao;
        private double _desvioPadraoErroQuantizacao;
        private double _varianciaErroQuantizacao;
        private double _modaErroQuantizacao;
        private double _erroPorPixel = 0;

        public Bitmap ImagemOriginal
        {
            set { _imagemOriginal = value; }
        }
        public Bitmap ImagemQuantizada
        {
            set { _imagemQuantizada = value; }
        }
        public double DesvioPadrao
        {
            get
            {
                return _desvioPadraoErroQuantizacao;
            }
        }
        public double Moda
        {
            get
            {
                return _modaErroQuantizacao;
            }
        }
        public double Mediana
        {
            get
            {
                return _medianaErroQuantizacao;
            }
        }
        public double Media
        {
            get
            {
                return _mediaErroQuantizacao;
            }
        }
        public double Variancia
        {
            get
            {
                return _varianciaErroQuantizacao;
            }
        }
        public double ErroPorPixel
        {
            get { return _erroPorPixel; }
        }


        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="imagemOriginal">Imagem original a ser comparada</param>
        /// <param name="imagemQuantizada">Imagem quantizada a ser comparada</param>
        /// <param name="erro">Valor mínimo do erro a considerar</param>
        public ErrodeQuantizacao(Bitmap imagemOriginal, Bitmap imagemQuantizada)
        {
            this._imagemOriginal = imagemOriginal;
            this._imagemQuantizada = imagemQuantizada;
            MontaMatrizErro();
            GetMediaErroQuantizacao();
            GetMedianaErroQuantizacao();
            GetModaErroQuantizacao();
            GetVariancia();
            GetDesvioPadrao();

        }

        /// <summary>
        /// Gera a imagem Erro, mostrando os pontos em vermelho onde houve a distancia superior 
        /// ao erro Médio passado como parâmetro
        /// </summary>
        /// <param name="erro">Média de erro (distancia entre os pixels) encontrada</param>
        /// <returns>Imagem Bitmap de Erro</returns>
        public Bitmap GeraImagemErrro(double erro)
        {
            _imagemErroQuantizacao = new Bitmap(_imagemOriginal.Width, _imagemOriginal.Height);
            double contaErro = 0;

            for (var linha = 0; linha < _imagemOriginal.Width; linha++)
            {
                for (var coluna = 0; coluna < _imagemOriginal.Height; coluna++)
                {
                    //_imagemErroQuantizacao.SetPixel(coluna, linha,
                    //    _matrizErroGerada[coluna, linha] > erro ? Color.Red : Color.White);
                    if (_matrizErroGerada[coluna, linha] > erro)
                    {
                        _imagemErroQuantizacao.SetPixel(coluna, linha, Color.Red);
                        contaErro++; 
                    }
                    else
                        _imagemErroQuantizacao.SetPixel(coluna, linha, Color.White);

                }
            }


            double qtdPixels = _imagemOriginal.Width * _imagemOriginal.Height;
            _erroPorPixel = contaErro / qtdPixels;

            return _imagemErroQuantizacao;
        }

        /// <summary>
        /// Monta a matriz de erro para que a imagem de erro seja gerada
        /// Monta o array de erros (distancia de pixels) da imagem quantizada
        /// </summary>
        private void MontaMatrizErro()
        {
            _matrizErroGerada = new double[this._imagemOriginal.Height, this._imagemOriginal.Width];

            _erroPixel = new List<double>();
            for (var linha = 0; linha < _imagemOriginal.Width; linha++)
            {
                for (var coluna = 0; coluna < _imagemOriginal.Height; coluna++)
                {

                    var vermelhoPq = _imagemOriginal.GetPixel(coluna, linha).R - _imagemQuantizada.GetPixel(coluna, linha).R;
                    var verdePq = _imagemOriginal.GetPixel(coluna, linha).G - _imagemQuantizada.GetPixel(coluna, linha).G;
                    var azulPq = _imagemOriginal.GetPixel(coluna, linha).B - _imagemQuantizada.GetPixel(coluna, linha).B;


                    var distanciaEuclediana = Math.Sqrt(Math.Pow(vermelhoPq, 2) + Math.Pow(verdePq, 2) + Math.Pow(azulPq, 2));
                    var erro = Math.Round(distanciaEuclediana, 2);

                    _erroPixel.Add(erro);

                    _matrizErroGerada[coluna, linha] = erro;

                }
            }
        }

        /// <summary>
        /// Recupera o erro médio da quantização
        /// </summary>
        /// <returns>Valor double (média)</returns>
        private double GetMediaErroQuantizacao()
        {
            var somaErros = _erroPixel.Sum();
            return _mediaErroQuantizacao = Math.Round(somaErros / _erroPixel.Count, 2);
        }

        /// <summary>
        /// Recupera o erro mediano da quantização
        /// </summary>
        /// <returns> Valor double (média)</returns>
        private double GetMedianaErroQuantizacao()
        {
            var listaErros = new List<double>(_erroPixel);
            listaErros.Sort();

            int indice = 0;
            switch (listaErros.Count % 2)
            {
                case 0:
                    indice = listaErros.Count / 2;
                    return _medianaErroQuantizacao = Math.Round((listaErros[indice] + listaErros[indice + 1]) / 2, 2);
                    break;
                default:
                    indice = listaErros.Count / 2;
                    return _medianaErroQuantizacao = Math.Round(listaErros[indice], 2);
                    break;
            }

        }

        /// <summary>
        /// Recupera a moda em que os erros acontecem da quantização
        /// </summary>
        /// <returns>Valor double (moda)</returns>
        private double GetModaErroQuantizacao()
        {
            var listaHash = new Hashtable();
            var listaErros = new List<double>(_erroPixel);

            listaErros.Sort();

            foreach (var item in _erroPixel)
            {
                var contador = Convert.ToInt32(listaHash[item]);
                if (listaHash[item] == null || listaHash.Count == 0)
                {
                    listaHash.Add(item, 1);
                }
                else
                {
                    contador++;
                    listaHash[item] = contador;
                }
            }

            var max = 0;
            var key = 0.0;

            foreach (DictionaryEntry erro in listaHash)
            {
                if (Convert.ToInt32(erro.Value) > max)
                {
                    max = Convert.ToInt32(erro.Value);
                    key = Convert.ToDouble(erro.Key);
                }
            }

            return _modaErroQuantizacao = Math.Round(key, 2);
        }

        /// <summary>
        /// Recupera a variancia em que os erros acontecem
        /// Variância, uma medida de dispersão que mostra quão distantes os valores estão da média
        /// </summary>
        /// <returns>Valor (double) variancia</returns>
        private double GetVariancia()
        {
            var media = _mediaErroQuantizacao;
            var variancia = 0.0;
            foreach (var erro in _erroPixel)
            {
                variancia += Math.Pow((erro - media), 2);
            }

            return _varianciaErroQuantizacao = Math.Round(variancia / _erroPixel.Count, 2);
        }

        /// <summary>
        /// Recupera o Desvio Padrao em que os erros acontecem
        /// Desvio padrão: indica qual é o “erro” se quiséssemos substituir um dos valores coletados pelo valor da média
        /// Um baixo desvio padrão indica que os dados tendem a estar próximos da média; 
        /// um desvio padrão alto indica que os dados estão espalhados por uma gama de valores.
        /// </summary>
        /// <returns>Valor (double) desvio padrão</returns>
        private double GetDesvioPadrao()
        {

            return _desvioPadraoErroQuantizacao = Math.Round(Math.Sqrt(_varianciaErroQuantizacao), 2);

        }


    }
}
