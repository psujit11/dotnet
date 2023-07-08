using System.Threading;
using System;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AsyncandParallel 
{
     class Program
    {
        // static void Main1()
        // {
        //   //TPL- task parallel library 
        //    int [] numbers ={23,45,12,56,78,43,54,65,32,21};
        //    Stopwatch stopwatch = new Stopwatch();
        //   // Sequential
        //   stopwatch.Start();
        //   foreach (var num in numbers){
        //     Compute(num);
        //   }
        //   Console.WriteLine($" Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");
          
        //   // parallel
        //   stopwatch.Restart();
        //   Parallel.ForEach(numbers,num => {
        //      Compute(num);
        //   });
        //   Console.WriteLine($" Time taken (parallel): {stopwatch.ElapsedMilliseconds} ms");
        // }

        // static void Compute(int x)
        // {
        //   Thread.Sleep(100);
        //   Console.WriteLine($"Computed for {x}");
        // }
    
        // static async void Main2()
        // {
        //   // Async Code
        //   Stopwatch sw =Stopwatch.StartNew();
        //   var turnBurner1 =TurnOnBurner();
        //   var putKettle = PutOn("kettle"); 
        //   var addWater = Add("water");
        //   var boilWater = Boil("Water"); 
        //   var grindMasala =GrindTeaMasala();
        //   var addSugar = Add("Sugar"); 
        //   var addMasala = Add("Masala"); 
        //   var addMilk = Add("Milk"); 
        //   var boilMilk = Boil("Milk");
        //   var turnBurner2 = TurnOnBurner();
        //   var putPan = PutOn("pan"); 
        //   var addOil = Add("oil");
        //   var crackAndStir = CrackAndStir();
        //   var fryEggs = Fry();
        //   var serve = Serve();

        //   await turnBurner1;
        //   Console.WriteLine("Burner1 turned on");
          
        //   await putKettle;
        //   Console.WriteLine("Put kettle on burner");
          
        //   await addWater;
        //   Console.WriteLine("Add water");
          
        //   await boilWater;
        //   Console.WriteLine("Boil water");
          
        //   await grindMasala;  
        //   Console.WriteLine("Grinded masala tea");
          
        //   await addSugar;
        //   Console.WriteLine("Added Sugar");
          
        //   await addMasala;
        //   Console.WriteLine("Added Masala");
          
        //   await addMilk;
        //   Console.WriteLine("Added Milk");
          
        //   await boilMilk; 
        //   Console.WriteLine("Boil milk");

        //   await turnBurner2; 
        //   Console.WriteLine("Turned on Burner2");

        //   await putPan; 
        //   Console.WriteLine("Put pan on burner2");

        //   await addOil; 
        //   Console.WriteLine("added oil");

        //   await crackAndStir;
        //   Console.WriteLine("cracked eeg and stirred it");

        //   await fryEggs; 
        //   Console.WriteLine("Fried eggs");

        //   await serve; 
        //   Console.WriteLine("Serve Fried eggs");

          
        // }

        static async Task Main()
        {
         
         // Async Code
          Stopwatch sw = Stopwatch.StartNew();
          var turnBurner1 =TurnOnBurner();
          var putKettle = PutOn("kettle"); 
          var addWater = Add("water");
          var boilWater = Boil("Water"); 
          var grindMasala =GrindTeaMasala();
          var addSugar = Add("Sugar"); 
          var addMasala = Add("Masala"); 
          var addMilk = Add("Milk"); 
          var boilMilk = Boil("Milk");
          var turnBurner2 = TurnOnBurner();
          var putPan = PutOn("pan"); 
          var addOil = Add("oil");
          var crackAndStir = CrackAndStir();
          var fryEggs = Fry();
          var serve = Serve();

          await turnBurner1;
          Console.WriteLine("Burner1 turned on");
          
          await putKettle;
          Console.WriteLine("Put kettle on burner");
          
          await addWater;
          Console.WriteLine("Add water");
          
          await boilWater;
          Console.WriteLine("Boil water");
          
          await grindMasala;  
          Console.WriteLine("Grinded masala tea");
          
          await addSugar;
          Console.WriteLine("Added Sugar");
          
          await addMasala;
          Console.WriteLine("Added Masala");
          
          await addMilk;
          Console.WriteLine("Added Milk");
          
          await boilMilk; 
          Console.WriteLine("Boil milk");

          await turnBurner2; 
          Console.WriteLine("Turned on Burner2");

          await putPan; 
          Console.WriteLine("Put pan on burner2");

          await addOil; 
          Console.WriteLine("added oil");

          await crackAndStir;
          Console.WriteLine("cracked eeg and stirred it");

          await fryEggs; 
          Console.WriteLine("Fried eggs");

          await serve; 
          Console.WriteLine("Serve Fried eggs");

          Console.WriteLine($"Time taken (Parallel): {sw.ElapsedMilliseconds} ms");
        }
        private static async Task TurnOnBurner()  
        {
           await Task.Delay(2000); 
        }

        private static  async Task PutOn(string pot) 
        {
           await Task.Delay(2000);
        }

        private static async Task Add(string item) 
        {
           await Task.Delay(2000);
        }

        private static async Task Boil(string item) 
        {
           await Task.Delay(10000);
        }

        private static async Task GrindTeaMasala() 
        {
           await Task.Delay(2000);
        }

        private static async Task CrackAndStir() 
        {
           await Task.Delay(10000);
        }

        private static async Task Fry() 
        {
           await Task.Delay(10000);
        }

        private static async  Task Serve() 
        {
           await Task.Delay(2000);
        }


    }
}
