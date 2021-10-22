using MVVM_WPF_SimpleProject.Classes;
using MVVM_WPF_SimpleProject.Model;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MVVM_WPF_SimpleProject.Control
{
    public partial class PeopleList : UserControl
    {
        public List<Person> pipow = new List<Person>();

        public PeopleList()
        {
            InitializeComponent();
            ReadDB();
        }

        void ReadDB()
        {
            pipow = Database.Read<Person>();
            people.ItemsSource = pipow;
        }

    }
}
