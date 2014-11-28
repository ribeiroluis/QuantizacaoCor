using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseImagens
{
    public partial class ResultadoOctree : Form
    {
        public ResultadoOctree(List<Quantizacao> lista)
        {
            InitializeComponent();
            dataOctree.DataSource = lista;
        }
    }
}
