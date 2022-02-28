using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.Model
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private string gender;
        public string Name {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            } 
        }
        
        public int Age {
            get { return age; }
            set { 
                age = value;
                OnPropertyChanged("Age");
            } 
        }
        public string Gender {
            get { return gender; }
            set { 
                gender = value;
                OnPropertyChanged("Gender");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
