﻿namespace Sistema.Ecommerce.Helpers
{
    using CloudinaryDotNet;
    using Sistema.Shared.Entidades.Almacen;

    public class ProductoHelper : IProductoHelper
    {
        public ProductoHelper()
        {
            var account = new Account("alexander-damaso-26857");
            this._cloudinary = new Cloudinary(account);
        }

        private readonly Cloudinary _cloudinary;

        public string GetFotoUrl(ProductoFoto? foto, int width = 338, int height = 250)
        {

            if (foto == null)
            {
                return this._cloudinary.Api.UrlImgUp.Transform(
                    new Transformation().Width(width).Height(height)).BuildUrl("112815953-no-image-available-icon-flat-vector_a5tdo9.jpg");
            }

            return this._cloudinary.Api.UrlImgUp.Transform(
                new Transformation().Width(width).Height(height)).BuildUrl(foto.FotoPublicId);
        }

        public string GetDescripcion(string descripcion)
        {
            if (descripcion == null)
            {
                return string.Empty;
            }

            return descripcion.Length < 60 ? descripcion : descripcion.Substring(0, 60) + "...";
        }
    }
}