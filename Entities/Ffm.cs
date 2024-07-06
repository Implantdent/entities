namespace Entities
{
    /// <summary>
    /// Forma en que se entrega un medicamento
    /// </summary>
    public class Ffm
    {
        /// <summary>
        /// Identificador de la forma
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la forma
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la forma
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Ffm()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
