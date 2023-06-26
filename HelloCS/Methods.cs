using EnumsandMethods;
// duitai file ma same  mespace xa bhane yesari import garnu pardaina
public class MethodTeacher
{
    static void Main1234()
    {
        MethodTeacher teacher = new MethodTeacher();
        double sum = teacher.Sum(2345.56, 23451.1);
        double sum_evens = teacher.Sum(345, 367, 234, 330, 321, 123);
        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"Sum is {sum_evens}");
    }
    // function override bhako xa sum ko by arguments . return type bata mtra garna mildaina.
    double Sum(double firstNum, double secondNum)
    {
        DayWeek x;
        return firstNum + secondNum;
    }
    // Q1: return sum of even numbers from supplied 6 parameters
    // public int SumOfEvens(params int[] nums)
    // {
    //     int sum = 0;
    //     foreach (int num in nums)
    //     {
    //         if(num % 2 == 0)
    //             sum = sum + num;
    //     }
    //     return sum; 

    // }

    // variable-number of arguments

    double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double item in numbers)
        {
            sum = sum + item;
        }
        return sum;
    }

    // return multiple variable -Using tuples
    // eg: Method to find min and amx from set of a numbers

    public (int, int) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;

        }

        return (min, max);
    }

    //Named-argument (main use tala call garda dekhinxa)

    internal void PrintCustomerDetials(string name, byte age, string address)
    {
        Console.WriteLine($"Name :{name}[{age}], Address : {address}");
    }
    //Generic method
    public void Sum<T>(T firstnum, T secondNum)
    {

    }
}

public class MethodTester
{
    static void Main12345()

    {
        int[] bumpers = new int[] { 20, 30, 1, 99, 67 };
        MethodTeacher methodTester = new MethodTeacher();

        (int Min, int Max) result = methodTester.FindMinMax(bumpers);

        Console.WriteLine($"Minimun :{result.Min}, Maximum : {result.Max}");
        //Named argument
        methodTester.PrintCustomerDetials(age: 32, address: "Naikap", name: "Bishnu");

        methodTester.Sum<float>(345.34f, 4342.34f);

    }


}