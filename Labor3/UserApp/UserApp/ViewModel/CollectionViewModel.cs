using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Model;

namespace UserApp.ViewModel
{
    class CollectionViewModel
    {
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator" ,Age=27,Gender="Female"});
            Users.Add(new User() { Name = "Harry" ,Age=18,Gender="Male"});
            Users.Add(new User() { Name = "Blackhawk" ,Age=35,Gender="Male"});
            Users.Add(new User() { Name = "User001",Age=78,Gender="Female" });
            Users.Add(new User() { Name = "Cortana" ,Age=18,Gender="Female"});
        }

        public ObservableCollection<User> Users { get; set; }
    }
}
