namespace Entities
{
    /// <summary>
    /// Rol de la aplicación
    /// </summary>
    public class Role : IEntity
    {
        /// <summary>
        /// Identificador del rol
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del rol
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Role()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
