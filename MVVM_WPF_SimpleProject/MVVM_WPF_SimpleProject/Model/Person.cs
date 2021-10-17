using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MVVM_WPF_SimpleProject.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement, NotNull] public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }

    }
}
