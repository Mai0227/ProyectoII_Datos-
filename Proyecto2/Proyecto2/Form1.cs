using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        //se utiliza la clase Image con el link de la imagen que desea utilizar 
        

        //utilizar una matriz para que sea aleatorio 
        int[,] matriz = new int[6, 7];

        //crear dos variables tipo strink 
        string fila = " ", columna = " ";

        //crear una variable booleana 
        bool jugador = true;
        bool HayGanador = true;
        bool HayEmpate = false;

        //puntos de cada jugador
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        int PuntosEmpate = 0;

        int turno = 1;
        int ContadorEmapate = 0;

        Stack<string> PilaMovimientos = new Stack<string>();
        Stack<int> PilaPosiciones = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////Referencia para todos los botones donde va la fichas ///////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {

            columna = "0";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            columna = "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            columna = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            columna = "0";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            columna = "0";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            columna = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            columna = "1";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            columna = "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            columna = "1";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            columna = "1";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            columna = "1";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            columna = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            columna = "2";

        }

        private void button10_Click(object sender, EventArgs e)
        {

            columna = "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            columna = "2";
        }

        private void button24_Click(object sender, EventArgs e)
        {

            columna = "2";
        }

        private void button31_Click(object sender, EventArgs e)
        {

            columna = "2";
        }

        private void button38_Click(object sender, EventArgs e)
        {

            columna = "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            columna = "3";

        }

        private void button11_Click(object sender, EventArgs e)
        {

            columna = "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            columna = "3";
        }

        private void button25_Click(object sender, EventArgs e)
        {

            columna = "3";
        }

        private void button32_Click(object sender, EventArgs e)
        {

            columna = "3";
        }

        private void button39_Click(object sender, EventArgs e)
        {

            columna = "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            columna = "4";

        }

        private void button12_Click(object sender, EventArgs e)
        {

            columna = "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {

            columna = "4";
        }

        private void button26_Click(object sender, EventArgs e)
        {

            columna = "4";
        }

        private void button33_Click(object sender, EventArgs e)
        {

            columna = "4";
        }

        private void button40_Click(object sender, EventArgs e)
        {

            columna = "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            columna = "5";

        }

        private void button13_Click(object sender, EventArgs e)
        {

            columna = "5";
        }

        private void button20_Click(object sender, EventArgs e)
        {

            columna = "5";
        }

        private void button27_Click(object sender, EventArgs e)
        {

            columna = "5";
        }

        private void button34_Click(object sender, EventArgs e)
        {

            columna = "5";
        }

        private void button41_Click(object sender, EventArgs e)
        {

            columna = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            columna = "6";

        }

        private void button14_Click(object sender, EventArgs e)
        {

            columna = "6";
        }

        private void button21_Click(object sender, EventArgs e)
        {

            columna = "6";
        }

        private void button28_Click(object sender, EventArgs e)
        {

            columna = "6";
        }

        private void button35_Click(object sender, EventArgs e)
        {

            columna = "6";
        }

        private void button42_Click(object sender, EventArgs e)
        {

            columna = "6";
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // seleccionar imagen dependiendo la posicion///////////////////////////////////////////////////////////////////
        //funciona para poder seleccionar cualquier boton que necesitemos en la matriz ////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void seleccionarBotton(string codigoboton)
        {
            switch (codigoboton)
            {
                //fila 0
                case "00":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button1.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button1.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button1.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button1.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "10":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button8.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button8.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button8.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button8.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "20":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button15.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button15.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button15.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button15.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "30":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button22.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button22.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button22.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button22.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "40":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button29.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button29.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button29.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button29.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "50":
                    if (jugador == true)
                    {                        
                        if (RBBob.Checked == true)
                        {                            
                            button36.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button36.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {                        
                        if (RBBob.Checked == true)
                        {                            
                            button36.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {                            
                            button36.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;

                //fila 1 
                case "01":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button2.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button2.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button2.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button2.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "11":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button9.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button9.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button9.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button9.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "21":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button16.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button16.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button16.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button16.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "31":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button23.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button23.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button23.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button23.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "41":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button30.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button30.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button30.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button30.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "51":
                    if (jugador == true)
                    {                        
                        if (RBBob.Checked == true)
                        {                            
                            button37.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {                            
                            button37.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {                        
                        if (RBBob.Checked == true)
                        {                            
                            button37.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {                            
                            button37.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                //fila 2
                case "02":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button3.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button3.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button3.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button3.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "12":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button10.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button10.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button10.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button10.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "22":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button17.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button17.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button17.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button17.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "32":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button24.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button24.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button24.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button24.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "42":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button31.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button31.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button31.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button31.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "52":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button38.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button38.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button38.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button38.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;

                //fila 3
                case "03":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button4.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button4.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button4.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button4.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "13":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button11.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button11.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button11.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button11.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "23":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button18.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button18.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button18.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button18.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "33":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button25.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button25.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button25.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button25.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "43":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button32.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button32.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button32.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button32.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "53":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button39.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button39.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button39.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button39.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;

                //fila 4 
                case "04":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button5.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button5.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button5.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button5.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "14":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button12.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button12.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button12.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button12.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "24":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button19.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button19.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button19.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button19.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "34":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button26.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button26.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button26.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button26.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "44":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button33.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button33.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button33.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button33.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "54":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button40.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button40.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button40.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button40.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;

                //fila 5 
                case "05":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button6.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button6.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button6.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button6.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "15":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button13.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button13.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button13.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button13.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "25":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button20.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button20.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button20.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button20.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "35":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button27.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button27.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button27.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button27.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "45":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button34.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button34.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button34.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button34.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "55":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button41.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button41.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button41.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button41.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                //fila 6
                case "06":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button7.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button7.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button7.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button7.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "16":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button14.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button14.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button14.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button14.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "26":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button21.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button21.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button21.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button21.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "36":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button28.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button28.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button28.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button28.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "46":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button35.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button35.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button35.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button35.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
                case "56":
                    if (jugador == true)
                    {
                        if (RBBob.Checked == true)
                        {
                            button42.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = false;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button42.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = false;
                        }
                        break;
                    }
                    else if (jugador == false)
                    {
                        if (RBBob.Checked == true)
                        {
                            button42.BackgroundImage = Properties.Resources.PatricioBoton;
                            jugador = true;
                        }
                        else if (RBBob.Checked == false)
                        {
                            button42.BackgroundImage = Properties.Resources.BodBoton;
                            jugador = true;
                        }
                        break;
                    }
                    break;
            }
        }

        //////////////Botones de PLAY//////////////////////////////////////////////////////////////////
        ///Con estos botones los jugadores ponen las fichas donde quieran //// <summary>
        /// Con estos botones los jugadores ponen las fichas donde quieran ////
        /// Cada uno de los botones activa llenaMatriz y seleccionaganador
        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void button43_Click_1(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "0";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "1";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "2";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "3";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);         
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "4";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "5";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);           
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (RBBob.Checked == true || RBPatricio.Checked == true)
            {
                columna = "6";
                fila = "5";
                LLenaMatriz();
                SeleccionarGanador();
            }
            else
                MessageBox.Show("Debes seleccionar un Jugador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }
        ////////////////////////////////////////////////////////////////// 
        
        public void LLenaMatriz()
        {
            //colocar un ciclo for para que recorra la columna de la matriz y que pregunte donde hay un cero 


            for (int i = 5; i > -1; i--)//se recorre en la ultima posicion 
            {
                ////conviete columna a un entero para poder usar la posicion en la matriz
                int colum = int.Parse(columna.ToString());  

                //ciclo evalua que el valor que este sea igual a cero para entrar
                //entra a las  posiciones que no han sido elegidas
                if (matriz[i, colum].Equals(0))
                {
                    matriz[i, colum] = turno;
                    //contador empate se le suma un numero para que vaya contando los turnos de la juegada
                    ContadorEmapate = ContadorEmapate + 1;
                    //crear un string que concatene la [i,columna] para obtener la posicion en la matriz y se llama codigo
                    string codigo = i.ToString() + colum.ToString();
                    seleccionarBotton(codigo);                        

                    //*****hay que lograr hacer que se imprima con el botton de GAME REVIEW*****
                    //creacion de dos pilas para almacenar la el movimiento y posicion 
                    
                    PilaMovimientos.Push(codigo);
                    lblMovimientos.Text = lblMovimientos.Text + " - " + codigo;                                                 

                    PilaPosiciones.Push(turno);
                    lblPosiciones.Text = lblPosiciones.Text + " - " + turno;
                    //esto para cambiar de turno de 1 a 2                     
                    turno = (turno == 1) ? 2 : 1;
                    break;
                }//cierre del ciclo for        

            }

        }

        public void ImpresionDelJuego()
        {
            for (int i = 5; i > -1; i--)
            {

                if (PilaMovimientos.Count() > 0)
                {
                    int MovimientoX, MovimientoY, MovimientoGeneral;
                    MovimientoGeneral = int.Parse(PilaMovimientos.Pop());
                    lblMovimientos.Text = lblMovimientos.Text + " - " + MovimientoGeneral.ToString();
                    //MovimientoY = MovimientoGeneral % 10;
                    //MovimientoX = MovimientoGeneral / 10;                                
                    //MessageBox.Show("movimiento general: "+MovimientoGeneral);
                    //MessageBox.Show("Movimiento en X: "+ MovimientoX);
                    //MessageBox.Show("Movimiento en Y: "+ MovimientoY);

                    int Posicion;
                    Posicion = PilaPosiciones.Pop();
                    lblPosiciones.Text = lblPosiciones.Text + " - " + Posicion.ToString();
                    //matriz[MovimientoX, MovimientoY] = Posicion;
                    if (Posicion == 1)
                    {
                        if (MovimientoGeneral == 00)
                        {
                            button1.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 10)
                        {
                            button8.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 20)
                        {
                            button15.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 30)
                        {
                            button22.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 40)
                        {
                            button29.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 50)
                        {
                            button36.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 01)
                        {
                            button2.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 11)
                        {
                            button9.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 21)
                        {
                            button16.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 31)
                        {
                            button23.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 41)
                        {
                            button30.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 51)
                        {
                            button37.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 02)
                        {
                            button3.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 12)
                        {
                            button10.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 22)
                        {
                            button17.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 32)
                        {
                            button24.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 42)
                        {
                            button31.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 52)
                        {
                            button38.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 03)
                        {
                            button4.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 13)
                        {
                            button11.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 23)
                        {
                            button18.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 33)
                        {
                            button25.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 43)
                        {
                            button32.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 53)
                        {
                            button39.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 04)
                        {
                            button5.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 14)
                        {
                            button12.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 24)
                        {
                            button19.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 34)
                        {
                            button26.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 44)
                        {
                            button33.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 54)
                        {
                            button40.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 05)
                        {
                            button6.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 15)
                        {
                            button13.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 25)
                        {
                            button20.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 35)
                        {
                            button37.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 45)
                        {
                            button34.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 55)
                        {
                            button41.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 06)
                        {
                            button7.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 16)
                        {
                            button14.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 26)
                        {
                            button21.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 36)
                        {
                            button28.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 46)
                        {
                            button35.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        else if (MovimientoGeneral == 56)
                        {
                            button42.BackgroundImage = Properties.Resources.PlayerUNO;
                        }
                        

                    }
                    else if (Posicion==2) 
                    {
                        if (MovimientoGeneral == 00)
                        {
                            button1.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 10)
                        {
                            button8.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 20)
                        {
                            button15.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 30)
                        {
                            button22.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 40)
                        {
                            button29.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 50)
                        {
                            button36.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 01)
                        {
                            button2.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 11)
                        {
                            button9.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 21)
                        {
                            button16.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 31)
                        {
                            button23.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 41)
                        {
                            button30.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 51)
                        {
                            button37.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 02)
                        {
                            button3.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 12)
                        {
                            button10.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 22)
                        {
                            button17.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 32)
                        {
                            button24.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 42)
                        {
                            button31.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 52)
                        {
                            button38.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 03)
                        {
                            button4.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 13)
                        {
                            button11.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 23)
                        {
                            button18.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 33)
                        {
                            button25.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 43)
                        {
                            button32.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 53)
                        {
                            button39.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 04)
                        {
                            button5.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 14)
                        {
                            button12.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 24)
                        {
                            button19.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 34)
                        {
                            button26.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 44)
                        {
                            button33.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 54)
                        {
                            button40.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 05)
                        {
                            button6.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 15)
                        {
                            button13.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 25)
                        {
                            button20.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 35)
                        {
                            button37.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 45)
                        {
                            button34.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 55)
                        {
                            button41.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 06)
                        {
                            button7.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 16)
                        {
                            button14.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 26)
                        {
                            button21.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 36)
                        {
                            button28.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 46)
                        {
                            button35.BackgroundImage = Properties.Resources.PlayerDOS;
                        }
                        else if (MovimientoGeneral == 56)
                        {
                            button42.BackgroundImage = Properties.Resources.PlayerDOS;
                        }

                    }




                }
                else
                {
                    MessageBox.Show("la pila esta vasia ");
                }
                break;              


            }
        }

            //Aca valida resultados resibiendo 4 enteros
            public void ValidarResultados(string F1, string F2, string F3, string F4)
        {
            //caso donde las 4 fichas sean igual a 1 
            //valida que las 4 fichas sean numero 1 y luego selecciona el ganador dependiendo de cual radiobutton se seleccione
            if (F1 == "1" && F2 == "1" && F3 == "1" && F4 == "1")
            {
                HayGanador = true;
                if (RBBob.Checked == true)
                {
                    picGanador.Image = Properties.Resources.Bob_Gana;
                    MessageBox.Show("En buena hora Bob Esponja has Ganado!!!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PuntosPlayer1++;
                    lblPlayer1.Text = PuntosPlayer1.ToString();
                    LimpiarMatriz();
                }
                else
                {
                    picGanador.Image = Properties.Resources.Patricio_Gana;
                    MessageBox.Show("En buena hora Patricio has Ganado!!!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PuntosPlayer2++;
                    lblPlayer2.Text = PuntosPlayer2.ToString();
                    LimpiarMatriz();
                }



            }
            //caso donde las 4 fichas sean igual a 2 
            //valida que las 4 fichas sean numero 2 y luego selecciona el ganador dependiendo de cual radiobutton se seleccione
            else if (F1 == "2" && F2 == "2" && F3 == "2" && F4 == "2")
            {
                HayGanador = true;
                if (RBBob.Checked == true)
                {
                    picGanador.Image = Properties.Resources.Patricio_Gana;
                    MessageBox.Show("En buena hora Patricio has Ganado!!!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PuntosPlayer2++;
                    lblPlayer2.Text = PuntosPlayer2.ToString();
                    LimpiarMatriz();
                }
                else
                {
                    picGanador.Image = Properties.Resources.Bob_Gana;
                    MessageBox.Show("En buena hora Bob Esponja has Ganado!!!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PuntosPlayer1++;
                    lblPlayer1.Text = PuntosPlayer1.ToString();
                    LimpiarMatriz();
                }
            }
            else if (ContadorEmapate == 42) 
            {
                picGanador.Image = Properties.Resources.Empate;
                MessageBox.Show("Buen Juego, los dos juegadores empataron!!!", "EMPATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PuntosEmpate++;
                lblEmpate.Text = PuntosEmpate.ToString();
                LimpiarMatriz();
            }
            
        }
        public void SeleccionarGanador()
        {
            //saca los valores de la matriz por filas, columnas y diagonales 
            //Primera fila
            ValidarResultados(matriz[0, 0].ToString(), matriz[0, 1].ToString(), matriz[0, 2].ToString(), matriz[0, 3].ToString());
            ValidarResultados(matriz[0, 1].ToString(), matriz[0, 2].ToString(), matriz[0, 3].ToString(), matriz[0, 4].ToString());
            ValidarResultados(matriz[0, 2].ToString(), matriz[0, 3].ToString(), matriz[0, 4].ToString(), matriz[0, 5].ToString());
            ValidarResultados(matriz[0, 3].ToString(), matriz[0, 4].ToString(), matriz[0, 5].ToString(), matriz[0, 6].ToString());
            //Segunda fila 
            ValidarResultados(matriz[1, 0].ToString(), matriz[1, 1].ToString(), matriz[1, 2].ToString(), matriz[1, 3].ToString());
            ValidarResultados(matriz[1, 1].ToString(), matriz[1, 2].ToString(), matriz[1, 3].ToString(), matriz[1, 4].ToString());
            ValidarResultados(matriz[1, 2].ToString(), matriz[1, 3].ToString(), matriz[1, 4].ToString(), matriz[1, 5].ToString());
            ValidarResultados(matriz[1, 3].ToString(), matriz[1, 4].ToString(), matriz[1, 5].ToString(), matriz[1, 6].ToString());
            //Tercera fila
            ValidarResultados(matriz[2, 0].ToString(), matriz[2, 1].ToString(), matriz[2, 2].ToString(), matriz[2, 3].ToString());
            ValidarResultados(matriz[2, 1].ToString(), matriz[2, 2].ToString(), matriz[2, 3].ToString(), matriz[2, 4].ToString());
            ValidarResultados(matriz[2, 2].ToString(), matriz[2, 3].ToString(), matriz[2, 4].ToString(), matriz[2, 5].ToString());
            ValidarResultados(matriz[2, 3].ToString(), matriz[2, 4].ToString(), matriz[2, 5].ToString(), matriz[2, 6].ToString());
            //Cuarta fila 
            ValidarResultados(matriz[3, 0].ToString(), matriz[3, 1].ToString(), matriz[3, 2].ToString(), matriz[3, 3].ToString());
            ValidarResultados(matriz[3, 1].ToString(), matriz[3, 2].ToString(), matriz[3, 3].ToString(), matriz[3, 4].ToString());
            ValidarResultados(matriz[3, 2].ToString(), matriz[3, 3].ToString(), matriz[3, 4].ToString(), matriz[3, 5].ToString());
            ValidarResultados(matriz[3, 3].ToString(), matriz[3, 4].ToString(), matriz[3, 5].ToString(), matriz[3, 6].ToString());
            //quinta fila
            ValidarResultados(matriz[4, 0].ToString(), matriz[4, 1].ToString(), matriz[4, 2].ToString(), matriz[4, 3].ToString());
            ValidarResultados(matriz[4, 1].ToString(), matriz[4, 2].ToString(), matriz[4, 3].ToString(), matriz[4, 4].ToString());
            ValidarResultados(matriz[4, 2].ToString(), matriz[4, 3].ToString(), matriz[4, 4].ToString(), matriz[4, 5].ToString());
            ValidarResultados(matriz[4, 3].ToString(), matriz[4, 4].ToString(), matriz[4, 5].ToString(), matriz[4, 6].ToString());
            //sexta fila 
            ValidarResultados(matriz[5, 0].ToString(), matriz[5, 1].ToString(), matriz[5, 2].ToString(), matriz[5, 3].ToString());
            ValidarResultados(matriz[5, 1].ToString(), matriz[5, 2].ToString(), matriz[5, 3].ToString(), matriz[5, 4].ToString());
            ValidarResultados(matriz[5, 2].ToString(), matriz[5, 3].ToString(), matriz[5, 4].ToString(), matriz[5, 5].ToString());
            ValidarResultados(matriz[5, 3].ToString(), matriz[5, 4].ToString(), matriz[5, 5].ToString(), matriz[5, 6].ToString());

            //primera columna
            ValidarResultados(matriz[0, 0].ToString(), matriz[1, 0].ToString(), matriz[2, 0].ToString(), matriz[3, 0].ToString());
            ValidarResultados(matriz[1, 0].ToString(), matriz[2, 0].ToString(), matriz[3, 0].ToString(), matriz[4, 0].ToString());
            ValidarResultados(matriz[2, 0].ToString(), matriz[3, 0].ToString(), matriz[4, 0].ToString(), matriz[5, 0].ToString());
            //segunda columna
            ValidarResultados(matriz[0, 1].ToString(), matriz[1, 1].ToString(), matriz[2, 1].ToString(), matriz[3, 1].ToString());
            ValidarResultados(matriz[1, 1].ToString(), matriz[2, 1].ToString(), matriz[3, 1].ToString(), matriz[4, 1].ToString());
            ValidarResultados(matriz[2, 1].ToString(), matriz[3, 1].ToString(), matriz[4, 1].ToString(), matriz[5, 1].ToString());
            //tercera columna
            ValidarResultados(matriz[0, 2].ToString(), matriz[1, 2].ToString(), matriz[2, 2].ToString(), matriz[3, 2].ToString());
            ValidarResultados(matriz[1, 2].ToString(), matriz[2, 2].ToString(), matriz[3, 2].ToString(), matriz[4, 2].ToString());
            ValidarResultados(matriz[2, 2].ToString(), matriz[3, 2].ToString(), matriz[4, 2].ToString(), matriz[5, 2].ToString());
            //cuarta columna
            ValidarResultados(matriz[0, 3].ToString(), matriz[1, 3].ToString(), matriz[2, 3].ToString(), matriz[3, 3].ToString());
            ValidarResultados(matriz[1, 3].ToString(), matriz[2, 3].ToString(), matriz[3, 3].ToString(), matriz[4, 3].ToString());
            ValidarResultados(matriz[2, 3].ToString(), matriz[3, 3].ToString(), matriz[4, 3].ToString(), matriz[5, 3].ToString());
            //quinta columna
            ValidarResultados(matriz[0, 4].ToString(), matriz[1, 4].ToString(), matriz[2, 4].ToString(), matriz[3, 4].ToString());
            ValidarResultados(matriz[1, 4].ToString(), matriz[2, 4].ToString(), matriz[3, 4].ToString(), matriz[4, 4].ToString());
            ValidarResultados(matriz[2, 4].ToString(), matriz[3, 4].ToString(), matriz[4, 4].ToString(), matriz[5, 4].ToString());
            //sexta columna
            ValidarResultados(matriz[0, 5].ToString(), matriz[1, 5].ToString(), matriz[2, 5].ToString(), matriz[3, 5].ToString());
            ValidarResultados(matriz[1, 5].ToString(), matriz[2, 5].ToString(), matriz[3, 5].ToString(), matriz[4, 5].ToString());
            ValidarResultados(matriz[2, 5].ToString(), matriz[3, 5].ToString(), matriz[4, 5].ToString(), matriz[5, 5].ToString());
            //sexta columna
            ValidarResultados(matriz[0, 6].ToString(), matriz[1, 6].ToString(), matriz[2, 6].ToString(), matriz[3, 6].ToString());
            ValidarResultados(matriz[1, 6].ToString(), matriz[2, 6].ToString(), matriz[3, 6].ToString(), matriz[4, 6].ToString());
            ValidarResultados(matriz[2, 6].ToString(), matriz[3, 6].ToString(), matriz[4, 6].ToString(), matriz[5, 6].ToString());

            // diagonal principal
            ValidarResultados(matriz[2, 0].ToString(), matriz[3, 1].ToString(), matriz[4, 2].ToString(), matriz[5, 3].ToString());
            ValidarResultados(matriz[1, 0].ToString(), matriz[2, 1].ToString(), matriz[3, 2].ToString(), matriz[4, 3].ToString());
            ValidarResultados(matriz[2, 1].ToString(), matriz[3, 2].ToString(), matriz[4, 3].ToString(), matriz[5, 4].ToString());
            ValidarResultados(matriz[0, 0].ToString(), matriz[1, 1].ToString(), matriz[2, 2].ToString(), matriz[3, 3].ToString());
            ValidarResultados(matriz[1, 1].ToString(), matriz[2, 2].ToString(), matriz[3, 3].ToString(), matriz[4, 4].ToString());
            ValidarResultados(matriz[2, 2].ToString(), matriz[3, 3].ToString(), matriz[4, 4].ToString(), matriz[5, 5].ToString());
            ValidarResultados(matriz[0, 1].ToString(), matriz[1, 2].ToString(), matriz[2, 3].ToString(), matriz[3, 4].ToString());
            ValidarResultados(matriz[1, 2].ToString(), matriz[2, 3].ToString(), matriz[3, 4].ToString(), matriz[4, 5].ToString());
            ValidarResultados(matriz[2, 3].ToString(), matriz[3, 4].ToString(), matriz[4, 5].ToString(), matriz[5, 6].ToString());
            ValidarResultados(matriz[0, 2].ToString(), matriz[1, 3].ToString(), matriz[2, 4].ToString(), matriz[3, 5].ToString());
            ValidarResultados(matriz[1, 3].ToString(), matriz[2, 4].ToString(), matriz[3, 5].ToString(), matriz[4, 6].ToString());
            ValidarResultados(matriz[0, 3].ToString(), matriz[1, 4].ToString(), matriz[2, 5].ToString(), matriz[3, 6].ToString());

            // diagonal Inversa
            ValidarResultados(matriz[3, 0].ToString(), matriz[2, 1].ToString(), matriz[1, 2].ToString(), matriz[0, 3].ToString());
            ValidarResultados(matriz[4, 0].ToString(), matriz[3, 1].ToString(), matriz[2, 2].ToString(), matriz[1, 3].ToString());
            ValidarResultados(matriz[3, 1].ToString(), matriz[2, 2].ToString(), matriz[1, 3].ToString(), matriz[0, 4].ToString());
            ValidarResultados(matriz[5, 0].ToString(), matriz[4, 1].ToString(), matriz[3, 2].ToString(), matriz[2, 3].ToString());
            ValidarResultados(matriz[4, 1].ToString(), matriz[3, 2].ToString(), matriz[2, 3].ToString(), matriz[1, 4].ToString());
            ValidarResultados(matriz[3, 2].ToString(), matriz[2, 3].ToString(), matriz[1, 4].ToString(), matriz[0, 5].ToString());
            ValidarResultados(matriz[5, 1].ToString(), matriz[4, 2].ToString(), matriz[3, 3].ToString(), matriz[2, 4].ToString());
            ValidarResultados(matriz[4, 2].ToString(), matriz[3, 3].ToString(), matriz[2, 4].ToString(), matriz[1, 5].ToString());
            ValidarResultados(matriz[3, 3].ToString(), matriz[2, 4].ToString(), matriz[1, 5].ToString(), matriz[0, 6].ToString());
            ValidarResultados(matriz[5, 2].ToString(), matriz[4, 3].ToString(), matriz[3, 4].ToString(), matriz[2, 5].ToString());
            ValidarResultados(matriz[4, 3].ToString(), matriz[3, 4].ToString(), matriz[2, 5].ToString(), matriz[1, 6].ToString());
            ValidarResultados(matriz[5, 3].ToString(), matriz[4, 4].ToString(), matriz[3, 5].ToString(), matriz[2, 6].ToString());


        }
  

        public void LimpiarMatriz()
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 6; j >= 0; j--)
                {
                    int inicio = 0;
                    matriz[i, j] = inicio;
                }
            }
            
            button1.BackgroundImage = Properties.Resources.garryy;
            button2.BackgroundImage = Properties.Resources.garryy;
            button3.BackgroundImage = Properties.Resources.garryy;
            button4.BackgroundImage = Properties.Resources.garryy;
            button5.BackgroundImage = Properties.Resources.garryy;
            button6.BackgroundImage = Properties.Resources.garryy;
            button7.BackgroundImage = Properties.Resources.garryy;
            button8.BackgroundImage = Properties.Resources.garryy;
            button9.BackgroundImage = Properties.Resources.garryy;
            button10.BackgroundImage = Properties.Resources.garryy;
            button11.BackgroundImage = Properties.Resources.garryy;
            button12.BackgroundImage = Properties.Resources.garryy;
            button13.BackgroundImage = Properties.Resources.garryy;
            button14.BackgroundImage = Properties.Resources.garryy;
            button15.BackgroundImage = Properties.Resources.garryy;
            button16.BackgroundImage = Properties.Resources.garryy;
            button17.BackgroundImage = Properties.Resources.garryy;
            button18.BackgroundImage = Properties.Resources.garryy;
            button19.BackgroundImage = Properties.Resources.garryy;
            button20.BackgroundImage = Properties.Resources.garryy;
            button21.BackgroundImage = Properties.Resources.garryy;
            button22.BackgroundImage = Properties.Resources.garryy;
            button23.BackgroundImage = Properties.Resources.garryy;
            button24.BackgroundImage = Properties.Resources.garryy;
            button25.BackgroundImage = Properties.Resources.garryy;
            button26.BackgroundImage = Properties.Resources.garryy;
            button27.BackgroundImage = Properties.Resources.garryy;
            button28.BackgroundImage = Properties.Resources.garryy;
            button29.BackgroundImage = Properties.Resources.garryy;
            button30.BackgroundImage = Properties.Resources.garryy;
            button31.BackgroundImage = Properties.Resources.garryy;
            button32.BackgroundImage = Properties.Resources.garryy;
            button33.BackgroundImage = Properties.Resources.garryy;
            button34.BackgroundImage = Properties.Resources.garryy;
            button35.BackgroundImage = Properties.Resources.garryy;
            button36.BackgroundImage = Properties.Resources.garryy;
            button37.BackgroundImage = Properties.Resources.garryy;
            button38.BackgroundImage = Properties.Resources.garryy;
            button39.BackgroundImage = Properties.Resources.garryy;
            button40.BackgroundImage = Properties.Resources.garryy;
            button41.BackgroundImage = Properties.Resources.garryy;
            button42.BackgroundImage = Properties.Resources.garryy;
            picGanador.Image = Properties.Resources.premio;

            lblMovimientos.Text = "";
            lblPosiciones.Text = "";
            
            //inicializar los radiobuttons y tener que seleccionar cada jugada el jugador
            if (RBBob.Checked == true)
            {
                RBBob.Checked = false;
            }
            else if (RBPatricio.Checked == true)
            {
                RBPatricio.Checked = false;
            }
            //para que cada jugada se inicie siempre con el booleano true
            jugador = true;
            //para que en cada turno siempre se inicie con el 1
            turno = 1;
            //Inicializar la variable de contador empate 
            ContadorEmapate = 0;



        }

        public void ReiniciarJuego() 
        {
        //Inicializamos todos los valores del juego
         
         
            HayGanador = true;
            PuntosPlayer1 = 0;
            PuntosPlayer2 = 0;
            PuntosEmpate=0;
            lblPlayer1.Text = PuntosPlayer1.ToString();
            lblPlayer2.Text = PuntosPlayer2.ToString();
            lblPlayer2.Text = PuntosPlayer2.ToString();
            lblEmpate.Text = PuntosEmpate.ToString();

            //inicializar los radiobuttons y tener que seleccionar cada jugada el jugador
            if (RBBob.Checked == true)
            {
                RBBob.Checked = false;
            }
            else if (RBPatricio.Checked == true)
            {
                RBPatricio.Checked = false;
            }
            //para que en cada turno siempre se inicie con el 1
            turno = 1;
            //Inicializar la variable de contador empate 
            ContadorEmapate = 0;


            button1.BackgroundImage = Properties.Resources.garryy;            
            button2.BackgroundImage = Properties.Resources.garryy;            
            button3.BackgroundImage = Properties.Resources.garryy;            
            button4.BackgroundImage = Properties.Resources.garryy;            
            button5.BackgroundImage = Properties.Resources.garryy;            
            button6.BackgroundImage = Properties.Resources.garryy;            
            button7.BackgroundImage = Properties.Resources.garryy;       
            button8.BackgroundImage = Properties.Resources.garryy;
            button9.BackgroundImage = Properties.Resources.garryy;
            button10.BackgroundImage = Properties.Resources.garryy;
            button11.BackgroundImage = Properties.Resources.garryy;
            button12.BackgroundImage = Properties.Resources.garryy;
            button13.BackgroundImage = Properties.Resources.garryy;
            button14.BackgroundImage = Properties.Resources.garryy;
            button15.BackgroundImage = Properties.Resources.garryy;
            button16.BackgroundImage = Properties.Resources.garryy;
            button17.BackgroundImage = Properties.Resources.garryy;
            button18.BackgroundImage = Properties.Resources.garryy;
            button19.BackgroundImage = Properties.Resources.garryy;
            button20.BackgroundImage = Properties.Resources.garryy;
            button21.BackgroundImage = Properties.Resources.garryy;
            button22.BackgroundImage = Properties.Resources.garryy;
            button23.BackgroundImage = Properties.Resources.garryy;
            button24.BackgroundImage = Properties.Resources.garryy;
            button25.BackgroundImage = Properties.Resources.garryy;
            button26.BackgroundImage = Properties.Resources.garryy;
            button27.BackgroundImage = Properties.Resources.garryy;
            button28.BackgroundImage = Properties.Resources.garryy;
            button29.BackgroundImage = Properties.Resources.garryy;
            button30.BackgroundImage = Properties.Resources.garryy;
            button31.BackgroundImage = Properties.Resources.garryy;
            button32.BackgroundImage = Properties.Resources.garryy;
            button33.BackgroundImage = Properties.Resources.garryy;
            button34.BackgroundImage = Properties.Resources.garryy;
            button35.BackgroundImage = Properties.Resources.garryy;
            button36.BackgroundImage = Properties.Resources.garryy;
            button37.BackgroundImage = Properties.Resources.garryy; 
            button38.BackgroundImage = Properties.Resources.garryy;
            button39.BackgroundImage = Properties.Resources.garryy;
            button40.BackgroundImage = Properties.Resources.garryy;
            button41.BackgroundImage = Properties.Resources.garryy;
            button42.BackgroundImage = Properties.Resources.garryy;
            picGanador.Image = Properties.Resources.premio;

            Stack<string> PilaMovimientos = new Stack<string>();
            Stack<int> PilaPosiciones = new Stack<int>();
            //.clear lo que hace es borrar toda la pila 
            PilaMovimientos.Clear();
            lblMovimientos.Text = "";
            PilaPosiciones.Clear();
            lblPosiciones.Text = "";

            //para que cada jugada se inicie siempre con el booleano true
            jugador = true;


            //arreglo para inicializar los valores dentro de la matriz

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 6; j >= 0; j--)
                {
                    int inicio = 0;
                    matriz[i, j] = inicio;
                }
            }
        }      
   


       

        

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReiniciarJuego();
            
        }
        private void GameReview() 
        {

        }
        private void gameReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpresionDelJuego();
            
        }

        private void picGanador_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        



       
        
       
    }
}
