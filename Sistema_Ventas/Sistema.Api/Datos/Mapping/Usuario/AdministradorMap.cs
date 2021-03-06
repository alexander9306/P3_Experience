﻿namespace Sistema.Api.Datos.Mapping.Usuario
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sistema.Api.Entidades.Usuario;
    using Sistema.Api.Helpers;

    public class AdministradorMap : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            var passwordHelper = new PasswordHelper();
            passwordHelper.CrearPasswordHash("admin01", out var adminPass);
            passwordHelper.CrearPasswordHash("organizador", out var orgaPass);

            builder.HasIndex(a => a.Email)
                .IsUnique();
            builder.HasIndex(a => a.Username)
                .IsUnique();
            builder.HasData(new Administrador
            {
                Id = 1,
                RolId = 1,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                Estado = true,
                Email = "admin@gmail.com".ToUpperInvariant(),
                Username = "admin01".ToUpperInvariant(),
                PasswordHash = adminPass,
            },
            new Administrador
            {
                Id = 2,
                RolId = 2,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                Estado = true,
                Email = "organizador@gmail.com".ToUpperInvariant(),
                Username = "organizador".ToUpperInvariant(),
                PasswordHash = orgaPass,
            }
            );
        }
    }
}