﻿namespace Sistema.Ecommerce.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Sistema.Shared.Entidades.Almacen;

    public class ProductoDataService : IProductoDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;

        public ProductoDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            this._baseAddress = "api/productos";
        }

        public async Task<IEnumerable<Producto>> Listar(int limit, DateTime? before)
        {
            var cursor = before.HasValue ? before.ToString() : "null";

            return await JsonSerializer.DeserializeAsync<IEnumerable<Producto>>(
                    await _httpClient.GetStreamAsync($"{_baseAddress}/listar/{limit}/{cursor}").ConfigureAwait(false),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                .ConfigureAwait(false);
        }

        public async Task<Producto> Mostrar(int id)
        {
            return await JsonSerializer.DeserializeAsync<Producto>(
                    await this._httpClient.GetStreamAsync($"{_baseAddress}/mostrar/{id}").ConfigureAwait(false),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Producto>> ListarPorCategoria(int categoriId, int limit, DateTime? before)
        {
            var cursor = before.HasValue ? before.ToString() : "null";

            return await JsonSerializer.DeserializeAsync<IEnumerable<Producto>>(
                    await _httpClient.GetStreamAsync($"{_baseAddress}/ListarPorCategoria/{categoriId}/{limit}/{cursor}").ConfigureAwait(false),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<Producto>> ListarPorMarca(string marca, int limit, DateTime? before)
        {
            var cursor = before.HasValue ? before.ToString() : "null";

            return await JsonSerializer.DeserializeAsync<IEnumerable<Producto>>(
                    await _httpClient.GetStreamAsync($"{_baseAddress}/ListarPorMarca/{marca}/{limit}/{cursor}").ConfigureAwait(false),
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                .ConfigureAwait(false);
        }
    }
}
