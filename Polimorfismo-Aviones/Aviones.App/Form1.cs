using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviones.Core;
using Aviones.Core.Aviones;

namespace Aviones.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAvion(object sender, EventArgs e)
        {
            AvionComercial a = new AvionComercial()
            {
                Piloto = "Ramón Fisherman", 
                Copiloto = "Juan Patricio", 
                Azafata = "Patricia Ramos",
                Capacidad = 300, 
                LineaAerea = "Aerolineas Argentinas"
            };
            
            MessageBox.Show(a.ToString());          
        }
    }
}
