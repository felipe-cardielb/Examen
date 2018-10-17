using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Carro carro = new Carro();
            carro.Nombre = " Spark ";
            carro.Color = " Negro ";
            carro.Marca = " Chevrolet ";
            carro.Encender();
            carro.Avanzar();
            carro.Apagar();

            Barco barco = new Barco();
            barco.Nombre = " Titanic ";
            barco.Color = " Blanco ";
            barco.Marca = " barcos mexicanos";
            barco.Encender();
            barco.Avanzar();
            barco.Apagar();

            Avion avion = new Avion();
            avion.Nombre = " volador ";
            avion.Color = " negro ";
            avion.Marca = " aviomex";
            avion.Encender();
            avion.Avanzar();
            avion.Apagar();

            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Nombre = " bici ";
            bicicleta.Color = " verde ";
            bicicleta.Marca = " bmx ";
            bicicleta.Encender();
            bicicleta.Avanzar();
            bicicleta.Apagar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
