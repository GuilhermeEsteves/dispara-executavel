using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automacao.Common.Utilities.EffectsForm
{
    public static class EffectComponent
    {
        #region Arredondamento

        private static GraphicsPath SuArredondaRect(Rectangle pRect, int pCanto, bool pTopo, bool pBase)
        {
            GraphicsPath gp = new GraphicsPath();

            if (pTopo)
            {
                gp.AddArc(pRect.X - 1, pRect.Y - 1, pCanto, pCanto, 180, 90);
                gp.AddArc(pRect.X + pRect.Width - pCanto, pRect.Y - 1, pCanto, pCanto, 270, 90);
            }
            else
            {
                // Se não arredondar o topo, adiciona as linhas para poder fechar o retangulo junto com
                // a base arredondada
                gp.AddLine(pRect.X - 1, pRect.Y - 1, pRect.X + pRect.Width, pRect.Y - 1);
            }

            if (pBase)
            {
                gp.AddArc(pRect.X + pRect.Width - pCanto, pRect.Y + pRect.Height - pCanto, pCanto, pCanto, 0, 90);
                gp.AddArc(pRect.X - 1, pRect.Y + pRect.Height - pCanto, pCanto, pCanto, 90, 90);
            }
            else
            {
                // Se não arredondar a base, adiciona as linhas para poder fechar o retangulo junto com
                // o topo arredondado. Adiciona da direita para esquerda pois é na ordem contrária que 
                // foi adicionado os arcos do topo. E pra fechar o retangulo tem que desenhar na ordem :
                //  1 - Canto Superior Esquerdo
                //  2 - Canto Superior Direito
                //  3 - Canto Inferior Direito 
                //  4 - Canto Inferior Esquerdo.
                gp.AddLine(pRect.X + pRect.Width, pRect.Y + pRect.Height, pRect.X - 1, pRect.Y + pRect.Height);
            }

            return gp;
        }

        /// <summary>
        /// Arredonda os cantos do Formulário passado como parâmetro (pFormulario).
        /// </summary>
        /// <param name="pCanto">Tamanho arredondamento do canto (Altura x Largura) em pixels.</param>
        /// <param name="pTopo">Indica se faz o arredondamento dos cantos superiores.</param>
        /// <param name="pBase">Indica se faz o arredondamento dos cantos inferiores.</param>
        public static void Arredonda(Form pFormulario, int pCanto, bool pTopo, bool pBase)
        {
            // pCanto -> Tamanho do Canto
            // pTopo -> Arredonda o Topo
            // pBase -> Arredonda a Base
            Rectangle r = new Rectangle();
            r = pFormulario.ClientRectangle;

            pFormulario.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        /// <summary>
        /// Arredonda os cantos do PictureBox passado como parâmetro (pPicture).
        /// </summary>
        /// <param name="pCanto">Tamanho arredondamento do canto (Altura x Largura) em pixels.</param>
        /// <param name="pTopo">Indica se faz o arredondamento dos cantos superiores.</param>
        /// <param name="pBase">Indica se faz o arredondamento dos cantos inferiores.</param>
        public static void Arredonda(PictureBox pPicture, int pCanto, bool pTopo, bool pBase)
        {
            // pCanto -> Tamanho do Canto
            // pTopo -> Arredonda o Topo
            // pBase -> Arredonda a Base
            Rectangle r = new Rectangle();
            r = pPicture.ClientRectangle;

            pPicture.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        /// <summary>
        /// Arredonda os cantos do Painel passado como parâmetro (pPanel).
        /// </summary>
        /// <param name="pCanto">Tamanho arredondamento do canto (Altura x Largura) em pixels.</param>
        /// <param name="pTopo">Indica se faz o arredondamento dos cantos superiores.</param>
        /// <param name="pBase">Indica se faz o arredondamento dos cantos inferiores.</param>
        public static void Arredonda(Panel pPainel, int pCanto, bool pTopo, bool pBase)
        {
            // pCanto -> Tamanho do Canto
            // pTopo -> Arredonda o Topo
            // pBase -> Arredonda a Base
            Rectangle r = new Rectangle();
            r = pPainel.ClientRectangle;

            pPainel.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        /// <summary>
        /// Arredonda os cantos do Botão passado como parâmetro (pButton).
        /// </summary>
        /// <param name="pCanto">Tamanho arredondamento do canto (Altura x Largura) em pixels.</param>
        /// <param name="pTopo">Indica se faz o arredondamento dos cantos superiores.</param>
        /// <param name="pBase">Indica se faz o arredondamento dos cantos inferiores.</param>
        public static void Arredonda(Control pButton, int pCanto, bool pTopo, bool pBase)
        {
            // pCanto -> Tamanho do Canto
            // pTopo -> Arredonda o Topo
            // pBase -> Arredonda a Base
            Rectangle r = new Rectangle();
            r = pButton.ClientRectangle;

            pButton.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        #endregion
    }
}
