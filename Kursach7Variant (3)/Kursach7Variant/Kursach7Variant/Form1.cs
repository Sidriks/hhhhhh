using ConcreteModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Kursach7Variant
{
    public partial class Form1 : Form
    {
        private int Patient_ID = 0;
        //поле помечанное как readonly не может быть изменено в ходе работы в метордах , свойствах и тд, а талько в конструкторе типа
        private readonly PatientDB patientDB;
        public Form1()
        {
            //инициализация списка при создании формы
            patientDB = new PatientDB();
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Выдача инфы 
            MessageBox.Show("Kursach 7 variant");
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            //закрытие приложения
            Environment.Exit(0);
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            //Метод добавления фильтрует данные поступающие с боксов, строка erroroField нужна для сохранения сведенья о поле, которое вызвало ошибку
            string errorField = null;
            if (string.IsNullOrEmpty(patientTextBox.Text) || string.IsNullOrEmpty(patientLastNameTextBox.Text)
                || string.IsNullOrEmpty(patientMiddleNameTextBox.Text) || string.IsNullOrEmpty(costTextBox.Text)
                || string.IsNullOrEmpty(debtTextBox.Text) || string.IsNullOrEmpty(patientAccountNumberTextBox.Text))
            {
                MessageBox.Show("Not all text boxes were filled");
            }
            else if (Filters.FilterByFIO(patientTextBox.Text, out errorField) || Filters.FilterByFIO(patientLastNameTextBox.Text, out errorField)
                || Filters.FilterByFIO(patientMiddleNameTextBox.Text, out errorField) || Filters.FilterByCost(costTextBox.Text, out errorField) ||
                Filters.FilterByDebt(debtTextBox.Text, out errorField) || Filters.FilterByAccountNumber(patientAccountNumberTextBox.Text, out errorField))
            {
                MessageBox.Show($"Not correct {errorField}", "Validation Error");
            }
            else
            {
                //Добавляем юзеров в БД и таблицу на главном экране

                registrationPatientGridView.Rows.Add(Patient_ID++, patientTextBox.Text, patientLastNameTextBox.Text, patientMiddleNameTextBox.Text,
                    patientAccountNumberTextBox.Text, workTypeComboBox.Text, costTextBox.Text, paymentStampCheckBox.Checked, debtTextBox.Text);

                patientDB.Patients.Add(new Patient
                {
                    ID = +1,
                    Name = patientTextBox.Text,
                    LastName = patientLastNameTextBox.Text,
                    MiddleName = patientMiddleNameTextBox.Text,
                    Debt = int.Parse(debtTextBox.Text),
                    PaymentStamp = paymentStampCheckBox.Checked,
                    Cost = int.Parse(costTextBox.Text),
                    AccountNumber = patientAccountNumberTextBox.Text,
                    TypeOfWork = workTypeComboBox.Text
                });
            }
            errorField = null;
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            searchGridView.Rows.Clear();
            //Ищем паацинетов с заданной фамилией , если таких пациентов больше чем 1 то выдаем информацию о том, что их больше чем один и заполняем таблицу во второй вкладке
            int count = 0;
            var patientRecords = patientDB.Patients.Where(patientLastName => patientLastName.LastName.Contains(searchLastNameTextBox.Text)).Select(patient => patient);
            if (patientRecords.Count() > 1)
            {
                MessageBox.Show("More than one patient", "Patient Count Exception");
            }
            for (int i = 0; i < patientRecords.Count(); i++)
            {
                count++;
                searchGridView.Rows.Add(count, patientRecords.ElementAt(i).Name,
                    patientRecords.ElementAt(i).LastName,
                    patientRecords.ElementAt(i).MiddleName,
                    patientRecords.ElementAt(i).AccountNumber,
                    patientRecords.ElementAt(i).TypeOfWork,
                    patientRecords.ElementAt(i).Cost,
                    patientRecords.ElementAt(i).PaymentStamp,
                    patientRecords.ElementAt(i).Debt);

            }
        }

        private void searchDebtButton_Click(object sender, EventArgs e)
        {
            searchGridView.Rows.Clear();
            //Ищем всех должников с долгами по процедуре и заполняем таблицу во второй вкладке
            int count = 0;
            var debtPatients = patientDB.Patients.Where(workType => (workType.TypeOfWork == searchDebtComboBox.Text) && workType.Debt > 0).Select(patient => patient);
            var debtAmount = debtPatients.Sum(patient => patient.Debt);
            if (debtPatients.Count() != 0)
            {
                for (int i = 0; i < debtPatients.Count(); i++)
                {
                    count++;
                    searchGridView.Rows.Add(count, debtPatients.ElementAt(i).Name,
                        debtPatients.ElementAt(i).LastName,
                        debtPatients.ElementAt(i).MiddleName,
                        debtPatients.ElementAt(i).AccountNumber,
                        debtPatients.ElementAt(i).TypeOfWork,
                        debtPatients.ElementAt(i).Cost,
                        debtPatients.ElementAt(i).PaymentStamp,
                        debtPatients.ElementAt(i).Debt);
                }
                MessageBox.Show($"Amount of general debt {debtAmount}");
            }
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            var count = patientDB.Patients.Where(patient => patient.Debt == 0).Select(patientId => patientId.ID);
            //Удаляем пациентов долг которых = 0 в БД и таблице
            foreach (var id in count)
            {
                registrationPatientGridView.Rows.RemoveAt(id);
            }
            patientDB.Patients.RemoveAll(debt => debt.Debt == 0);
            MessageBox.Show(patientDB.Patients.Count.ToString());
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сохраняем данные в файл посредством сериализации, механизм позволяющий превратить данные в плоский поток байтов для сохранения
            // используется механизм двоичной сериализации , который занимает меньше памяти и быстро сохраняет
            using (FileStream writer = File.OpenWrite($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"))
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writer, patientDB.Patients);
                    MessageBox.Show("DB Cashed");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }
        }

        private void readFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Достаем и с файла граф объектов и помещаем его в список + заполняем таблицу
            using (FileStream text = File.OpenRead($@"C:\Users\{SystemInformation.UserName}\Desktop\info.txt"))
            {
                try
                {
                    int count = 0;
                    IFormatter formatter = new BinaryFormatter();
                    var list = (List<Patient>)formatter.Deserialize(text);
                    patientDB.Patients = list;
                    MessageBox.Show($"Information has been added {list.Count}");
                    foreach (var item in list)
                    {
                        count++;
                        registrationPatientGridView.Rows.Add(count, item.Name, item.LastName, item.MiddleName, item.AccountNumber, item.TypeOfWork, item.Cost, item.PaymentStamp, item.Debt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    text.Close();
                }
            }
        }
    }
}