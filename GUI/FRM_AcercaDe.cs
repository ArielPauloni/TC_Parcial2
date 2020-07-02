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
    public partial class FRM_AcercaDe : Form, IObserver
    {
        private IdiomaSL gestorIdioma = new IdiomaSL();
        public FRM_AcercaDe()
        {
            InitializeComponent();
        }
        public void TraducirTexto()
        {
            this.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 16);
            lblFecha.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 17) + ": " + DateTime.Now.ToString("dd/MM/yyyy");
            lblMateria.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 18) + ": Trabajo de campo";
            lblRealizadoPor.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 19) + ": Ariel Pauloni";
            txtTextoAMostrar.Text = gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 20) + ". " + "\r" +
                gestorIdioma.TraducirTexto(IdiomaSingleton.IdiomaSeteado, 21);
        }
        private void FRM_AcercaDe_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify();
        }
        private void FRM_AcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Subject.RemoveObserver(this);
        }
    }
}
