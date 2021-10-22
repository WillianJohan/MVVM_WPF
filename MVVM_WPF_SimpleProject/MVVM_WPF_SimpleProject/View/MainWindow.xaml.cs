using MVVM_WPF_SimpleProject.Classes;
using MVVM_WPF_SimpleProject.Control;
using MVVM_WPF_SimpleProject.Model;
using MVVM_WPF_SimpleProject.ViewModel;
using System.Windows;


namespace MVVM_WPF_SimpleProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Set the initial Page
//            frame.NavigationService.Navigate(new PeopleList());
        }




        private void btn_Consultas_Click(object sender, RoutedEventArgs e) { }
        private void btn_Clientes_Click(object sender, RoutedEventArgs e) => frame.Content = new PeopleList();
        private void btn_TelaInicial_Click(object sender, RoutedEventArgs e) { }
        private void btn_RegistrarClientes_Click(object sender, RoutedEventArgs e) => frame.Content = new PersonRegistration();
    }
}
