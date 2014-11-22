using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantizaImagem
{
    public partial class formHistogramas : Form
    {
        Quantizacao objOctree, objSetores;

        public formHistogramas(Quantizacao objquantizadooctree, Quantizacao objquantizadosetores)
        {
            InitializeComponent();
            objOctree = objquantizadooctree;
            objSetores = objquantizadosetores;
            CarregaImagens();
            CarregaHistogramas();

        }

        private void CarregaHistogramas()
        {
            var histogramaVermelhoOriginal = objSetores.HistogramaImagemOriginal[0];
            var histogramaVerdeOriginal = objSetores.HistogramaImagemOriginal[1];
            var histogramaAzulOriginal = objSetores.HistogramaImagemOriginal[2];

            var histogramaVermelhoQuantizadaSetores = objSetores.HistogramaImagemQuantizada[0];
            var histogramaVerdeQuantizadaSetores = objSetores.HistogramaImagemQuantizada[1];
            var histogramaAzulQuantizadaSetores = objSetores.HistogramaImagemQuantizada[2];

            var histogramaVermelhoQuantizadaOctree = objOctree.HistogramaImagemQuantizada[0];
            var histogramaVerdeQuantizadaOctree = objOctree.HistogramaImagemQuantizada[1];
            var histogramaAzulQuantizadaOctree = objOctree.HistogramaImagemQuantizada[2];

            for (int i = 0; i < 255; i++)
            {
                histogramaImagemOriginal.Series[0].Points.AddXY(i, histogramaVermelhoOriginal[i]);
                histogramaImagemOriginal.Series[1].Points.AddXY(i, histogramaVerdeOriginal[i]);
                histogramaImagemOriginal.Series[2].Points.AddXY(i, histogramaAzulOriginal[i]);

                histogramaImagemQuantizadaDivisao.Series[0].Points.AddXY(i, histogramaVermelhoQuantizadaSetores[i]);
                histogramaImagemQuantizadaDivisao.Series[1].Points.AddXY(i, histogramaVerdeQuantizadaSetores[i]);
                histogramaImagemQuantizadaDivisao.Series[2].Points.AddXY(i, histogramaAzulQuantizadaSetores[i]);

                histogramaImagemQuantizadaOctree.Series[0].Points.AddXY(i, histogramaVermelhoQuantizadaOctree[i]);
                histogramaImagemQuantizadaOctree.Series[1].Points.AddXY(i, histogramaVerdeQuantizadaOctree[i]);
                histogramaImagemQuantizadaOctree.Series[2].Points.AddXY(i, histogramaAzulQuantizadaOctree[i]);

            }
        }

        private void CarregaImagens()
        {
            imagemOriginal.Image = objOctree.ImagemOriginal;
            imagemQuantizadaOctree.Image = objOctree.ImagemQuantizada;
            imagemQuantizadaSetores.Image = objSetores.ImagemQuantizada;
        }
    }
}
