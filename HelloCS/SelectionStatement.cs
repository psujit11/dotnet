class SelectionStatement
{
    static void Main2()
    {
        SelectionStatement ss= new SelectionStatement();
        ss.LearnIfElse();
    }
    void LearnIfElse()
    {   Console.WriteLine("Entrer any number"); 
        string input =Console.ReadLine();
        byte x=byte.Parse(input);
        if (x== 34)
        {
            Console.WriteLine(" You enter 34");
        }
        else if (x== 20)
        {
            Console.WriteLine("you enter 20");
        }
        else
        {
            Console.WriteLine("You diidnt enter the correct password");
        }
    }
     void LearnSwitch()
    {
       char option='y';
       switch (option)  
       {
        case 'n':
        Console.WriteLine("You opted for NO.");
        break;
        case 't':
        case 'o': //you can even group cases
        Console.WriteLine("You opted for Yes.");
        break;
        case 'y':
        Console.WriteLine("You opted for Y.");
        break;
        default:
        break;
       }
    }

}
   