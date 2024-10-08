﻿using System;
using POKEMONAPI.Classes;
using System.Text.Json;


namespace POKEMONAPI.components
{
    public partial class UserControlPokemon : UserControl
    {
        private readonly Initial initial;
        private string urlPokemon;

        public UserControlPokemon(Initial initial, string urlPokemon)
        {
            this.initial = initial;
            InitializeComponent();
            this.urlPokemon = urlPokemon;

            LoadPokemonAsync();

            btnToHome.Click += new EventHandler(GoToHome);
            btnToAllPokemon.Click += new EventHandler(GoToAllPokemon);
        }

        private async void LoadPokemonAsync()
        {
            Pokemon pokemon = await PokemonCache.GetPokemonDetailsAsync(urlPokemon);
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

        private void GoToHome(object sender, EventArgs e)
        {
            UserControlInitial ucInitial = new UserControlInitial(initial);
            ucInitial.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucInitial);
        }

        private void GoToAllPokemon(object sender, EventArgs e)
        {
            UserControlAllPokemon ucAllPokemon = new UserControlAllPokemon(initial);
            ucAllPokemon.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(ucAllPokemon);
        }
    }
}
