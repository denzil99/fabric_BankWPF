using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace fabric_BankWPF
{
    /// <summary>
    /// Логика взаимодействия для ChooseAccessLVL.xaml
    /// </summary>
    public partial class ChooseAccessLVL : Page
    {
        public MainWindow ma;
        //static public string yourLVL;



        public ChooseAccessLVL(MainWindow _mainWindow)
        {
            InitializeComponent();
            ma = _mainWindow;
            ComboBoxAccessLVL.SelectionChanged += ComboBoxAccessLVL_SelectionChanged;

        }

        public ChooseAccessLVL() { }

        private void ComboBoxAccessLVL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            yourLVL = ComboBoxAccessLVL.SelectedValue as string;
            ma.OpenPages(MainWindow.pages.ListPersons);

        }

        public static void rewriteClients(Client oldClient, Client newClient)
        {
            clients.Remove(oldClient);
            clients.Add(newClient);


        }
    }
}
