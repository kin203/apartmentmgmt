using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlychungcu
{
    public partial class frmLayKetNoi : Form
    {
        public frmLayKetNoi()
        {
            InitializeComponent();
        }

        private void frmLayKetNoi_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
