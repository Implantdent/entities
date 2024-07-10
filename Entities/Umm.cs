namespace Entities
{
    /// <summary>
    /// Unidad de medida de un medicamento
    /// </summary>
    public class Umm : IEntity
    {
        /// <summary>
        /// Identificador de la unidad de medida
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la unidad de medida
        /// </summary>
        public short Code { get; set; }

        /// <summary>
        /// Nombre de la unidad de medida
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Umm()
        {
            Id = 0;
            Code = 0;
            Name = string.Empty;
        }
    }
}
