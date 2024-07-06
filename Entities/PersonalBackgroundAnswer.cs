namespace Entities
{
    /// <summary>
    /// Respuesta de pregunta de antecedentes de salud personales
    /// </summary>
    public class PersonalBackgroundAnswer
    {
        /// <summary>
        /// Identificador de la respuesta
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Paciente que responde la pregunta de antecedente personal
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Pregunta que se responde del antecedente personal
        /// </summary>
        public PersonalBackgroundQuestion Question { get; set; }

        /// <summary>
        /// Respuesta del paciente
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// Respuesta adicional del paciente
        /// </summary>
        public string AdditionalAnswer { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public PersonalBackgroundAnswer()
        {
            Id = 0;
            Patient = new Patient();
            Question = new PersonalBackgroundQuestion();
            Answer = string.Empty;
            AdditionalAnswer = string.Empty;
        }
    }
}
