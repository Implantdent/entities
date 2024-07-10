namespace Entities
{
    /// <summary>
    /// Servicio prestado sobre un paciente
    /// </summary>
    public class Service : IEntity
    {
        /// <summary>
        /// Identificador del servicio
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del servicio
        /// </summary>
        public short Code { get; set; }

        /// <summary>
        /// Nombre del servicio
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Service()
        {
            Id = 0;
            Code = 0;
            Name = string.Empty;
        }
    }
}
