namespace Entities
{
    /// <summary>
    /// Tipo de servicio en salud que no está dentro de los establecidos
    /// </summary>
    public class OtherServiceType
    {
        /// <summary>
        /// Identificador del tipo de servicio
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de servicio
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de servicio
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public OtherServiceType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
