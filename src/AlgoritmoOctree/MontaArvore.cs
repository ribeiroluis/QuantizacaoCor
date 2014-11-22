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

}
