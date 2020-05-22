using System;
using System.Collections.Generic;

namespace ConcreteModel
{
    [Serializable]
    // Клас базы данных пациентов, так же отмечает как Serializable, ибо лист не будет сохранятся в файл
    public class PatientDB
    {
        public List<Patient> Patients { get; set; }

        public PatientDB()
        {
            Patients = new List<Patient>();
        }
    }
}
