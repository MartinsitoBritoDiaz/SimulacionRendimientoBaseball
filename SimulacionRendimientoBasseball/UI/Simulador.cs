using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionRendimientoBasseball.UI
{
    public partial class Simulador : Form
    {
        public double AVG { get; set; }

        //Variables para lanzamiento
        public int CantidadCurvas { get; set; }
        public int CantidadRectas { get; set; }
        public int CantidadCambios { get; set; }
        public int CantidadCNudillos { get; set; }
        public int CantidadSlider { get; set; }

        //Variables para las enfermedades
        public int CantidadCovid { get; set; }
        public int CantidadGripe { get; set; }
        public int CantidadAlcohol { get; set; }
        public int CantidadTrasnocho { get; set; }
        public int cantLanzamientos = 0;

        //Variables Bateo
        public int CantidadStrikes { get; set; }
        public int CantidadFoul { get; set; }
        public int CantidadHit { get; set; }
        public int CantidadTurnos { get; set; }

        //Hit por lanzamiento
        public int HitCurvas = 0;
        public int HitRectas = 0;
        public int HitCambios = 0;
        public int HitNudillos = 0;
        public int HitSlider = 0;

        // Variables Extras
        public int dia = 0;
        public int NoJugador = 1;

        public Simulador()
        {
            InitializeComponent();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {

        }

        public void Ejecucion()
        {
            if (NoJugador == 19)
            {
                timer1.Stop();

                MessageBox.Show("Ha terminado la simulacion", "Fin!");
            }

            //Cambio de jugador
            if (dia == 5)
            {
                timer1.Stop();

                Estadisticas();

                MessageBox.Show("El jugador #" + NoJugador + " ha terminado su practica semanal");

                CantidadTurnos = 0;
                NoJugador++;
                dia = 0;

                return;

            }

            //Cambio de dias 
            if(cantLanzamientos == 5)
            {
                Enfermedad();

                if (String.Equals(EnfermedadLabel.Text, "Covid"))
                {
                    timer1.Stop();
                    MessageBox.Show("El jugador #" + NoJugador + " se ha enfermado de " + EnfermedadLabel.Text +
                        " entonces no podra seguir con su practica debido a que estara en reposo.");

                    Estadisticas();

                    MessageBox.Show("El jugador #" + NoJugador + " ha terminado su practica semanal");
                    
                    
                    CantidadTurnos = 0;
                    NoJugador++;
                    dia = 0;

                    EnfermedadLabel.Text = "Ninguna";
                }
                else
                {
                    if (!String.Equals(EnfermedadLabel.Text, "Ninguna"))
                    {
                        timer1.Stop();

                        MessageBox.Show("El jugador #" + NoJugador + " se ha enfermado de " + EnfermedadLabel.Text);

                        timer1.Start();

                        EnfermedadLabel.Text = "Ninguna";
                    }
                }
                

                cantLanzamientos = 0;
                dia++;
            }

            DiaTextBox.Text = Convert.ToString(dia);
            JugadorTextBox.Text = Convert.ToString(NoJugador);

            cantLanzamientos++;
            LanzamientoTextBox.Text = Convert.ToString(cantLanzamientos);
            Lanzamiento();
            Bateo();

            CantidadTurnos++;
        }

        public void Limpiar()
        {
            CantidadGripe = 0;
            CantidadAlcohol = 0;
            CantidadCovid = 0;
            CantidadTrasnocho = 0;

            CantidadCNudillos = 0;
            CantidadCurvas = 0;
            CantidadRectas = 0;
            CantidadSlider = 0; 
            CantidadCambios = 0;
            cantLanzamientos = 0;

            Curvaslabel.Text = "0";
            Rectaslabel.Text = "0";
            Cambioslabel.Text = "0";
            Nudilloslabel.Text = "0";
            Sliderlabel.Text = "0";
            
            AVGLabel.Text = "000";
            CantBatazosLabel.Text = "000";

            LanzamientoTextBox.Text = "0";
            LanzamientoLabel.Text = ".........";
            EnfermedadLabel.Text = "Ninguna";
            BatazoLabel.Text = ".........";
        }

        //TODO: STATS
        public void Estadisticas()
        {
            groupBox1.Visible = true;
            button1.Visible = true;

            double Promedio = (CantidadHit / CantidadTurnos);

            Promedio = Math.Round(Promedio,2);

            AVGLabel.Text = Convert.ToString((CantidadHit / CantidadTurnos) * 1000);

            CantBatazosLabel.Text = Convert.ToString(CantidadHit);

            Curvaslabel.Text = Convert.ToString(HitCurvas);
            Rectaslabel.Text = Convert.ToString(HitRectas);
            Sliderlabel.Text = Convert.ToString(HitSlider);
            Cambioslabel.Text = Convert.ToString(HitCambios);
            Nudilloslabel.Text = Convert.ToString(HitNudillos);


            // EnfermedadEstlabel.Text = 
        }

        public double Probabilidad()
        {
            Random auxiliar = new Random();
            double probabilidad;

            probabilidad = auxiliar.NextDouble();

            probabilidad *= 100;

            return probabilidad;
        }

        public void Lanzamiento()
        {
            double pLanzamiento = Probabilidad();


            if((pLanzamiento >= 0) && (pLanzamiento <= 20))
            {
                LanzamientoLabel.Text = "Curva";
                CantidadCurvas++;


                if (String.Equals(BatazoLabel.Text, "Hit"))
                    HitCurvas++;
            }

            if ((pLanzamiento > 20) && (pLanzamiento <= 40))
            {
                LanzamientoLabel.Text = "Recta"; 
                CantidadRectas++;

                if (String.Equals(BatazoLabel.Text, "Hit"))
                    HitRectas++;
            }

            if ((pLanzamiento > 40) && (pLanzamiento <= 60))
            {
                LanzamientoLabel.Text = "Cambio";

                CantidadCambios++;

                if (String.Equals(BatazoLabel.Text, "Hit"))
                    HitCambios++;
            }

            if ((pLanzamiento > 60) && (pLanzamiento <= 80))
            {
                LanzamientoLabel.Text = "Nudillo";
                CantidadCNudillos++;

                if (String.Equals(BatazoLabel.Text, "Hit"))
                    HitNudillos++;
            }

            if ((pLanzamiento > 80) && (pLanzamiento <= 100))
            {
                LanzamientoLabel.Text = "Slider";
                CantidadSlider++;

                if (String.Equals(BatazoLabel.Text, "Hit"))
                    HitSlider++;
            }

        }

        public void Enfermedad()
        {
            double pEnfermedad = Probabilidad();

            if ((pEnfermedad >= 0) && (pEnfermedad <= 2.5))
            {
                EnfermedadLabel.Text = "Covid";
                CantidadCovid++;
            }

            if ((pEnfermedad > 2.5) && (pEnfermedad <= 5))
            {
                EnfermedadLabel.Text = "Gripe";
                CantidadGripe++;
            }

            if ((pEnfermedad > 5) && (pEnfermedad <= 7.5))
            {
                EnfermedadLabel.Text = "Alcohol";
                CantidadAlcohol++;
            }

            if ((pEnfermedad > 7.5) && (pEnfermedad <= 10))
            {
                EnfermedadLabel.Text = "Trasnocho";
                CantidadTrasnocho++;
            }

            if ((pEnfermedad > 10) && (pEnfermedad <= 100))
            {
                EnfermedadLabel.Text = "Ninguna";
            }
        }

        public void Bateo()
        {
            double pBateo = Probabilidad();

            if ((pBateo >= 0) && (pBateo <= 33.33))
            {
                BatazoLabel.Text = "Strike";
                CantidadStrikes++;
            }

            if ((pBateo > 33.33) && (pBateo <= 66.66))
            {
                BatazoLabel.Text = "Foul";
                CantidadFoul++;
            }

            if ((pBateo > 66.66) && (pBateo <= 100))
            {
                BatazoLabel.Text = "Hit";

                CantidadHit++;
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ejecucion();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Limpiar();
            timer1.Start();
        }
    }
}
