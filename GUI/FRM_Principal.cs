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
    public partial class FRM_Principal : Form, IObserver
    {
        private IdiomaSL gestorIdioma = new IdiomaSL();
        public FRM_Principal()
        {
            InitializeComponent();
        }
        public void TraducirTexto()
        {
            lblIdioma.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 2);
            btnCrearIdioma.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 4);
            this.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 3) + " - " +
                gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 15);
            llblAcercaDe.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 16);
        }
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            ActualizarListaIdiomas();
            Subject.AddObserver(this);
            Subject.Notify();
        }
        private void FRM_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Subject.RemoveObserver(this);
        }
        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdiomaSingleton.IdiomaSeteado.CodIdioma != ((IdiomaBE)cboIdioma.SelectedItem).CodIdioma)
            {
                IdiomaBE idiomaSeleccionado = (IdiomaBE)cboIdioma.SelectedItem;
                idiomaSeleccionado.Textos = gestorIdioma.ListarTextosDelIdioma(idiomaSeleccionado);
                IdiomaSingleton.IdiomaSeteado = idiomaSeleccionado;
            }
            Subject.Notify();
        }
        private void ActualizarListaIdiomas()
        {
            cboIdioma.DataSource = gestorIdioma.ListarIdiomas();
            cboIdioma.SelectedIndex = cboIdioma.FindStringExact(IdiomaSingleton.IdiomaSeteado.ToString());
        }
        private void btnCrearIdioma_Click(object sender, EventArgs e)
        {
            FRM_NuevoIdioma frmCambiarIdioma = new FRM_NuevoIdioma();
            frmCambiarIdioma.ShowDialog();
            ActualizarListaIdiomas();
        }
        private void llblAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_AcercaDe frmAcercaDe = new FRM_AcercaDe();
            frmAcercaDe.Show();
        }
    }
}
