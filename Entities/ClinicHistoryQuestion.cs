namespace Entities
{
    /// <summary>
    /// Pregunta de la historia clínica
    /// </summary>
    public class ClinicHistoryQuestion : IEntity
    {
        /// <summary>
        /// Identificador de la pregunta
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Texto de la pregunta
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Texto de la pregunta adicional
        /// </summary>
        public string AdditionalQuestion { get; set; }

        /// <summary>
        /// Tipo de pregunta
        /// </summary>
        public QuestionType QuestionType { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ClinicHistoryQuestion()
        {
            Id = 0;
            Question = string.Empty;
            AdditionalQuestion = string.Empty;
            QuestionType = new QuestionType();
        }
    }
}
