namespace Entities
{
    /// <summary>
    /// Entidad promotora de salud
    /// </summary>
    public class Eps : IEntity
    {
        /// <summary>
        /// Identificador de la eps
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la eps
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la eps
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Eps()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
