namespace Entities
{
    /// <summary>
    /// Tipo de pregunta realizada en la historia clínica
    /// </summary>
    public class QuestionType
    {
        /// <summary>
        /// Identificador del tipo de pregunta
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del tipo de pregunta
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public QuestionType()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
