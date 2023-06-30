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
using Empleados23AM.Entities;
using Empleados23AM.Services;

namespace Empleados23AM
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
        EmpleadoServices services = new EmpleadoServices();
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            Empleado empleado = new Empleado()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                FechaRegistro = DateTime.Now,
            };
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                services.Add(empleado);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                MessageBox.Show("Exito");
            }
            
        }

        private void BtnLeer_Click(object sender, RoutedEventArgs e)
        {
            int Id= int.Parse (txtId.Text);
            Empleado empleado = services.Leer(Id);
            txtId.Text = empleado.PkEmpleado.ToString();
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtCorreo.Text = empleado.Correo;
            txtFecha.Text = empleado.FechaRegistro.ToString();
        }
    }
}
