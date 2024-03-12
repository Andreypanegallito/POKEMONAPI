using System;
using _7DAYSOFCODE.Classes;
using System.Text.Json;


namespace _7DAYSOFCODE.components
{
    public partial class UserControlPokemon : UserControl
    {
        private string urlPokemon;

        public UserControlPokemon(string urlPokemon)
        {
            InitializeComponent();
            this.urlPokemon = urlPokemon;

            LoadPokemonAsync();

            btnToHome.Click += new EventHandler(GoToHome);
            btnToAllPokemon.Click += new EventHandler(GoToAllPokemon);
        }

        private async void LoadPokemonAsync()
        {
            Pokemon pokemon = await GetPokemonAsync();
            if (pokemon != null)
            {
                var teste = pokemon.sprites.other.official_artwork;
                label1.Text = pokemon.name;
                lblHeight.Text = $"{pokemon.height} cm";
                lblWeight.Text = $"{pokemon.weight}";
                lblBase.Text = $"{pokemon.base_experience}";
                imgPokemon.ImageLocation = $"{teste.front_default}";
            }
        }

        private async Task<Pokemon> GetPokemonAsync()
        {
            var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync(urlPokemon);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonDocument = JsonDocument.Parse(content);
                    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(content);

                    return pokemon;
                }
                else
                {
                    Console.WriteLine($"Erro: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceção capturada: {ex}");
                return null;
            }
        }

        private void GoToHome(object sender, EventArgs e)
        {
            UserControlInitial ucInitial = new UserControlInitial();
            ucInitial.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucInitial);
        }

        private void GoToAllPokemon(object sender, EventArgs e)
        {
            UserControlAllPokemon ucAllPokemon = new UserControlAllPokemon();
            ucAllPokemon.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucAllPokemon);
        }
    }
}
