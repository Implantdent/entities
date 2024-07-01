namespace Entities
{
    /// <summary>
    /// Parámetro de la aplicación
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Identificador del parámetro
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del parámetro
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor del parámetro
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Parameter()
        {
            Id = 0;
            Name = string.Empty;
            Value = string.Empty;
        }
    }
}
