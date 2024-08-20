using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POKEMONAPI
{
    public partial class UserControlInitial : UserControl
    {
        private readonly Initial initial;
        public UserControlInitial(Initial initial)
        {
            this.initial = initial;
            InitializeComponent();

            btnAllPokemon.Click += new EventHandler(GoToAllPokemon);
        }

        private async void GoToAllPokemon(object sender, EventArgs e)
        {
            UserControlAllPokemon ucAllPokemon = new UserControlAllPokemon(initial);
            ucAllPokemon.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucAllPokemon);
        }
    }
}
