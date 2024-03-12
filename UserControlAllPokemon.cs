using System;
using System.Text.Json;
using _7DAYSOFCODE.Classes;
using _7DAYSOFCODE.components;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _7DAYSOFCODE
{
    public partial class UserControlAllPokemon : UserControl
    {
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


        int counta;
        private Dictionary<string, string> pokemons = new Dictionary<string, string>();
        private Panel panel;
        private UserControlLoader loader;

        public UserControlAllPokemon()
        {
            InitializeComponent();

            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);

            // Crie o "loader"
            loader = new UserControlLoader();

            BuscarPokemons();
        }

        private void MostrarLoader()
        {
            this.Invalidate();

            // Adicione o "loader" ao Controls
            this.Controls.Add(loader);

            // Defina o Anchor do loader
            loader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Aumente o tamanho do loader
            int newWidthLoader = Convert.ToInt32(this.Width);
            //int newWidthLoader = Convert.ToInt32(Math.Round(this.Width * 0.75));
            int newHeightLoader = Convert.ToInt32(this.Height);
            //int newHeightLoader = Convert.ToInt32(Math.Round(this.Height * 0.75));
            loader.Size = new Size(newWidthLoader, newHeightLoader);

            var panelLoader = loader.Controls[0];
            var labelTextLoader = panelLoader.Controls[0];

            this.Invalidate();

            loader.BringToFront();

            // Force a atualização da tela
            this.Invalidate();
        }

        private void UserControlAllPokemon_SizeChanged(object sender, EventArgs e)
        {
            loader.Size = this.Size;
        }

        private void OcultarLoader()
        {
            // Remova o "loader" do Controls
            this.Controls.Remove(loader);
        }

        private async void BuscarPokemons()
        {
            MostrarLoader();

            // Carregar os Pokemons em segundo plano
            List<Pokemon> pokemons = await PokemonCache.GetPokemonsAsync();

            if (pokemons != null)
            {
                IncluirItens(pokemons);
            }

            OcultarLoader();
        }

        //private static async Task<List<Pokemon>> GetPokemonsAsync()
        //{
        //    var httpClient = new HttpClient();

        //    try
        //    {
        //        var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?offset=0&limit=300");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            var jsonDocument = JsonDocument.Parse(content);
        //            AllPokemons allPokemons = JsonSerializer.Deserialize<AllPokemons>(content);
        //            var count = jsonDocument.RootElement.GetProperty("count").GetInt32();
        //            List<Pokemon> pokemons;
        //            pokemons = allPokemons?.results;


        //            return pokemons;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Erro: {response.StatusCode}");
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Exceção capturada: {ex}");
        //        return null;
        //    }
        //}

        private void IncluirItens(List<Pokemon> Pokemons)
        {

            for (int i = 0; i < Pokemons.Count; i++)
            {
                // Crie um novo botão para o Pokémon
                Button button = new Button();
                button.Text = Pokemons[i].name;
                button.AutoSize = true;

                // Associe a URL do Pokémon ao botão
                button.Tag = Pokemons[i].url;
                Pokemon pokemon = Pokemons[i];
                button.Click += (sender, e) => GoToPokemonDetails(pokemon);

                // Adicione o botão ao FlowLayoutPanel
                flowLayoutPanel.Controls.Add(button);
            }
        }

        private async void GoToPokemonDetails(Pokemon pokemon)
        {
            this.Controls.Clear();
            RemoverTela();
            var urlPokemon = pokemon.url.ToString();
            UserControlPokemon ucPokemon = new UserControlPokemon(urlPokemon);
            ucPokemon.Dock = DockStyle.Fill;
            this.Controls.Add(ucPokemon);
        }
    }
}
