using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClassLibrary
{
    public class Client
    {
        ObservableCollection<Client> clients = new ObservableCollection<Client>();
        static Random rand = new Random();

        #region Поля класса


        private List<string> surnames = new List<string>()
            {
                 "Пряников", "Валик", "Чебураев",
                "Козявкин", "Сильных", "Чурчкхелов",
                "Тарасов", "Петров", "Иванов",
                "Сидоров", "Андреев", "Косых"
            };
        private List<string> names = new List<string>()
        {
            "Артем", "Антон", "Кирилл",
            "Василий", "Виктор", "Вячеслав",
            "Тарас", "Филипп", "Денис",
            "Сергей", "Андрей", "Юрий"
        };
        private List<string> lastnames = new List<string>()
        {
            "Артемович", "Антонович", "Кириллович",
            "Васильевич", "Викторович", "Вячеславович",
            "Тарасович", "Филиппович", "Денисович",
            "Сергеевич", "Андреевич", "Юрьевич"
        };
        private List<string> phonenumbers = new List<string>()
        {
            "89011234567","89029876543","89033692581",
            "89041472583","89051597532","89067539518",
            "89077545245","89084895147","89095824567",
            "89107624158","89116852452","89129324751",
        };
        private List<string> series = new List<string>()
        {
            "1001","1002","1003",
            "1004","1005","1006",
            "1007","1008","1009",
            "1010","1011","1012",
        };
        private List<string> numbers = new List<string>()
        {
            "11111001","22221002","33331003",
            "44441004","55551005","66661006",
            "77771007","88881008","99991009",
        };
        private List<string> images = new List<string>()
        {
            "Images\\1.jpg","Images\\2.jpg",
            "Images\\3.jpg","Images\\4.jpg",
            "Images\\5.jpg","Images\\6.jpg",
            "Images\\7.jpg","Images\\8.jpg",
        };

        public string surname;
        public string name;
        public string lastname;
        public string phonenumber;
        public string seria;
        public string number;
        public string image;
        #endregion


        #region Свойства класса
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public string Seria
        {
            get { return seria; }
            set { seria = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        #endregion

        public Client()
        {
            Surname = surname;
            Name = name;
            Lastname = lastname;
            PhoneNumber = phonenumber;
            Seria = seria;
            Number = number;
            Image = image;
        }

        public ObservableCollection<Client> GenerateClients(int valueOfGeneratingClients)
        {

            for (int i = 0; i < valueOfGeneratingClients; i++)
            {
                Client client = new Client()
                {
                    Surname = surname = surnames[rand.Next(0, surnames.Count)],
                    Name = name = names[rand.Next(0, names.Count)],
                    Lastname = lastname = lastnames[rand.Next(0, lastnames.Count)],
                    PhoneNumber = phonenumber = phonenumbers[rand.Next(0, phonenumbers.Count)],
                    Seria = seria = series[rand.Next(0, series.Count)],
                    Number = number = numbers[rand.Next(0, numbers.Count)],
                    Image = image = images[rand.Next(0, images.Count)]
                };
                clients.Add(client);
            }
            return clients;
        }
    }
}
