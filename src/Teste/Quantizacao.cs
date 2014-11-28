using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnaliseImagens
{
    public class Quantizacao
    {
        public double DesvioPadrao { get; set; }
        public double Media { get; set; }
        public double Mediana { get; set; }
        public double Moda { get; set; }
        public double Variancia { get; set; }
        public int TempoQuantizacao { get; set; }
        public double ErrosPorPixel { get; set; }

        public Bitmap ImagemOriginal { get; set; }
        public Bitmap ImagemQuantizada { get; set; }
        public Bitmap ImagemErro { get; set; }
        public List<Color> CoresQuantizadas { get; set; }
        public int QuantidadeCoresQuantizadas { get; set; }
        public int QuantidadeCoresOriginal { get; set; }

        public List<int[]> HistogramaImagemOriginal { get; set; }
        public List<int[]> HistogramaImagemQuantizada { get; set; }
        public string Path { get; set; }

    }
}
