﻿namespace Sistema.Ecommerce.Services
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Sistema.Shared.Entidades.Almacen;

    public class CategoriaDataService: ICategoriaDataService
    {
        private readonly HttpClient _httpClient;

        public CategoriaDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<Categoria>> Listar()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Categoria>>(
                    await _httpClient.GetStreamAsync($"listar").ConfigureAwait(false),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                .ConfigureAwait(false);
        }

    }
}