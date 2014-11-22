using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOctree
{
    #region Algoritimo Original
    public class QuantizaOctree
    {

        private NoOctree _noRaiz;
        private List<NoOctree>[] _nosFolhas;

        public QuantizaOctree()
        {
            IniciaArvore();
        }

        public void Inicializar()
        {
            _nosFolhas = new List<NoOctree>[7];
            // creates the octree level lists
            for (var i = 0; i < 7; i++)
            {
                _nosFolhas[i] = new List<NoOctree>();
            }
            _noRaiz = new NoOctree(0, this);
        }

        internal IEnumerable<NoOctree> Folhas
        {
            get { return _noRaiz.NosAtivos.Where(node => node.VerificaFolha); }
        }

        internal void AdicionaNo(int nivel, NoOctree noArvore)
        {
            _nosFolhas[nivel].Add(noArvore);
        }

        public void AdicionaCor(Color cor)
        {
            _noRaiz.AdicionaCorNo(cor, 0, this);
        }
        
        /// <summary>
        /// Inicializa a árvore com 8 nós
        /// </summary>
        private void IniciaArvore()
        {
            _nosFolhas = new List<NoOctree>[7];
            for (var i = 0; i < 7; i++)
            {
                _nosFolhas[i] = new List<NoOctree>();
            }
            _noRaiz = new NoOctree(0, this);
        }

        public void LimpaArvore()
        {
            IniciaArvore();
        }

        public List<Color> GeraPaletaCor(int qtdCores)
        {
            List<Color> listaCores = new List<Color>();
            var numeroFolhas = Folhas.Count();
            var indicePaleta = 0;

            // goes thru all the levels starting at the deepest, and goes upto a root level
            for (var nivel = 6; nivel >= 0; nivel--)
            {
                // if level contains any node
                if (_nosFolhas[nivel].Count > 0)
                {
                    // orders the level node list by pixel presence (those with least pixels are at the top)
                    IEnumerable<NoOctree> listaNosOrdenada = _nosFolhas[nivel].OrderBy(no => no.ContaPixelNosAtivos);

                    // removes the nodes unless the count of the leaves is lower or equal than our requested color count
                    foreach (NoOctree no in listaNosOrdenada)
                    {
                        // removes a node
                        numeroFolhas -= no.RemoveFolhas();

                        // if the count of leaves is lower then our requested count terminate the loop
                        if (numeroFolhas <= qtdCores) break;
                    }

                    // if the count of leaves is lower then our requested count terminate the level loop as well
                    if (numeroFolhas <= qtdCores) break;

                    // otherwise clear whole level, as it is not needed anymore
                    _nosFolhas[nivel].Clear();
                }
            }

            // goes through all the leaves that are left in the tree (there should now be less or equal than requested)
            foreach (NoOctree no in Folhas.OrderByDescending(no => no.ContaPixelNosAtivos))
            {
                if (indicePaleta >= qtdCores) break;

                // adds the leaf color to a palette
                if (no.VerificaFolha)
                {
                    listaCores.Add(no.Cor);
                }

                // and marks the node with a palette index
                no.SetaIndicePaletaCor(indicePaleta++);
            }

            // we're unable to reduce the Octree with enough precision, and the leaf count is zero
            if (listaCores.Count == 0)
            {
                throw new NotSupportedException("The Octree contains after the reduction 0 colors.");
            }

            // returns the palette
            return listaCores;
        }

        public int RecuperaIndicePaletaCor(Color cor)
        {
            // retrieves a palette index
            return _noRaiz.RecuperaIndicePaletaCor(cor, 0);
        }
    }
    #endregion

}
