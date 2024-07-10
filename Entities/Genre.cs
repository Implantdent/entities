namespace Entities
{
    /// <summary>
    /// Género del paciente
    /// </summary>
    public class Genre : IEntity
    {
        /// <summary>
        /// Identificador del género
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del género
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del género
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Genre()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
