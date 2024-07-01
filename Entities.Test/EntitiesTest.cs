namespace Entities.Test
{
    /// <summary>
    /// Pruebas de creaciónde las entidades
    /// </summary>
    public class EntitiesTest
    {
        /// <summary>
        /// Prueba la creación de un capítulo de la CIE versión 10
        /// </summary>
        [Fact]
        public void ChapterCie10Test()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ChapterCie10>(new ChapterCie10());
        }

        /// <summary>
        /// Prueba la creación de un país
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Country>(new Country());
        }

        /// <summary>
        /// Prueba la creación de un medicamento
        /// </summary>
        [Fact]
        public void CumTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Cum>(new Cum());
        }

        /// <summary>
        /// Prueba la creación de un destino
        /// </summary>
        [Fact]
        public void DestinyPatientTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DestinyPatient>(new DestinyPatient());
        }

        /// <summary>
        /// Prueba la creación de un tipo de diagnóstico
        /// </summary>
        [Fact]
        public void DiagnosisTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DiagnosisType>(new DiagnosisType());
        }

        /// <summary>
        /// Prueba la creación de un tipo de documento
        /// </summary>
        [Fact]
        public void DocumentTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DocumentType>(new DocumentType());
        }

        /// <summary>
        /// Prueba la creación de una causa de atención
        /// </summary>
        [Fact]
        public void ExternalCauseTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ExternalCause>(new ExternalCause());
        }

        /// <summary>
        /// Prueba la creación de una forma de entrega de un medicamento
        /// </summary>
        [Fact]
        public void FfmTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Ffm>(new Ffm());
        }

        /// <summary>
        /// Prueba la creación de una finalidad
        /// </summary>
        [Fact]
        public void FinalityTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Finality>(new Finality());
        }

        /// <summary>
        /// Prueba la creación de un formato
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Format>(new Format());
        }

        /// <summary>
        /// Prueba la creación de un género
        /// </summary>
        [Fact]
        public void GenreTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Genre>(new Genre());
        }

        /// <summary>
        /// Prueba la creación de un grupo de CIE10
        /// </summary>
        [Fact]
        public void GroupCie10Test()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<GroupCie10>(new GroupCie10());
        }

        /// <summary>
        /// Prueba la creación de una vía de ingreso
        /// </summary>
        [Fact]
        public void IngressViaTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<IngressVia>(new IngressVia());
        }

        /// <summary>
        /// Prueba la creación de un medicamento alternativo
        /// </summary>
        [Fact]
        public void IumTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Ium>(new Ium());
        }

        /// <summary>
        /// Prueba la creación de un tipo de medicamento
        /// </summary>
        [Fact]
        public void MedicineTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<MedicineType>(new MedicineType());
        }

        /// <summary>
        /// Prueba la creación de una modalidad
        /// </summary>
        [Fact]
        public void ModalityTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Modality>(new Modality());
        }

        /// <summary>
        /// Prueba la creación de un tipo de servicio no establecido
        /// </summary>
        [Fact]
        public void OtherServiceTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<OtherServiceType>(new OtherServiceType());
        }

        /// <summary>
        /// Prueba la creación de un parámetro
        /// </summary>
        [Fact]
        public void ParameterTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Parameter>(new Parameter());
        }

        /// <summary>
        /// Prueba la creación de un tipo de paciente
        /// </summary>
        [Fact]
        public void PatientTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PatientType>(new PatientType());
        }

        /// <summary>
        /// Prueba la creación de un tipo de pago
        /// </summary>
        [Fact]
        public void PaymentTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PaymentType>(new PaymentType());
        }

        /// <summary>
        /// Prueba la creación de una pregunta de antecedentes personales
        /// </summary>
        [Fact]
        public void PersonalBackgroundQuestionTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PersonalBackgroundQuestion>(new PersonalBackgroundQuestion());
        }

        /// <summary>
        /// Prueba la creación de un procedimiento
        /// </summary>
        [Fact]
        public void ProcedureTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Procedure>(new Procedure());
        }

        /// <summary>
        /// Prueba la creación de un tipo de pregunta
        /// </summary>
        [Fact]
        public void QuestionTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<QuestionType>(new QuestionType());
        }

        /// <summary>
        /// Prueba la creación de una relación
        /// </summary>
        [Fact]
        public void RelationshipTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Relationship>(new Relationship());
        }

        /// <summary>
        /// Prueba la creación de un servicio
        /// </summary>
        [Fact]
        public void ServiceTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Service>(new Service());
        }

        /// <summary>
        /// Prueba la creación de un grupo de servicio
        /// </summary>
        [Fact]
        public void ServiceGroupTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ServiceGroup>(new ServiceGroup());
        }

        /// <summary>
        /// Prueba la creación de un departamento
        /// </summary>
        [Fact]
        public void StateTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<State>(new State());
        }

        /// <summary>
        /// Prueba la creación de un subgrupo de CIE10
        /// </summary>
        [Fact]
        public void SubGroupCie10Test()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<SubGroupCie10>(new SubGroupCie10());
        }

        /// <summary>
        /// Prueba la creación de una medida de medicamento
        /// </summary>
        [Fact]
        public void UmmTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Umm>(new Umm());
        }

        /// <summary>
        /// Prueba la creación de una medida mímima de medicamento dispensada
        /// </summary>
        [Fact]
        public void UprTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Upr>(new Upr());
        }

        /// <summary>
        /// Prueba la creación de un usuario
        /// </summary>
        [Fact]
        public void UserTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<User>(new User());
        }

        /// <summary>
        /// Prueba la creación de una zona
        /// </summary>
        [Fact]
        public void ZoneTypeTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ZoneType>(new ZoneType());
        }
    }
}