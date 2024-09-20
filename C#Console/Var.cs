
class Var
{
    public static void MyVar()
    {
        string myName = "Jakobe"; 

        Console.WriteLine(myName);
    }

    public static void Datatypes()
    {
        string firstName = "Jakobe";
        string lastName = "Mccowan";
        firstName = "Sam";
        string wholeName = firstName + " " + lastName;
        int age = 15;
        double height = 6.2;
        float gpa = 3.0f;
        decimal dollar = 100.95m;
        bool is_Student = true;
        char grade = 'A';

        Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholeName);
        Console.WriteLine(age);
        Console.WriteLine(height);
        Console.WriteLine(gpa);
        Console.WriteLine(dollar);
        Console.WriteLine(is_Student);
        Console.WriteLine(grade);
    }
}