using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAjedrez
{
    public partial class FrmMenuPrincipal : Form
    {
        public static int x = 0;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void optJugadores_Click(object sender, EventArgs e)
        {
            if (x==0)
            {
                FrmJugadores j = new FrmJugadores();
                j.MdiParent = this;
                j.Show();
                x++;
            }
        }

        private void optArbitros_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmArbitro a = new FrmArbitro();
                a.MdiParent = this;
                a.Show();
                x++;
            }
        }

        private void optPaises_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmPais p = new FrmPais();
                p.MdiParent = this;
                p.Show();
                x++;
            }
        }

        private void optHoteles_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmHotel h = new FrmHotel();
                h.MdiParent = this;
                h.Show();
                x++;
            }
        }

        private void optRevervaciones_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmReservaciones r = new FrmReservaciones();
                r.MdiParent = this;
                r.Show();
                x++;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmSalas s = new FrmSalas();
                s.MdiParent = this;
                s.Show();
                x++;
            }
        }

        private void optPartidas_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmPartidas p = new FrmPartidas();
                p.MdiParent = this;
                p.Show();
                x++;
            }
        }

        private void optMovimientos_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmMovimientos m = new FrmMovimientos();
                m.MdiParent = this;
                m.Show();
                x++;
            }
        }

        private void optCampionatos_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                FrmCampeonatos c = new FrmCampeonatos();
                c.MdiParent = this;
                c.Show();
                x++;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
