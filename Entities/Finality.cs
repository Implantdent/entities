namespace Entities
{
    /// <summary>
    /// Finalidad de una atención en salud
    /// </summary>
    public class Finality
    {
        /// <summary>
        /// Identificador de la finalidad
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la finalidad
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la finalidad
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Finality()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
