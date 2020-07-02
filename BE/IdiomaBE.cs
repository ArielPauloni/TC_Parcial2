using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IdiomaBE
    {
        private string codIdioma;
        public string CodIdioma
        {
            get { return codIdioma; }
            set { codIdioma = value; }
        }

        private string descripcionIdioma;
        public string DescripcionIdioma
        {
            get { return descripcionIdioma; }
            set { descripcionIdioma = value; }
        }

        private List<TextoBE> textos;
        public List<TextoBE> Textos
        {
            get { return textos; }
            set { textos = value; }
        }
        public override string ToString()
        { return DescripcionIdioma + " (" + CodIdioma + ")"; }
    }
}
