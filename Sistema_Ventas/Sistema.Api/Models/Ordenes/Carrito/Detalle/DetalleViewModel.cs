﻿namespace Sistema.Api.Models.Ordenes.Carrito.Detalle
{
    public class DetalleViewModel
    {
        public int ProductoId { get; set; }

        public string Producto { get; set; }

        public decimal Total { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }
    }
}
