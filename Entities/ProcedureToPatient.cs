namespace Entities
{
    /// <summary>
    /// Procedimiento ejecutado sobre un paciente
    /// </summary>
    public class ProcedureToPatient : IEntity
    {
        /// <summary>
        /// Identificador del procedimiento
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que se le realiza el procedimiento
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Fecha del procedimiento
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Procedimiento realizado al paciente
        /// </summary>
        public Procedure Procedure { get; set; }

        /// <summary>
        /// Forma de ingreso del paciente al procedimiento
        /// </summary>
        public IngressVia IngressVia { get; set; }

        /// <summary>
        /// Modalidad de atención al paciente
        /// </summary>
        public Modality Modality { get; set; }

        /// <summary>
        /// Grupo de servicios al que pertenece el procedimiento
        /// </summary>
        public ServiceGroup ServiceGroup { get; set; }

        /// <summary>
        /// Servicio prestado al paciente
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Finalidad del procedimiento
        /// </summary>
        public Finality Finality { get; set; }

        /// <summary>
        /// Médico que realiza el procedimiento
        /// </summary>
        public Doctor Doctor { get; set; }

        /// <summary>
        /// Diagnóstico principal por el cual se realiza el procedimiento
        /// </summary>
        public Cie10 MainDiagnosis { get; set; }

        /// <summary>
        /// Diagnóstico relacionado por el cual se realiza el procedimiento
        /// </summary>
        public Cie10 RelatedDiagnosis { get; set; }

        /// <summary>
        /// Diagnóstico de la complicación al realizar el procedimiento, si la hay
        /// </summary>
        public Cie10 Complication { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public ProcedureToPatient()
        {
            Id = 0;
            Patient = new Patient();
            Date = DateTime.Now;
            Procedure = new Procedure();
            IngressVia = new IngressVia();
            Modality = new Modality();
            ServiceGroup = new ServiceGroup();
            Service = new Service();
            Finality = new Finality();
            Doctor = new Doctor();
            MainDiagnosis = new Cie10();
            RelatedDiagnosis = new Cie10();
            Complication = new Cie10();
        }
    }
}
