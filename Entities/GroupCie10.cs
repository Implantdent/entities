namespace Entities
{
    /// <summary>
    /// Grupo del CIE versión 10
    /// </summary>
    public class GroupCie10
    {
        /// <summary>
        /// Identificador del grupo
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del grupo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Capítulo al que pertenece el grupo
        /// </summary>
        public ChapterCie10 Chapter { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public GroupCie10()
        {
            Id = 0;
            Name = string.Empty;
            Chapter = new ChapterCie10();
        }
    }
}
