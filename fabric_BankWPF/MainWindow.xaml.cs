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
using ClassLibrary;


namespace fabric_BankWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Client client = new Client();


        public MainWindow()
        {
            InitializeComponent();

            OpenPages(pages.chooseYourLVL);

        }

        public enum pages
        {
            chooseYourLVL,
            ListPersons,
            InfoPerson
        }


        public void OpenPages(pages page)
        {
            if (page == pages.chooseYourLVL) { frame.Navigate(new ChooseAccessLVL(this)); }
            else if (page == pages.ListPersons) { frame.Navigate(new ListPersons(this)); }
            else if (page == pages.InfoPerson)
            {
                Client cl = client;
                frame.Navigate(new InfoPerson(this, cl));
            }
        }
    }
}
