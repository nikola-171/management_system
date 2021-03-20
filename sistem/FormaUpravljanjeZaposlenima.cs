using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem
{
    public partial class FormaUpravljanjeZaposlenima : Form
    {
        public FormaUpravljanjeZaposlenima()
        {
            InitializeComponent();
        }

        private void FormaUpravljanjeZaposlenima_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
