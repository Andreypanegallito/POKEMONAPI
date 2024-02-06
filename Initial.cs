using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace _7DAYSOFCODE
{
    public partial class Initial : Form
    {
        
        public Initial()
        {
            InitializeComponent();

            var button = new Button
            {
                Text = "Todos os Pokemons",
                Location = new Point(50, 50),
                Width = 100,
                Height = 100,
            };


            button.Click += new EventHandler(GoToAllPokemon);

            Controls.Add(button);
        }



        private async void GoToAllPokemon(object sender, EventArgs e)
        {
            UserControlAllPokemon ucAllPokemon = new UserControlAllPokemon();
            ucAllPokemon.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucAllPokemon);
        }
    }

}