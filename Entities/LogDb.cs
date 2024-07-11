namespace Entities
{
    /// <summary>
    /// Log de acciones en la base de datos
    /// </summary>
    public class LogDb : IEntity
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
        /// Acción realizada
        /// </summary>
        public char Action { get; set; }

        /// <summary>
        /// Identificador del registro afectado en la tabla
        /// </summary>
        public long TableId { get; set; }

        /// <summary>
        /// Nombre de la tabla afectada
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// SQL ejecutado en la acción
        /// </summary>
        public string Sql { get; set; }

        /// <summary>
        /// Usuario que realiza la acción
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public LogDb()
        {
            Id = 0;
            Date = DateTime.MinValue;
            Action = ' ';
            TableId = 0;
            Table = string.Empty;
            Sql = string.Empty;
            User = new User();
        }
    }
}
