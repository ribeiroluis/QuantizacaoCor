using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace FrequenciaCor
{
    /// <summary>
    /// Classe que varre uma matriz Bitmap e obtem a frequenca em que as 
    /// cores ocorrem na imagem.
    /// </summary>
    public class Frequencia
    {
        public Frequencia()
        {

        }


        /// <summary>
        /// Retorna a frequencia em que as cores ocorrem em uma imagem do tipo Bitmap
        /// </summary>
        /// <param name="imagem">Bitmap Imagem</param>
        /// <param name="cor">'R': Vermelho, 'G': Verde, 'B': Azul. No formato string</param>
        /// <returns>Retorna um array de inteiros de 255 posiçoes</returns>
        public int[] GetFrequencia(Bitmap imagem, string cor)
        {

            try
            {
                var frequencia = new int[256];

                var largura = imagem.Width;
                var altura = imagem.Height;

                int linha, coluna;

                for (linha = 0; linha < largura; linha++)
                {
                    for (coluna = 0; coluna < altura; coluna++)
                    {
                        int indice = 0;
                        switch (cor)
                        {
                            case "R": indice = imagem.GetPixel(coluna, linha).R; break;
                            case "G": indice = imagem.GetPixel(coluna, linha).G; break;
                            case "B": indice = imagem.GetPixel(coluna, linha).B; break;
                        }

                        if (frequencia[indice] == null || frequencia[indice] == 0)
                        {
                            frequencia[indice] = 1;
                        }
                        else
                        {
                            frequencia[indice] += 1;
                        }
                    }
                }
                return frequencia;
            }
            catch (Exception err)
            {
                
                throw err;
            }
            
        }
    }
}


