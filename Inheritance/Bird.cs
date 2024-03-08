using System;
using System.Drawing;

namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

        // Create a class Bird - done
        // give this class 4 members that are specific to Bird - done
        // Set this class to inherit from your Animal Class - done

        public bool CanFly { get; set; }
        public string WinterMigration { get; set; }
        public string TweetNoise { get; set; }
        public bool LikesSeeds { get; set; }

        public void BirdInfo()
        {
            Console.WriteLine($"Can they fly? {CanFly}. They go {WinterMigration} when it gets cold. They make a {TweetNoise} noise. its is {LikesSeeds} theat they like seeds.");
           
        }
    }

}

