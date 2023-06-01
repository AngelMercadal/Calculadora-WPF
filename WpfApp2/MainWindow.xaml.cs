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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock textBlock1 = new TextBlock();




        }

        double num = 0;
        String numero = "";
        string simbolo = "";
        double numAlm;
        int contador = 0;


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (numero == "0" || num == 0) {
                textBlock1.Inlines.Clear();
                    }
                
            numero = numero + "1";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));





        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "2";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "3";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "4";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));



        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "5";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "6";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "7";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));





        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "8";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));






        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (numero == "0") textBlock1.Inlines.Clear();
            numero = numero + "9";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }


        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (numero == "0" || num == 0)
            {
                textBlock1.Inlines.Clear();
            }
            numero = numero + "0";
            num = Convert.ToDouble(numero);
            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numero)));




        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("%")));


        }

        private void Button_Click_27(object sender, RoutedEventArgs e)   //CE
        {

            textBlock1.Inlines.Clear();
            num = 0;
            numero = "0";
            numAlm=0;
            contador = 0;


            textBlock1.Inlines.Add((new Run(numero)));


        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            num = 0;
            numero = "0";
            numAlm = 0;
            contador = 0;


            textBlock1.Inlines.Add((new Run(numero)));
        }

        private void Button_Click_Erase(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }


        private void Button_Click_x(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(".")));





        }


        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

          
            if (contador == 0)
            { numAlm = num; }


            else
            { numAlm /=num; }


            numero = "";
            num = 0;


            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numAlm.ToString())));



            simbolo = "÷";
            contador++;





        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run("")));





        }

        private void Button_Click_X(object sender, RoutedEventArgs e)
        {

            if (contador == 0)
            { numAlm = num; }


            else
            { numAlm *=num; }


            numero = "";
            num = 0;


            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numAlm.ToString())));



            simbolo = "X";
            contador++;





        }


        private void Button_Click_21(object sender, RoutedEventArgs e)
        {

            if (contador == 0)
            { numAlm = num; }


            else
            { numAlm -= num; }


            numero = "";
            num = 0;


            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numAlm.ToString())));



            simbolo = "-";
            contador++;





        }

        private void Button_Click_22(object sender, RoutedEventArgs e)  //+ funct
        {

            
            if (contador == 0)
            {  numAlm = num;}


            else
            { numAlm += num; }
            
            
            numero = "";
            num = 0;


            textBlock1.Inlines.Clear();
            textBlock1.Inlines.Add((new Run(numAlm.ToString())));



            simbolo = "+";
            contador++;
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)  //= funct
        {

            
            if (simbolo == "+")

            {
                numAlm += num;

                textBlock1.Inlines.Clear();
                textBlock1.Inlines.Add((new Run((numAlm).ToString())));
            }

            if (simbolo == "-")

            {
                numAlm -= num;

                textBlock1.Inlines.Clear();
                textBlock1.Inlines.Add((new Run((numAlm).ToString())));
            }

            if (simbolo == "X")

            {
                numAlm *= num;

                textBlock1.Inlines.Clear();
                textBlock1.Inlines.Add((new Run((numAlm).ToString())));
            }



            if (simbolo == "÷")

            {
                numAlm /= num;

                textBlock1.Inlines.Clear();
                textBlock1.Inlines.Add((new Run((numAlm).ToString())));
            }
        }

    }
    }





        







    

