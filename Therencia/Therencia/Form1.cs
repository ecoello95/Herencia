using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Therencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 01;
            heroe1.Nombre = "Goku";
            heroe1.Poderes = "Kamehameha";


            var heroe2 = new Heroe();
            heroe2.Id = 01;
            heroe2.Nombre = "Gohan";
            heroe2.Poderes = "Masenko";


            var heroe3 = new Heroe();
            heroe3.Id = 01;
            heroe3.Nombre = "Vegeta";
            heroe3.Poderes = "Resplandor Final";

            var villano1 = new Villano();
            villano1.Id = 02;
            villano1.Nombre = "Freezer";
            villano1.Poderes = "Destruir Planetas";

            var villano2 = new Villano();
            villano2.Id = 02;
            villano2.Nombre = "Cell";
            villano2.Poderes = "Absorber";

            var villano3 = new Villano();
            villano3.Id = 03;
            villano3.Nombre = "Magneto";
            villano3.Poderes = "Control de metales";
        }
    }
}
