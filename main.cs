using System;

class MainClass {
  public static void Main (string[] args) {

 Console.WriteLine ("How many people need help?");
 int i = Convert.ToInt32(Console.ReadLine());

 for (i = 0; i <= 10; i++)
  {
    Console.WriteLine ("Please enter name.");
    string name = Console.ReadLine();

    Console.WriteLine("Please enter height in inches");
    double ht = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please enter weight in pounds");
    double wt = Convert.ToDouble(Console.ReadLine());

    double BMI = (703*wt)/(ht*ht);

    Console.WriteLine (name +"'s BMI is " + BMI);

      if (0<= BMI && BMI <=18.5)
        {
          Console.WriteLine("UnderWeight");
        }
        else if (18.5 > BMI && BMI < 24.9)
        {
          Console.WriteLine("Normal Weight");
        }
        else if ( 25 > BMI && BMI < 29.9)
        {
          Console.WriteLine("OverWeight");
        }
        else 
        {
          Console.WriteLine("Obese");
        }
    }    
  }
}