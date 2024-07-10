namespace Entities
{
    /// <summary>
    /// CIE versión 10
    /// </summary>
    public class Cie10 : IEntity
    {
        /// <summary>
        /// Identificador de la enfermedad
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la enfermedad
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la enfermedad
        /// </summary>
        public string Name { get; set; }

        public SubGroupCie10 SubGroupCie10 { get; set; }

        /// <summary>
        /// Inicializa el objeto con valoes por defecto
        /// </summary>
        public Cie10()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
            SubGroupCie10 = new SubGroupCie10();
        }
    }
}
