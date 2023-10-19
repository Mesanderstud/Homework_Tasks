abstract class Doctor
{
    public abstract void TreatPatient(Patient patient);
}

class Surgeon : Doctor
{
    public override void TreatPatient(Patient patient)
    {
        Console.WriteLine("Хирург лечит пациента " + patient.Name);
    }
}

class Therapist : Doctor
{
    public override void TreatPatient(Patient patient)
    {
        Console.WriteLine("Терапевт лечит пациента " + patient.Name);
    }
}

class Dentist : Doctor
{
    public override void TreatPatient(Patient patient)
    {
        Console.WriteLine("Дантист лечит пациента " + patient.Name);
    }
}

class Patient
{
    public string Name { get; set; }
    public TreatmentPlan Plan { get; set; }
}

class TreatmentPlan
{
    public int TreatCode { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Doctor surgeon = new Surgeon();
        Doctor therapist = new Therapist();
        Doctor dentist = new Dentist();

        Patient patient = new Patient()
        {
            Name = "Ноунейм",
            Plan = new TreatmentPlan() { TreatCode = 1 }
        };

        Console.WriteLine("Выберите у какого доктора вы хотите лечиться? (1 - Хирург, 2 - Терапевт, 3 - Дантист)");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            surgeon.TreatPatient(patient);
        }
        else if (choice == 2)
        {
            therapist.TreatPatient(patient);
        }
        else if (choice == 3)
        {
            dentist.TreatPatient(patient);
        }
        else
        {
            Console.WriteLine("Неверный номер доктора у которого хотите лечится.");
        }
    }
}
