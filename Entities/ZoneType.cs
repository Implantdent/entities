namespace Entities
{
    /// <summary>
    /// Tipo de zona en una ubicación geográfica
    /// </summary>
    public class ZoneType : IEntity
    {
        /// <summary>
        /// Identificador de la zona
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la zona
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la zona
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ZoneType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
