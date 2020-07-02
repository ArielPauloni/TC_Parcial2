using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class IdiomaMapper
    {
        public int Insertar(IdiomaBE idioma)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("CodIdioma", idioma.CodIdioma));
            parametros.Add(AccesoSQL.CrearParametroStr("DescripcionIdioma", idioma.DescripcionIdioma));
            return AccesoSQL.Escribir("pr_Insertar_Idioma", parametros);
        }

        public List<IdiomaBE> Listar()
        {
            List<IdiomaBE> myLista = new List<IdiomaBE>();
            AccesoSQL AccesoSQL = new AccesoSQL();
            DataTable tabla = AccesoSQL.Leer("pr_Listar_Idiomas", null);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    IdiomaBE idioma = new IdiomaBE();
                    idioma.CodIdioma = fila["CodIdioma"].ToString();
                    idioma.DescripcionIdioma = fila["DescripcionIdioma"].ToString();

                    myLista.Add(idioma);
                }
            }
            return myLista;
        }

        public List<TextoBE> ListarTextosDelIdioma(IdiomaBE idioma)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<TextoBE> textos = new List<TextoBE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("CodIdioma", idioma.CodIdioma));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_TextosPorIdioma", parametros);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    TextoBE frase = new TextoBE();
                    frase.IdFrase = short.Parse(fila["IdFrase"].ToString());
                    frase.Texto = fila["Texto"].ToString();
                    textos.Add(frase);
                }
            }
            return textos;
        }

        public int InsertarTexto(IdiomaBE idioma, TextoBE texto)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("CodIdioma", idioma.CodIdioma));
            parametros.Add(AccesoSQL.CrearParametroInt("IdFrase", texto.IdFrase));
            parametros.Add(AccesoSQL.CrearParametroStr("Texto", texto.Texto));
            return AccesoSQL.Escribir("pr_Insertar_Texto", parametros);
        }

        public int EliminarTextosDeIdioma(IdiomaBE idioma)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("CodIdioma", idioma.CodIdioma));
            return AccesoSQL.Escribir("pr_Eliminar_TextosDeIdioma", parametros);
        }
    }
}
