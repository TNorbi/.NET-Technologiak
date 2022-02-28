using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Model;

namespace UserApp.ViewModel
{
    public class MainViewModel
    { 
        public User User { get; set; }

        public MainViewModel()
        {
            User = new User() {Name="Cortana" ,Age=19};
        }

        public void ChangeName(string newName)
        {
            User.Name = newName;
        }

        public void ChangeAge(int newAge)
        {
            User.Age = newAge;
        }

        public void ChangeGender(string newGender)
        {
            User.Gender = newGender;
        }
    }
}
