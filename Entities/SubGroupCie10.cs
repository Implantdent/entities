namespace Entities
{
    /// <summary>
    /// Subgrupo del CIE versión 10
    /// </summary>
    public class SubGroupCie10 : IEntity
    {
        /// <summary>
        /// Identificador del subgrupo
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del subgrupo
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del grupo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Causas del subgrupo
        /// </summary>
        public string Causes { get; set; }

        /// <summary>
        /// Grupo al que pertenece el grupo
        /// </summary>
        public GroupCie10 Group { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public SubGroupCie10()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
            Causes = string.Empty;
            Group = new GroupCie10();
        }
    }
}
