using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace _7DAYSOFCODE
{
    public partial class Form1 : Form
    {
        int counta;
        ComboBox cmb;
        private Dictionary<string, string> pokemons = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            var button = new Button
            {
                Text = "OK",
                Location = new Point(50, 50)
            };


            button.Click += new EventHandler(Button_Click);

            Controls.Add(button);
        }

        private class Pokemon
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        private class AllPokemon
        {
            public int count { get; set; }
            public string? next { get; set; }
            public string? previus { get; set; }
            public List<Pokemon> results { get; set; }
        }

        

        private async void Button_Click(object sender, EventArgs e)
        {
            

            var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonDocument = JsonDocument.Parse(content);
                    AllPokemon allPokemon = JsonSerializer.Deserialize<AllPokemon>(content);
                    var count = jsonDocument.RootElement.GetProperty("count").GetInt32();
                    var bbb = new Pokemon();
                    bbb = allPokemon.results[0] ;
                    counta = count;
                    //MessageBox.Show($"{bbb.name.ToString()} {bbb.url.ToString()}");

                    cmb = new ComboBox();
                    cmb.Location = new Point(300, 50);
                    cmb.Size = new Size(168, 20);
                    cmb.DropDownWidth = 150;
                    IncluirItens(allPokemon.results);
                    Controls.Add(cmb);


                }
                else
                {
                    Console.WriteLine($"Erro: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceção capturada: {ex}");
            }
        }

        private void IncluirItens(List<Pokemon> Pokemons)
        {
            
            for (int i = 0; i < Pokemons.Count; i++)
            {
                // Adicione o nome do Pokémon ao ComboBox
                cmb.Items.Add(Pokemons[i].name);

                // Associe a URL do Pokémon ao nome no dicionário
                pokemons[Pokemons[i].name] = Pokemons[i].url;


                //ListViewItem item = new ListViewItem(Pokemons[i].name);
                //// Associe o objeto Pokemon ao ListItem
                //item.Tag = Pokemons[i].url;
                //// Adicione o ListItem ao ComboBox
                //cmb.Items.Add(item);
            }
        }
    }

}