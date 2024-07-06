namespace Entities
{
    /// <summary>
    /// País
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Identificador del país
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del país
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del país
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Country()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
