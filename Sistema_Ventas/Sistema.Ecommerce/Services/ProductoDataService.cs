﻿namespace Sistema.Ecommerce.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Sistema.Shared.Entidades.Almacen;

    public class ProductoDataService : IProductoDataService
    {
        public Task<IEnumerable<Producto>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
