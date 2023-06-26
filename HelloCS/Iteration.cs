class Iteration
{   
    static void Main12(){
       // Iteration iteration= new Iteration();   
       //iteration.LearnForLoop();
        Iteration loop=new Iteration(); 
        loop.LearnDoWhileLoop();

    }
     public void LearnForLoop()
    {
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("hellpo there from loop");
        }  

        int [] numbers={34,5,6,78,90};
        foreach (int x in numbers)
        {
            if (x%2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else 
            {
                Console.WriteLine($"{x} is odd");
            }
        } 
    }

    void LearnWhileLoop()
    {
        char confirm='Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("I am beautiful");
            Console.WriteLine("Print one more time");
            confirm = Console.ReadKey().KeyChar;
            
        }
    }

    void LearnDoWhileLoop()
    {
        char confirm='Y';
        do
        {
            Console.WriteLine("I am ugly");
            Console.WriteLine("Print one more time");
            confirm = Console.ReadKey().KeyChar;
        }
        while(confirm == 'Y');
}
}