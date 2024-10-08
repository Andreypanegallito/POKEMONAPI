﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace POKEMONAPI.Classes
{
    public class AllPokemons
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previus { get; set; }
        public List<Pokemon> results { get; set; }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Stats> stats { get; set; }
        public Sprite sprites { get; set; }
    }

    public class PokemonCache
    {
        private static List<Pokemon> _pokemons;
        private static Dictionary<string, Pokemon> _pokemonDetailsCache = new Dictionary<string, Pokemon>();

        public static async Task<List<Pokemon>> GetPokemonsAsync()
        {
            if (_pokemons == null)
            {
                _pokemons = await FetchPokemonsFromAPI();
            }

            return _pokemons;
        }

        private static async Task<List<Pokemon>> FetchPokemonsFromAPI()
        {
            var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?offset=0&limit=300");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonDocument = JsonDocument.Parse(content);
                    AllPokemons allPokemons = JsonSerializer.Deserialize<AllPokemons>(content);
                    var count = jsonDocument.RootElement.GetProperty("count").GetInt32();
                    List<Pokemon> pokemons;
                    pokemons = allPokemons?.results;

                    return pokemons;
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

        public static async Task<Pokemon> GetPokemonDetailsAsync(string urlPokemon)
        {
            if (_pokemonDetailsCache.TryGetValue(urlPokemon, out var cachedPokemon))
            {
                return cachedPokemon;
            }

            // Se não estiver no cache, faça a requisição à API
            var pokemon = await FetchPokemonDetailsFromAPI(urlPokemon);
            if (pokemon != null)
            {
                // Adicione o Pokémon ao cache de detalhes
                _pokemonDetailsCache[urlPokemon] = pokemon;
            }

            return pokemon;
        }

        private static async Task<Pokemon> FetchPokemonDetailsFromAPI(string urlPokemon)
        {
            var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync(urlPokemon);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
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
    }
}
