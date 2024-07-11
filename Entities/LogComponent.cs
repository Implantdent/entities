namespace Entities
{
    /// <summary>
    /// Log de acciones en los componentes de la aplicación
    /// </summary>
    public class LogComponent : IEntity
    {
        /// <summary>
        /// Identificador del log
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public char Type { get; set; }

        /// <summary>
        /// Controlador consultado en la aplicación
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Método consultado en la aplicación
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Datos de entrada del método
        /// </summary>
        public string Input { get; set; }

        /// <summary>
        /// Datos de salida del método
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        /// Usuario que realiza la acción
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public LogComponent()
        {
            Id = 0;
            Date = DateTime.MinValue;
            Type = ' ';
            Controller = string.Empty;
            Method = string.Empty;
            Input = string.Empty;
            Output = string.Empty;
            User = new User();
        }
    }
}
