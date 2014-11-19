using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlgoritmoOctree
{
    #region Algoritimo Original
    internal class NoOctree
    {
        private static readonly Byte[] MascaraBytes = new Byte[] { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };

        private int _rVermelho;
        private int _gVerde;
        private int _bAzul;

        private int _contaPixel;
        private int _indicePaletaCor;

        private readonly NoOctree[] _nos;

        public NoOctree(int nivelNo, QuantizaOctree paiQuantizer) //level - level of parent
        {
            _nos = new NoOctree[8];

            if (nivelNo < 7)
            {
                paiQuantizer.AdicionaNo(nivelNo, this);
            }
        }

        public Boolean VerificaFolha
        {
            get { return _contaPixel > 0; }
        }

        public Color Cor
        {
            get
            {
                Color cor;

                // determines a color of the leaf
                if (VerificaFolha)
                {
                    cor = _contaPixel == 1 ?
                        Color.FromArgb(255, _rVermelho, _gVerde, _bAzul) :
                        Color.FromArgb(255, _rVermelho / _contaPixel, _gVerde / _contaPixel, _bAzul / _contaPixel);
                }
                else
                {
                    throw new InvalidOperationException("Cannot retrieve a color for other node than leaf.");
                }

                return cor;
            }
        }

        public int ContaPixelNosAtivos
        {
            get
            {
                int result = _contaPixel;

                // sums up all the pixel presence for all the active nodes
                for (var i = 0; i < 8; i++)
                {
                    NoOctree node = _nos[i];

                    if (node != null)
                    {
                        result += node._contaPixel;
                    }
                }

                return result;
            }
        }

        public IEnumerable<NoOctree> NosAtivos
        {
            get
            {
                List<NoOctree> listaNos = new List<NoOctree>();

                // adds all the active sub-nodes to a list
                for (var i = 0; i < 8; i++)
                {
                    NoOctree no = _nos[i];

                    if (no != null)
                    {
                        if (no.VerificaFolha)
                        {
                            listaNos.Add(no);
                        }
                        else
                        {
                            listaNos.AddRange(no.NosAtivos);
                        }
                    }
                }

                return listaNos;
            }
        }

        /// <summary>
        /// Adiciona cor no nó
        /// </summary>
        /// <param name="cor">Cor a ser adicionada</param>
        /// <param name="nivelNo">nível do nó</param>
        /// <param name="noPai">nó pai</param>
        public void AdicionaCorNo(Color cor, int nivelNo, QuantizaOctree noPai)
        {
            if (nivelNo == 8)
            {
                _rVermelho += cor.R;
                _gVerde += cor.G;
                _bAzul += cor.B;
                _contaPixel++;
            }
            else if (nivelNo < 8) 
            {
                var indice = RecuperaIndiceCor(cor, nivelNo); 
                if (_nos[indice] == null)
                {
                    _nos[indice] = new NoOctree(nivelNo, noPai);
                }
                _nos[indice].AdicionaCorNo(cor, nivelNo + 1, noPai);
            }
        }

        public int RecuperaIndicePaletaCor(Color cor, int nivelNo)
        {
            int indice;

            // if a node is leaf, then we've found the best match already
            if (VerificaFolha)
            {
                indice = _indicePaletaCor;
            }
            else // otherwise continue in to the lower depths
            {
                int i = RecuperaIndiceCor(cor, nivelNo);

                indice = _nos[i] != null ? _nos[i].RecuperaIndicePaletaCor(cor, nivelNo + 1) : _nos.First(node => node != null).
                    RecuperaIndicePaletaCor(cor, nivelNo + 1);
            }

            return indice;
        }

        public int RemoveFolhas()
        {
            int resultado = 0;

            // scans thru all the active nodes
            for (int i = 0; i < 8; i++)
            {
                NoOctree no = _nos[i];

                if (no != null)
                {
                    // sums up their color components
                    _rVermelho += no._rVermelho;
                    _gVerde += no._gVerde;
                    _bAzul += no._bAzul;

                    // and pixel presence
                    _contaPixel += no._contaPixel;

                    // increases the count of reduced nodes
                    resultado++;
                }
            }

            // returns a number of reduced sub-nodes, minus one because this node becomes a leaf
            return resultado - 1;
        }

        private static int RecuperaIndiceCor(Color cor, int nivelNo)
        {
            return ((cor.R & MascaraBytes[nivelNo]) == MascaraBytes[nivelNo] ? 4 : 0) |
                   ((cor.G & MascaraBytes[nivelNo]) == MascaraBytes[nivelNo] ? 2 : 0) |
                   ((cor.B & MascaraBytes[nivelNo]) == MascaraBytes[nivelNo] ? 1 : 0);
        }

        internal void SetaIndicePaletaCor(int indice)
        {
            _indicePaletaCor = indice;
        }
    }
    #endregion

    #region Algoritimo alterado
    //internal class Arvore
    //{
        //private static readonly Byte[] mascara = new Byte[] { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
        //int vermelho;
        //int verde;
        //int azul;

        ///// <summary>
        ///// Contador de cores adicionadas à arvore
        ///// </summary>
        //int NP;


        //int indicePaletaCor;

        //Arvore[] Nos;

        //public Arvore(int nivel, Quantiza noPai)
        //{
        //    Nos = new Arvore[8];
        //    if (nivel < 7)
        //    {
        //        noPai.AdicionaNivelNo(nivel, this);
        //    }
        //}

        //public bool folha
        //{
        //    get { return NP > 0; }
        //}

        ///// <summary>
        ///// Retorna a cor da folha
        ///// </summary>
        //public Color cor
        //{
        //    get
        //    {
        //        Color resultado;


        //        if (folha)
        //        {
        //            resultado = NP == 1 ?
        //                Color.FromArgb(255, vermelho, verde, azul) :
        //                Color.FromArgb(255, vermelho / NP, verde / NP, azul / NP);
        //        }
        //        else
        //        {
        //            throw new InvalidOperationException("Cannot retrieve a color for other node than leaf.");
        //        }

        //        return resultado;
        //    }
        //}

        ///// <summary>
        ///// sums up all the pixel presence for all the active nodes
        ///// </summary>
        //public int contadorDeCoresNo
        //{
        //    get
        //    {
        //        int resultado = NP;


        //        for (int i = 0; i < 8; i++)
        //        {
        //            Arvore no = Nos[i];

        //            if (no != null)
        //            {
        //                resultado += no.NP;
        //            }
        //        }

        //        return resultado;
        //    }
        //}

        ///// <summary>
        ///// adds all the active sub-nodes to a list
        ///// </summary>
        //public IEnumerable<Arvore> SubCubosAtivos
        //{
        //    get
        //    {
        //        List<Arvore> _arvore = new List<Arvore>();

        //        for (int i = 0; i < 8; i++)
        //        {
        //            Arvore _no = Nos[i];

        //            if (_no != null)
        //            {
        //                if (_no.folha)
        //                {
        //                    _arvore.Add(_no);
        //                }
        //                else
        //                {
        //                    _arvore.AddRange(_no.SubCubosAtivos);
        //                }
        //            }
        //        }

        //        return _arvore;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="cor"></param>
        ///// <param name="nivel"></param>
        ///// <param name="noPai"></param>
        //public void AdicionaCor(Color cor, int nivel, Quantiza noPai) //level - depth level
        //{
        //    // if this node is a leaf, then increase a color amount, and pixel presence
        //    if (nivel == 8)
        //    {
        //        vermelho += cor.R;
        //        verde += cor.G;
        //        azul += cor.B;
        //        NP++;
        //    }
        //    else if (nivel < 8) // otherwise goes one level deeper
        //    {
        //        // calculates an index for the next sub-branch
        //        int index = GetIndexSubCubo(cor, nivel); //current level

        //        // if that branch doesn't exist, grows it
        //        if (Nos[index] == null)
        //        {
        //            Nos[index] = new Arvore(nivel, noPai);
        //        }

        //        // adds a color to that branch
        //        Nos[index].AdicionaCor(cor, nivel + 1, noPai);
        //    }
        //}

        //public int GeraPaletadeCor(Color cor, int nivel)
        //{
        //    int resultado;

        //    // if a node is leaf, then we've found the best match already
        //    if (folha)
        //    {
        //        resultado = indicePaletaCor;
        //    }
        //    else // otherwise continue in to the lower depths
        //    {
        //        int index = GetIndexSubCubo(cor, nivel);

        //        resultado = Nos[index] != null ? 
        //            Nos[index].GeraPaletadeCor(cor, nivel + 1) :
        //            Nos.Where(node => node != null).First().GeraPaletadeCor(cor, nivel + 1);
        //    }

        //    return resultado;
        //}

        ///// <summary>
        ///// Reduz o número de cubos quando excede o nivel máximo '8'
        ///// </summary>
        ///// <returns></returns>

        //public int RemoveSubCubo()
        //{
        //    int resultado = 0;

        //    // scans thru all the active nodes
        //    for (int index = 0; index < 8; index++)
        //    {
        //        Arvore _no = Nos[index];

        //        if (_no != null)
        //        {
        //            // sums up their color components
        //            vermelho += _no.vermelho;
        //            verde += _no.verde;
        //            azul += _no.azul;

        //            // and pixel presence
        //            NP += _no.NP;

        //            // increases the count of reduced nodes
        //            resultado++;
        //        }
        //    }

        //    // returns a number of reduced sub-nodes, minus one because this node becomes a leaf
        //    return resultado - 1;
        //}

        //private static int GetIndexSubCubo(Color cor, int nivel)
        //{
        //    return ((cor.R & mascara[nivel]) == mascara[nivel] ? 4 : 0) |
        //           ((cor.G & mascara[nivel]) == mascara[nivel] ? 2 : 0) |
        //           ((cor.B & mascara[nivel]) == mascara[nivel] ? 1 : 0);
        //}

        //internal void SetaIndicePaletadeCor(int indice)
        //{
        //    indicePaletaCor = indice;
        //}
    //}
    #endregion
}
