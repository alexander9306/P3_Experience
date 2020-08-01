namespace Sistema.Ecommerce
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Sistema.Ecommerce.Helpers;
    using Sistema.Ecommerce.Services;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            var baseAddress = "https://localhost:44303/api";

            builder.Services.AddHttpClient<IProductoDataService, ProductoDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/productos/"));

            builder.Services.AddHttpClient<ICategoriaDataService, CategoriaDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/categorias/"));

            builder.Services.AddHttpClient<IMarcaDataService, MarcaDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/marcas/"));

            builder.Services.AddHttpClient<ICarritoDataService, CarritoDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/carritos/"));

            builder.Services.AddHttpClient<IOrdenDataService, OrdenDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/ordenes/"));

            builder.Services.AddHttpClient<IPedidoDataService, PedidoDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/pedidos/"));

            builder.Services.AddHttpClient<IPagoDataService, PagoDataService>(client =>
                client.BaseAddress = new Uri(baseAddress + "/pagos/"));

            builder.Services.AddSingleton<IProductoHelper, ProductoHelper>();

            await builder.Build().RunAsync().ConfigureAwait(false);
        }
    }
}
