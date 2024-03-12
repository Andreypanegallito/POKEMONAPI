using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7DAYSOFCODE
{
    public partial class UserControlInitial : UserControl
    {
        public UserControlInitial()
        {
            InitializeComponent();

            btnAllPokemon.Click += new EventHandler(GoToAllPokemon);
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
