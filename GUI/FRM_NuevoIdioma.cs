using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SL;
using SL.PatronObserver;
using BE;

namespace GUI
{
    public partial class FRM_NuevoIdioma : Form, IObserver
    {
        private IdiomaSL gestorIdioma = new IdiomaSL();
        private string deseaTraducirTexto, operacionPuedeTardarTexto, nuevoIdiomaTexto,
                       advertenciaTexto, errorTexto, datosIncorrectosTexto, cantidadPalabrasTexto;
        public FRM_NuevoIdioma()
        {
            InitializeComponent();
        }
        private void FRM_NuevoIdioma_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify();
        }
        private void FRM_NuevoIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Subject.RemoveObserver(this);
        }
        public void TraducirTexto()
        {
            lblCodIdioma.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 5);
            lblDescripcionIdioma.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 6);
            btnGrabar.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 1);
            this.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 7);
            deseaTraducirTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 14);
            operacionPuedeTardarTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 13);
            nuevoIdiomaTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 12);
            datosIncorrectosTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 11);
            errorTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 9);
            cantidadPalabrasTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 8);
            advertenciaTexto = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 10);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txtCodIdioma.Text) && (!string.IsNullOrWhiteSpace(txtDescripcionIdioma.Text))))
            {
                IdiomaBE idiomaCreado = new IdiomaBE();
                idiomaCreado.CodIdioma = txtCodIdioma.Text;
                idiomaCreado.DescripcionIdioma = txtDescripcionIdioma.Text;
                gestorIdioma.Insertar(idiomaCreado);
                DialogResult rtaTraducirNuevoIdioma = MessageBox.Show(deseaTraducirTexto + "\r(" + operacionPuedeTardarTexto + ")", nuevoIdiomaTexto, MessageBoxButtons.OK);
                if (rtaTraducirNuevoIdioma == DialogResult.OK)
                {
                    try
                    {   //Por ahora traduzco siempre desde el español (según mis pruebas es el más fiable)
                        IdiomaBE español = new IdiomaBE();
                        español.CodIdioma = "es";
                        español.DescripcionIdioma = "Español";
                        int palabrasTraducidas = gestorIdioma.TraducirIdiomaCompleto(español, idiomaCreado);
                        MessageBox.Show(cantidadPalabrasTexto + ": " + palabrasTraducidas.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, errorTexto, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show(datosIncorrectosTexto, advertenciaTexto, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
