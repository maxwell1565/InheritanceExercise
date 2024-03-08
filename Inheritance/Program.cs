using System;
using Inheritance;


// TODO Be sure to follow best practice when creating your classes

/*Create an object of your Bird class
 *  give values to your members using the object of your Bird class
 *  
 * Creatively display the class member values 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        var eagle = new Bird()
        {
            //animal properties
            HasFur = false,
            IsNocturnal = false,
            HowManyLegs = 2,
            IsHerbivore = false,
        };

        //bird properties
        eagle.CanFly = true;
        eagle.WinterMigration = "goes south";
        eagle.TweetNoise = "peal call";
        eagle.LikesSeeds = false;

        var alligtor = new Reptile()
        {
            HasFur = false,
            IsNocturnal = true,
            HowManyLegs = 4,
            IsHerbivore = false,
            IsColdBlooded = true,
            Color = "dark green",
            IsAmphibious = true,
            HasTail = true,
        };

        //Print info to console
        Console.WriteLine("Info about eagles.");
        eagle.AnimalProperties();
        eagle.BirdInfo();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Info about alligators.");
        alligtor.AnimalProperties();
        alligtor.ReptileInfo();

    }
}