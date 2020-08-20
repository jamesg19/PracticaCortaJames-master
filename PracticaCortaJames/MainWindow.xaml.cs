using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaCortaJames
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string palabra;
        string texto;
        int numero;
        double numdecimal;
        string[] palabrasArray;
        public MainWindow()
        {
            InitializeComponent();
        }
       

        //caja de texto donde ingresa la oracion
        private void Text1(object sender, TextChangedEventArgs e)
        {



        }
        //caja de texto donde muestra los resultados
        private void Text2(object sender, TextChangedEventArgs e)
        {



        }
        //boton de aceprtar
        private void Boton_Aceptar(object sender, RoutedEventArgs e)
        {
            palabra = texto1.Text;
            palabrasArray = palabra.Split(' ');
            texto2.AppendText("Usted ha ingresado \n");
            for (int i=0;i<palabrasArray.Length;i++)
            {
                texto = palabrasArray[i];
                texto2.AppendText(palabrasArray[i]+"\n");
            }

            determinar(palabrasArray);
        }

        public void determinar(string [] palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                string local = palabra[i];
                int esnumero = 0;
                decimal esdecimal = 0;
                
                //determina si es numero entero
                if( (int.TryParse(local, out esnumero)) == true)
                {
                    
                        texto3.AppendText(esnumero + ": ES NUMERO \n");
                }
                //determina si es decimal
                else if ((decimal.TryParse(local, out esdecimal)) == true)
                {
                   
                    texto3.AppendText(esdecimal + ": ES DECIMAL \n");
                }
                //determina si es letra
                else if (char.IsNumber(local,0) ==false)
                {

                    texto3.AppendText(local + " ES PALABRA \n");
                }
                //determina si es Moneda
                else if (char.IsNumber(local, 0) == false)
                {

                    texto3.AppendText(local + " es letra \n");
                }

            }
        }
        // boton limpiar texto
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            texto3.Clear();
            texto2.Clear();
            texto1.Clear();
        }
    }

}
