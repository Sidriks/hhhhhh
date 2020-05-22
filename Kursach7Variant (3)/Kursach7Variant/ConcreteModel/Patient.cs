using System;

namespace ConcreteModel
{
    [Serializable]
    //Базовый класс Пациента с его данными, атрибут Serializable поможет нам в сохранении данных
    public class Patient
    {
        public int ID;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string AccountNumber { get; set; }
        public string TypeOfWork { get; set; }
        public int Cost { get; set; }
        public bool PaymentStamp { get; set; }
        public int Debt { get; set; }
    }
}
