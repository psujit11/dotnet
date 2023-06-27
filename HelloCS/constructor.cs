namespace AllAboutClasses
{
    public class Country

    {
        public string Name { get; set;}   
        public string CountryCode { get; set;}
        public int Population { get; set;}  
        public static readonly bool IsOnEarth;

        public const  double AREA = 1414.45;
        // readonly can be initialized inside constructor only. it is also constant that can change value at runtime. public readonly double AREA=1231

        //Instance  cosntructors
        // default constructor: Constructor with no parameteres at all.This is same as writing it or not.
        // yedi katai  without paramters call garya xa bhaen default construtor pani lekhnai parxa.
        public Country()
        {
 
        }

        // Parametarized Constructor

        public Country(string name)
        {
            Name = name;
        }
        // for read-only contant parameter ma double area ahni tala same way ma assign garney.
        public Country (string name, string countryCode, int population ) 
        {
            Name = name;
            CountryCode = countryCode;
            Population = population;
              
        }  
        static Country()
        {
            IsOnEarth = true;
        }
    public class Demo{
         void DoSomething()
         {  
            Country country1= new Country(); 
            Country country2= new Country("Nepal");
            // static member can be directkly access from class onll cant be accessed from insatnce. 
         }
    }
}