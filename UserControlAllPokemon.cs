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
        private readonly Initial initial;
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


        int counta;
        private Dictionary<string, string> pokemons = new Dictionary<string, string>();
        private Panel panel;
        private UserControlLoader loader;


        public UserControlAllPokemon(Initial initial)
        {
            this.initial = initial;
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
            //RemoverTela();
            var urlPokemon = pokemon.url.ToString();
            UserControlPokemon ucPokemon = new UserControlPokemon(initial, urlPokemon);
            ucPokemon.Dock = DockStyle.Fill;
            this.Controls.Add(ucPokemon);
        }
    }
}
