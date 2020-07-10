using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLOT_MACHINE_FINAL
{
    public partial class aviso : Form
    {
        public aviso()
        {
        InitializeComponent();
        }

        public static bool simnao = false;
        private static MAIN main = new MAIN();

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {

            get
            {

            CreateParams cp = base.CreateParams;
            cp.ClassStyle = CS_DropShadow;
            return cp;

            }

        }

        private void avisosimbutton_Click(object sender, EventArgs e)
        {
           
            main.creditslabeltext("1000");
             MAIN.creditos = 1000;
            
            this.Hide();
        }

        private void avisonaobotao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
