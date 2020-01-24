using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitusTyoRistinolla
{
    public partial class PeliLoppu : Form
    {
        Ristinolla ristinollaPeli;
        public PeliLoppu(Ristinolla ristinolla)
        {
            InitializeComponent();
            ristinollaPeli = ristinolla;
            lblTasapelit.Text = "Tasapelit: " 
                +ristinolla.haeTiedostostaTulokset("tasapelit");
            lblVoitot.Text = "Voitot: "
                + ristinolla.haeTiedostostaTulokset("voitot");
            lblHaviot.Text = "Haviöt: "
                + ristinolla.haeTiedostostaTulokset("haviot");
            lblIlmoitus.Text = ristinolla.getVoittaja();
        }

        private void btnPoistuPelista_Click(object sender, EventArgs e)
        {
            //this.Close();
            //ristinollaPeli.Close();
            Environment.Exit(1);
        }

        private void btnPalaaMenuun_Click(object sender, EventArgs e)
        {
            this.Close();
            ristinollaPeli.Close();
            //MenuIkkuna menuIkkuna = new MenuIkkuna();
            //menuIkkuna.ShowDialog();
            //this.Close();
        }

        private void btnPelaaUudestaan_Click(object sender, EventArgs e)
        {
            this.Close();
            ristinollaPeli.alustaPeli();
        }
    }
}
