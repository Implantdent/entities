namespace Entities
{
    /// <summary>
    /// Causa o motivo de la atención en salud
    /// </summary>
    public class ExternalCause : IEntity
    {
        /// <summary>
        /// Identificador de la causa
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la causa
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la causa
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ExternalCause()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
