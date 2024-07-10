namespace Entities
{
    /// <summary>
    /// Historia clínica
    /// </summary>
    public class ClinicHistory : IEntity
    {
        /// <summary>
        /// Identificador de la historia clínica
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que pertenece la historia clínica
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Pregunta en la historia clínica
        /// </summary>
        public ClinicHistoryQuestion Question { get; set; }

        /// <summary>
        /// Respuesta de la pregunta de la historia clínica
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// Respuesta adicional de la pregunta de la historia clínica
        /// </summary>
        public string AdditionalAnswer { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ClinicHistory()
        {
            Id = 0;
            Patient = new Patient();
            Question = new ClinicHistoryQuestion();
            Answer = string.Empty;
            AdditionalAnswer = string.Empty;
        }
    }
}
