namespace Sistema.Shared.Entidades.Usuario
{
    using System;

    public class Administrador
    {
        public int Id { get; set; }

        public string Rol { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Estado { get; set; }

    }
}
/*reynaldo yunior*/