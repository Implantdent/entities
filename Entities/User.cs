namespace Entities
{
    /// <summary>
    /// Usuario de la aplicación
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Email y usuario de acceso del usuario
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Si el usuario está o no activo
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public User()
        {
            Id = 0;
            Email = string.Empty;
            Name = string.Empty;
            Active = false;
        }
    }
}
