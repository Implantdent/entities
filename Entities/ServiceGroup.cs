namespace Entities
{
    /// <summary>
    /// Grupo de servicios prestado sobre un paciente
    /// </summary>
    public class ServiceGroup : IEntity
    {
        /// <summary>
        /// Identificador del grupo de servicio
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del grupo de servicio
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del grupo de servicio
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ServiceGroup()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
