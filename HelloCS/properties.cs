using System;
internal class Person
{
    private byte  age;
    private int grade;
    public string names;
    public string address;
    DateTime dob;

    // getter setter 

    public byte Age
    {
        get { return age; }
        
        set
        { 
            if (value >30 && value < 40)
            {
                age = value;
            }
        }  
    }
    // Auto_implemented properties

    public string Address{ get; set; }  

    //Read only
    public int Names { get;  }
 
    
    
}