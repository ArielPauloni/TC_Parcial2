using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using SL;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IdiomaBE idioma = new IdiomaBE();
            idioma.CodIdioma = "es";
            idioma.DescripcionIdioma = "Español";
            IdiomaSL gestorIdioma = new IdiomaSL();
            List<TextoBE> textos = gestorIdioma.ListarTextosDelIdioma(idioma);
            idioma.Textos = textos;
            IdiomaSingleton.InstanciarIdioma(idioma);
            Application.Run(new FRM_Principal());
        }
    }
}
