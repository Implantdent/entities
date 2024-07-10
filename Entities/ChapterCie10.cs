namespace Entities
{
    /// <summary>
    /// Capítulo de la CIE versión 10
    /// </summary>
    public class ChapterCie10 : IEntity
    {
        /// <summary>
        /// Identificador del capítulo
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del capítulo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valoes por defecto
        /// </summary>
        public ChapterCie10()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
