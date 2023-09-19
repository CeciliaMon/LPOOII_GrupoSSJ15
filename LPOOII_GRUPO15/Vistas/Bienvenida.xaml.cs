using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Valida el usuario y la contraseña hardcoded
            if (usuario == "Admin" && contraseña == "Admin123")
            {
                // Mostrar pantalla de Admin
                MessageBox.Show("Bienvenido, Admin.");
                PrincipalAdmin adminWindow = new PrincipalAdmin();
                adminWindow.Show();
                Close(); // Cierra la ventana de inicio de sesión*/
            }
            else if (usuario == "Operador" && contraseña == "Operador123")
            {
                // Mostrar pantalla de Operador
                MessageBox.Show("Bienvenido, Operador.");
                PrincipalOperador adminWindow = new PrincipalOperador();
                adminWindow.Show();
                Close(); // Cierra la ventana de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
