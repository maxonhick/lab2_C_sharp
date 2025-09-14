// Creating a class ClassRoom
public class ClassRoom
{
    // Class variable
    private Pupil[] _pupils;

    // Defining the creator of the class
    public ClassRoom(params Pupil[] pupils)
    {
        // Checking the number of students
        if (pupils.Length >= 2 && pupils.Length <= 4)
        {
            _pupils = pupils;
        }
        else
        {
            // Throw an exception if the number of students is incorrect
            throw new ArgumentException("Колчисетво учеников должно быть от 2 до 4 включительно");
        }
    }

    // We show how each student learns
    public void HowPupilStudy()
    {
        Console.WriteLine("Как ученики учатся:");
        foreach (var pupil in _pupils)
        {
            pupil.Study();
        }
    }

    // We display how each student reads
    public void HowPupilRead()
    {
        Console.WriteLine("Как ученики читают:");
        foreach (var pupil in _pupils)
        {
            pupil.Read();
        }
    }

    // We display how each student writes
    public void HowPupilWrite()
    {
        Console.WriteLine("Как ученики пишут:");
        foreach (var pupil in _pupils)
        {
            pupil.Write();
        }
    }

    // We show how each student is relaxing
    public void HowPupilRelax()
    {
        Console.WriteLine("Как ученики отдыхают:");
        foreach (var pupil in _pupils)
        {
            pupil.Relax();
        }
    }

}

// Defining the student's base class
public class Pupil
{
    public virtual void Study() { }

    public virtual void Read() { }

    public virtual void Write() { }

    public virtual void Relax() { }
}

// We determine the class of an excellent student
public class ExcelentPupil: Pupil
{

    // Redefining the methods of the base class
    public override void Study()
    {
        Console.WriteLine("Отличное обучение");
    }

    public override void Read()
    {
        Console.WriteLine("Быстро читает");
    }

    public override void Write()
    {
        Console.WriteLine("Прекрасный почерк");
    }

    public override void Relax()
    {
        Console.WriteLine("Почти не отдыхает");
    }
}

// We determine the class of a good student
public class GoodPupil: Pupil
{
    // Redefining the methods of the base class
    public override void Study()
    {
        Console.WriteLine("Хорошее обучение");
    }

    public override void Read()
    {
        Console.WriteLine("Нормально читает");
    }

    public override void Write()
    {
        Console.WriteLine("Разборчиывй почерк");
    }

    public override void Relax()
    {
        Console.WriteLine("Отдыхает, но не очень много");
    }
}

// We determine the class of a bad student
public class BadPupil: Pupil
{
    // Redefining the methods of the base class
    public override void Study()
    {
        Console.WriteLine("Ужасное обучение");
    }

    public override void Read()
    {
        Console.WriteLine("Медленно читает");
    }

    public override void Write()
    {
        Console.WriteLine("Почерк как курица лапой");
    }

    public override void Relax()
    {
        Console.WriteLine("Слишком много отдыхает");
    }
}

class task1
{
    static void Main()
    {
        // We create representatives of all types of students
        Pupil good_pupil = new GoodPupil();
        Pupil excelent_pupil = new ExcelentPupil();
        Pupil bad_pupil = new BadPupil();

        try
        {
            // We create a class and display the data of its students
            ClassRoom classroom = new ClassRoom(excelent_pupil, good_pupil, bad_pupil);
            classroom.HowPupilStudy();
            classroom.HowPupilRead();
            classroom.HowPupilWrite();
            classroom.HowPupilRelax();
        } 
        catch (Exception e)
        {
            // Error handling
            Console.WriteLine($"Возникла ошибка: {e.Message}");
        }
    }
}