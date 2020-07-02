using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IdiomaSingleton
    {
        private static IdiomaSingleton _instancia;
        public static IdiomaBE IdiomaSeteado = new IdiomaBE();

        protected IdiomaSingleton(IdiomaBE idioma)
        {
            IdiomaSeteado = idioma;
        }

        public static IdiomaSingleton InstanciarIdioma(IdiomaBE idioma)
        {
            if (_instancia == null)
            {
                _instancia = new IdiomaSingleton(idioma);
            }
            return _instancia;
        }
    }
}
