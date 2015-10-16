using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms

namespace UtilisateursGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            FrmModuleLecture frm = new FrmModuleLecture();
            frm.Show();
        }

        private void btnEcriture_Click(object sender, EventArgs e)
        {
            FrmModuleSaisie frm = new FrmModuleSaisie();
            frm.Show();
        }
    }
}
