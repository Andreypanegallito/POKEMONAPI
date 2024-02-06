using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7DAYSOFCODE
{
    public partial class UserControlAllPokemon : UserControl
    {
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


        int counta;
        private Dictionary<string, string> pokemons = new Dictionary<string, string>();

        public UserControlAllPokemon()
        {
            InitializeComponent();

            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);

            BuscarPokemons();
        }

        private class Pokemon
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        private class AllPokemons
        {
            public int count { get; set; }
            public string? next { get; set; }
            public string? previus { get; set; }
            public List<Pokemon> results { get; set; }
        }

        private async void BuscarPokemons()
        {
            var httpClient = new HttpClient();

            // Crie um painel para escurecer o fundo
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            //panel.BackColor = Color.FromArgb(128, 0, 0, 0);  // Cor preta semi-transparente
            this.Controls.Add(panel);

            // Crie um novo Label
            Label label = new Label();
            label.Text = "Carregando...";
            panel.Controls.Add(label);

            // Crie a barra de progresso
            ProgressBar progressBar = new ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;  // Atualize isso com o número real de itens
            progressBar.Top = (this.ClientSize.Height - progressBar.Height) / 2;
            progressBar.Left = (this.ClientSize.Width - progressBar.Width) / 2;
            panel.Controls.Add(progressBar);


            try
            {
                var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?offset=0&limit=300");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonDocument = JsonDocument.Parse(content);
                    AllPokemons allPokemons = JsonSerializer.Deserialize<AllPokemons>(content);
                    var count = jsonDocument.RootElement.GetProperty("count").GetInt32();
                    var bbb = new Pokemon();
                    bbb = allPokemons.results[0];
                    counta = count;

                    IncluirItens(allPokemons.results);


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
            finally
            {
                // Mostre o painel e a barra de progresso
                panel.Visible = true;
                progressBar.Visible = true;
            }
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

                // Adicione o botão ao FlowLayoutPanel
                flowLayoutPanel.Controls.Add(button);
            }
        }
    }
}
