namespace Entities
{
    /// <summary>
    /// Antecedente familiar
    /// </summary>
    public class FamilyBackground : IEntity
    {
        /// <summary>
        /// Identificador del antecedente familiar
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que pertenece el antecedente familiar
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Relación con el paciente
        /// </summary>
        public Relationship Relationship { get; set; }

        /// <summary>
        /// Descripción del antecedente familiar
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public FamilyBackground()
        {
            Id = 0;
            Patient = new Patient();
            Relationship = new Relationship();
            Description = string.Empty;
        }
    }
}
