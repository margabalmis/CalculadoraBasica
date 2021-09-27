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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        int num1;
        int num2;
        char operador;
        public MainWindow()
        {
            InitializeComponent();
   
        }
        

        private void calcular_Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                num1 = int.Parse(operando1_text.Text);
                num2 = int.Parse(operando2_text.Text);
                operador = char.Parse(operador_text.Text);
                CalcularResultado();

            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error. Revisa los operandos.");
            }

        }

        private void limpiar_Button_Click(object sender, RoutedEventArgs e)
        {
            operador_text.Clear();
            operando1_text.Clear();
            operando2_text.Clear();
            calcular_Button.IsEnabled = false;

        }
        private void CalcularResultado() 
        {
            switch (operador)
            {
                case '+':
                    resultado_text.Text = (num1 + num2).ToString(); 
                    break;

                case '-':
                    resultado_text.Text = (num1 - num2).ToString();
                    break;

                case '/':
                    resultado_text.Text = (num1 / num2).ToString();
                    break;
                case '*':
                    resultado_text.Text = (num1 * num2).ToString();
                    break;

                default:
                    
                    break;
            }

        }

        private void operador_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((operador != '+') || (operador != '-') || (operador != '/') || (operador != '*'))
                calcular_Button.IsEnabled = true;
        }
    }
}
