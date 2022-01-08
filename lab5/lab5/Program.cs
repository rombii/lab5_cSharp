// See https://aka.ms/new-console-template for more information

using lab5;

//stringLength(null);

//showException();

int stringLength(string word)
{
    try
    {
        return word.Length;
    }
    catch (NullReferenceException e)
    {
        Console.WriteLine(e.StackTrace);
        throw new Exception(e.ToString());
    }
}

void showException()
{
    Random RandomNumber = new Random();
    int rand = RandomNumber.Next(1, 4);
    switch (rand)
    {
        case 1:
        {
            try
            {
                throw new Exception1();
            }
            catch (Exception1 e)
            {
                Console.WriteLine("Wyjatek 1");
            }
            break;
            
        }
        case 2:
        {
            try
            {
                throw new Exception2();
            }
            catch (Exception2 e)
            {
                Console.WriteLine("Wyjatek 2");
            }
            break;
        }
        case 3:
        {
            try
            {
                throw new Exception3();
            }
            catch (Exception3 e)
            {
                Console.WriteLine("Wyjatek 3");
            }
            break;
        }
    }
}

void checkException()
{
    try
    {
        throw new Exception1("old");
    }
    catch (Exception1 e)
    {
        int rand = new Random().Next(1, 4);
        if(rand == 1)
            throw new Exception1("new");
        else
            throw new Exception();
    } catch(Exception ex){}
}

// SomeClass someClass = new SomeClass();
// int i = 1;
// try
// {
//     someClass.CanThrowException();
//     i++;
//     someClass.CanThrowException();
//     i++;
//     someClass.CanThrowException();
//     i++;
//     someClass.CanThrowException();
//     i++;
//     someClass.CanThrowException();
//     i++;
//     Console.WriteLine("wyjatek nie wystapil");
// }
// catch (Exception e)
// {
//     Console.WriteLine("Wystapilo na: "+i);
// }

Person person1 = new Person();
person1.name = "jan";
person1.surname = "kowalski";
person1.age = 45;

Person person2 = new Person();

copyObject(person1,person2);


Console.WriteLine(person2.name);

Person person3 = person1.cloneObject();

void copyObject(Person person1, Person person2)
{
    try
    {
        person2.name = person1.name;
        person2.surname = person1.surname;
        person2.age = person1.age;
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}

public class SomeClass
{
    public void CanThrowException()
    {
        if (new Random().Next(5) == 0)
            throw new Exception();
    }
}

public class Person : ICloneable
{
    public string name;
    public string surname;
    public int age;


    public Person cloneObject()
    {
        try
        {
            return (Person) this.MemberwiseClone();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public object Clone()
    {
        throw new NotImplementedException();
    }
}