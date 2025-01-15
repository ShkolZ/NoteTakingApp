using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        private string? noteName;
        public Form2()
        {
            InitializeComponent();
        }

        public string GetName() //funkce aby dostat jmeno
        {
            if (noteName != null)
            {
                return this.noteName;
            }
            else return "";
        }

        private void btnConfirm_Click(object sender, EventArgs e) //tlacitko potvrzujici jmeno
        {
            if (txtNoteName != null) noteName = txtNoteName.Text;
            else noteName = "";
            this.Close();
        }
    }
}
