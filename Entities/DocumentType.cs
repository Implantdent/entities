namespace Entities
{
    /// <summary>
    /// Tipo de documento de identificación
    /// </summary>
    public class DocumentType : IEntity
    {
        /// <summary>
        /// Identificador del tipo de documento
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de documento
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de documento
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public DocumentType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
