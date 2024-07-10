namespace Entities
{
    /// <summary>
    /// Pregunta de antecedentes de salud personales
    /// </summary>
    public class PersonalBackgroundQuestion : IEntity
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
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public PersonalBackgroundQuestion()
        {
            Id = 0;
            Question = string.Empty;
            AdditionalQuestion = string.Empty;
        }
    }
}
