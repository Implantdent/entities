namespace Entities
{
    /// <summary>
    /// Relación con un paciente
    /// </summary>
    public class Relationship : IEntity
    {
        /// <summary>
        /// Identificador de la relación
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre de la relación
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Relationship()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
