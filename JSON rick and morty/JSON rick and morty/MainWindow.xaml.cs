using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_rick_and_morty
{

    public partial class MainWindow : Window
    {
     

        public MainWindow()
        {
            InitializeComponent();
            string dataSetUrl = "https://rickandmortyapi.com/api/character/";

            Class1 rickAndMortyStuff=new Class1;

            using (var client = new HttpClient())
            {
                // client.BaseAddress = new Uri(dataSetUrl);
                string json = client.GetStringAsync(dataSetUrl).Result;

                rickAndMortyStuff = JsonConvert.DeserializeObject<Class1>(json);



            }

            foreach (var character in rickAndMortyStuff)
            {
                listbox.Items.Add(character);
            }

        }
    }
}
