using System;
using System.Windows;


namespace CalculadoraBasica
{
    public partial class MainWindow : Window
    {
        private const string OPERANDO_SUMA = "+";
        private const string OPERANDO_RESTA = "-";
        private const string OPERANDO_MULTIPLICACION = "*";
        private const string OPERANDO_DIVISION = "/";

        int operando1 = 0;
        int operando2 = 0;
        int resultado = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void IsEnabledButton()
        {
            switch (operadorTextBox.Text)
            {
                case OPERANDO_SUMA:
                    calcularButton.IsEnabled = true;
                    break;
                case OPERANDO_RESTA:
                    calcularButton.IsEnabled = true;
                    break;
                case OPERANDO_MULTIPLICACION:
                    calcularButton.IsEnabled = true;
                    break;
                case OPERANDO_DIVISION:
                    calcularButton.IsEnabled = true;
                    break;
                default:
                    calcularButton.IsEnabled = false;
                    break;
            }
        }
        private void ParseoAInt()
        {
            operando1 = Int32.Parse(operando1TextBox.Text);
            operando2 = Int32.Parse(operando2TextBox.Text);
        }
        private void cambioOperandoTextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            IsEnabledButton();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Clear();
            operando2TextBox.Clear();
            operadorTextBox.Clear();
            resultadoTextBox.Clear();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            ParseoAInt();
            switch (operadorTextBox.Text)
            {
                case OPERANDO_SUMA:
                    resultado = operando1 + operando2;
                    resultadoTextBox.Text = resultado.ToString();
                    break;
                case OPERANDO_RESTA:
                    resultado = operando1 - operando2;
                    resultadoTextBox.Text = resultado.ToString();
                    break;
                case OPERANDO_MULTIPLICACION:
                    resultado = operando1 * operando2;
                    resultadoTextBox.Text = resultado.ToString();
                    break;
                case OPERANDO_DIVISION:
                    resultado = operando1 / operando2;
                    resultadoTextBox.Text = resultado.ToString();
                    break;
            }
        }
    }
}
