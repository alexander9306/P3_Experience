namespace Sistema.Ecommerce.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Sistema.Shared.Entidades.Almacen;

    public interface ICategoriaDataService
    {
        Task<IEnumerable<Categoria>> Listar();
    }
}