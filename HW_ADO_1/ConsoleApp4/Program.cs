using System;
using System.Data.OleDb;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            OleDbConnection connection = new OleDbConnection();
            try
            {
                connection.ConnectionString =
                @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\..\med.mdb";
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM PATIENTS", connection);
                OleDbDataReader reader = command.ExecuteReader();

                #region task_1
                Console.WriteLine("Пациенты:");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-4} {1,-10} {2,-10} {3:dd-MM-yyyy}",
                    reader["patientID"], reader["patientName"], reader["patientFirstName"], reader["patientBirthDate"]);
                }
                Console.WriteLine();
                #endregion

                #region task_2
                Console.WriteLine("Врачи:");
                command = new OleDbCommand("SELECT * FROM DOCTORS", connection);
                reader = command.ExecuteReader();
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-4} {1,-10} {2,-10} {3,-10}",
                    reader["doctorID"], reader["doctorName"], reader["doctorFirstName"], reader["doctorProfession"]);
                }
                Console.WriteLine();
                #endregion

                #region task_3
                command = new OleDbCommand("SELECT patientName, patientID FROM PATIENTS", connection);
                reader = command.ExecuteReader();
                while (reader.Read() != false)
                {
                    string query = String.Format("SELECT DOCTORS.doctorName FROM " +
                                                 "(DOCTORS INNER JOIN  VISITS ON VISITS.visitDoctor = DOCTORS.doctorID) " +
                                                "WHERE VISITS.visitPatient = {0}", reader["patientID"]);
                    bool IsDoctors = true;
                    OleDbCommand subCommand = new OleDbCommand(query, connection);
                    OleDbDataReader subReader = subCommand.ExecuteReader();
                    Console.WriteLine("Лечащие врачи пациента {0}:", reader["patientName"]);
                    while (subReader.Read() != false)
                    {
                        IsDoctors = false;
                        Console.WriteLine("{0,-10}", subReader["doctorName"]);
                    }
                    if (IsDoctors)
                    {
                        Console.WriteLine("У пациента нет лечащих врачей");
                    }
                }
                Console.WriteLine();
                #endregion

                #region task_4
                string query1 = String.Format("select PATIENTS.patientName, tab2.doctorName,  tab2.VisitCostValue from " +
                                                "(select tab1.VisitCostValue, DOCTORS.doctorName, tab1.VisitPatient from " +
                                                "(select VisitCosts.VisitCostValue, Visits.visitDoctor, Visits.VisitPatient from " +
                                                "VisitCosts inner join Visits on " +
                                                "VisitCosts.visitCostID = Visits.visitID) as tab1 " +
                                                "inner join DOCTORS on tab1.visitDoctor = DOCTORS.doctorID) as tab2 " +
                                                "inner join PATIENTS on PATIENTS.patientID = tab2.VisitPatient");
                command = new OleDbCommand(query1, connection);
                reader = command.ExecuteReader();
                Console.WriteLine("{0,-10} {1,-10} {2,-10} ",
                    "Пациент", "Врач", "Стоимость");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-10} ",
                    reader[0], reader[1], reader[2]);
                }
                Console.WriteLine();
                #endregion

                #region task_5
                query1 = String.Format("SELECT Doctors.doctorName, Visits.visitComment, Visits.visitDate " +
                                       "FROM ((Doctors INNER JOIN Visits ON Doctors.doctorID = Visits.visitDoctor) "+
                                       "INNER JOIN VisitCosts ON Visits.visitID = VisitCosts.visitCostID)");
                command = new OleDbCommand(query1, connection);
                reader = command.ExecuteReader();
                Console.WriteLine("{0,-15} {1,-30} {2,-10} ",
                    "Врач", "Назначение", "Дата");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-10} {1,-30} {2,-10} ",
                    reader[0], reader[1], reader[2]);
                }
                Console.WriteLine();
                #endregion

                #region task_6
                query1 = String.Format("SELECT Patients.patientName, Doctors.doctorName, VisitCosts.visitCostValue " +
                                        "FROM(((Doctors INNER JOIN Visits ON Doctors.doctorID = Visits.visitDoctor) "+
                                        "INNER JOIN Patients ON Visits.visitPatient = Patients.patientID) INNER JOIN "+
                                        "VisitCosts ON Visits.visitID = VisitCosts.visitCostID) " +
                                        "WHERE(VisitCosts.visitCostValue = (SELECT MAX(VisitCosts_1.visitCostValue) "+
                                        "AS Expr1 FROM(VisitCosts VisitCosts_1 INNER JOIN Visits Visits_1 " + 
                                        "ON VisitCosts_1.visitCostID = Visits_1.visitID)))");
                command = new OleDbCommand(query1, connection);
                reader = command.ExecuteReader();
                Console.WriteLine("Самый дорогой визит:");
                Console.WriteLine("{0,-10} {1,-10} {2,-10} ",
                    "Пациент", "Врач", "Стоимость");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-10} ",
                    reader[0], reader[1], reader[2]);
                }
                Console.WriteLine();
                #endregion

                #region task_7
                query1 = String.Format("SELECT Doctors.doctorName, COUNT(Visits.visitPatient) "+
                                        "AS CountPatients FROM (Doctors INNER JOIN Visits ON " +
                                        "Doctors.doctorID = Visits.visitDoctor) GROUP BY Doctors.doctorName");
                command = new OleDbCommand(query1, connection);
                reader = command.ExecuteReader();
                
                Console.WriteLine("{0,-10} {1,-10} ",
                    "Врач", "Количество пациентов");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-10} {1,-10}",
                    reader[0], reader[1] );
                }
                Console.WriteLine();
                #endregion

                #region task_8
                query1 = String.Format("SELECT Doctors.doctorName, SUM(VisitCosts.visitCostValue) " +
                                        "AS SummCost FROM ((Doctors INNER JOIN Visits ON "+
                                        "Doctors.doctorID = Visits.visitDoctor) INNER JOIN "+
                                        "VisitCosts ON Visits.visitID = VisitCosts.visitCostID) "+
                                        "GROUP BY Doctors.doctorName");
                command = new OleDbCommand(query1, connection);
                reader = command.ExecuteReader();

                Console.WriteLine("{0,-10} {1,-10} ",
                    "Врач", "Суммарная стоимость визитов");
                while (reader.Read() != false)
                {
                    Console.WriteLine("{0,-10} {1,-10}",
                    reader[0], reader[1]);
                }
                Console.WriteLine();
                #endregion
                Console.ReadKey();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally
            { connection.Close(); }
        }
    }
}
