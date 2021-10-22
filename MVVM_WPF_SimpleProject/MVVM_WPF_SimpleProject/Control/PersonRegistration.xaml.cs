using MVVM_WPF_SimpleProject.Classes;
using MVVM_WPF_SimpleProject.Model;
using System.Windows.Controls;


namespace MVVM_WPF_SimpleProject.Control
{
    public partial class PersonRegistration : UserControl
    {

        Person newPerson;

        public PersonRegistration()
        {
            InitializeComponent();
            newPerson = new Person();
        }

        private void btn_Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            newPerson.Name = txt_name.Text;
            newPerson.LastName = txt_lastname.Text;
            newPerson.CPF = txt_cpf.Text;
            newPerson.Phone = txt_phone.Text;
            newPerson.BirthDate = datePicker.SelectedDate.Value;
            Database.Insert<Person>(newPerson);
        }
    }
}
