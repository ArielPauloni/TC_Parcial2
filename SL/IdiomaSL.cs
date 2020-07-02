using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using DAL;
using BE;

namespace SL
{
    public class IdiomaSL
    {
        public int Insertar(IdiomaBE idioma)
        {
            IdiomaMapper m = new IdiomaMapper();
            return m.Insertar(idioma);
        }

        public List<IdiomaBE> ListarIdiomas()
        {
            IdiomaMapper m = new IdiomaMapper();
            return m.Listar();
        }

        public string TraducirTexto(IdiomaBE idioma, int codTexto)
        {
            string TextoTraducido = string.Empty;

            foreach (TextoBE texto in idioma.Textos)
            {
                if (texto.IdFrase == codTexto)
                {
                    TextoTraducido = texto.Texto;
                }
            }
            return TextoTraducido;
        }
        public List<TextoBE> ListarTextosDelIdioma(IdiomaBE idioma)
        {
            IdiomaMapper m = new IdiomaMapper();
            return m.ListarTextosDelIdioma(idioma);
        }

        /// <summary>
        /// Este método traduce al lenguaje de destino, todas las palabras del lenguaje origen
        /// </summary>
        /// <param name="idiomaOrigen"></param>
        /// <param name="idiomaDestino"></param>
        public int TraducirIdiomaCompleto(IdiomaBE idiomaOrigen, IdiomaBE idiomaDestino)
        {
            int retVal = 0;
            try
            {
                IdiomaMapper m = new IdiomaMapper();
                List<TextoBE> textosOrigen = ListarTextosDelIdioma(idiomaOrigen);
                HttpClient client = new HttpClient();
                //Por las dudas borro antes lo del destino, por si reutilizo esta función en otro momento
                m.EliminarTextosDeIdioma(idiomaDestino);
                foreach (TextoBE text in textosOrigen)
                {
                    string requestStr = String.Format("?q={0}&langpair={1}|{2}", text.Texto, idiomaOrigen.CodIdioma, idiomaDestino.CodIdioma);

                    TranslationResponse.Rootobject tResponse = new TranslationResponse.Rootobject();
                    string jsonResp = client.GetStringAsync("https://api.mymemory.translated.net/get" + requestStr).Result;
                    tResponse = JsonConvert.DeserializeObject<TranslationResponse.Rootobject>(jsonResp);

                    if (tResponse != null)
                    {
                        //if matches.count??
                        TextoBE textoTraducido = new TextoBE();
                        textoTraducido.IdFrase = text.IdFrase;
                        textoTraducido.Texto = tResponse.responseData.translatedText;
                        retVal += m.InsertarTexto(idiomaDestino, textoTraducido);
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: crear nueva excepción específica
                throw ex;
            }
            return retVal;
        }
    }
}
