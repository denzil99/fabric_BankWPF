using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface ILvlAccess
    {

        string Position { get; set; }
        string Posibilities { get; set; }

        //private ObservableCollection<string> dolgnost = new ObservableCollection<string>() { "advisor", "manager" };
        //private string selectedDolgnost;
        //public ObservableCollection<string> Dolgnost { get { return dolgnost; } }
        //public string SelectedDolgnost { get { return selectedDolgnost; } set { selectedDolgnost = value; } }
    }
}
