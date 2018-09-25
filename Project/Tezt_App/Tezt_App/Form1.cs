using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tezt_App
{
    public partial class Form1 : Form
    {
        string ruta;
        int cont_palabras;
        int cont_caracteres;
        int cont_espacios;
        int cont_tabuladores;
        int cont_lineas;
        int cont_vocales;
        int cont_consonante;

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {


            OpenFileDialog op = new OpenFileDialog();

            op.InitialDirectory = "c:/Users/verok/Desktop";
            op.Filter = "txt files (*.txt)|*.txt";
            op.Title = "Seleccione un archivo de texto: ";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                ruta = op.FileName;
                txt_ruta.Text = ruta;
                txt_cuadro.Text = System.IO.File.ReadAllText(op.FileName);
                contarVocales(txt_cuadro.Text.ToLower());
                lbl_vocal.Text = Convert.ToString(cont_vocales);
                contarConsonantes(txt_cuadro.Text.ToLower());
                lbl_consonante.Text = Convert.ToString(cont_consonante - cont_vocales);
                contarPalabras(txt_cuadro.Text);
                lbl_palabra.Text = Convert.ToString(cont_palabras);
                contarEspacios(txt_cuadro.Text.ToLower());
                lbl_espacio.Text = Convert.ToString(cont_espacios);
                contarTabulacion(txt_cuadro.Text.ToLower());
                lbl_tabulador.Text = Convert.ToString(cont_tabuladores);
                //contarLineas(txt_cuadro.Text.ToLower());
                //lbl_linea.Text = Convert.ToString(cont_lineas);
                contarCaracter(txt_cuadro.Text.ToLower());
                lbl_caracter.Text = Convert.ToString(cont_caracteres);

                lbl_linea.Text = Convert.ToString(txt_cuadro.Lines.Count());

                

            }
        }

        private int contarVocales(string cuadro)
        {

            cont_vocales = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    cont_vocales++;
                }

            }

            return cont_vocales;

        }

        private int contarConsonantes(string cuadro)
        {

            cont_consonante = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (Char.IsLetter(c))
                {
                    cont_consonante++;
                }


            }

            return cont_consonante;

        }

        private int contarPalabras(string cuadro)
        {

            cont_palabras = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (c == ' ' || c == '.' || c == '\n')
                {
                    cont_palabras++;

                }


            }

            if (cont_palabras > 0)
            {
                cont_palabras = cont_palabras + 1;
            }

            return cont_palabras;

        }

        private int contarEspacios(string cuadro)
        {

            cont_espacios = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (c == ' ')
                {
                    cont_espacios++;
                }


            }

            return cont_espacios;

        }

        private int contarTabulacion(string cuadro)
        {

            cont_tabuladores = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (c == '\t')
                {
                    cont_tabuladores++;
                }


            }

            return cont_tabuladores;

        }

        private int contarLineas(string cuadro) {

            cont_lineas = 0;
            for (int i = 0; i < cuadro.Length; i++) {

                char c = cuadro[i];

                if (c == '\n') {
                    cont_lineas++;
                }

            }

            return cont_lineas;

        }

        private int contarCaracter(string cuadro)
        {

            cont_caracteres = 0;
            for (int i = 0; i < cuadro.Length; i++)
            {
                char c = cuadro[i];

                if (Char.IsLetter(c) || Char.IsNumber(c) || Char.IsPunctuation(c) || Char.IsWhiteSpace(c))
                {
                    cont_caracteres++;

                }


            }

            return cont_caracteres;

        }

        private void btn_procesar_Click(object sender, EventArgs e) {

            int op = cbo_quitar.SelectedIndex;

            switch (op) {

                case 0:

                    string archivo = txt_cuadro.Text;
                    string reemplazo = archivo.Replace(" ", "");
                    txt_cuadro.Text = reemplazo;

                    break;
                case 1:
                    break;
                default:
                    break;
            }

        }
    }
}
