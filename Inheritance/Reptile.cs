using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

        // Create a class Reptile - done
        // give this class 4 members that are specific to Reptile - done
        // Set this class to inherit from your Animal Class - done

        public bool IsColdBlooded { get; set; }
        public string Color { get; set; }
        public bool IsAmphibious { get; set; }
        public bool HasTail { get; set; }

        public Reptile(bool isColdBlooded, string color, bool isAmphibious, bool hasTail)
        {
            IsColdBlooded = isColdBlooded;
            Color = color;
            IsAmphibious = isAmphibious;
            HasTail = hasTail;
        }

        public void ReptileInfo()
        {
            Console.WriteLine($"Is cold-blooded: {IsColdBlooded}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Is amphibious: {IsAmphibious}");
            Console.WriteLine($"Has tail: {HasTail}");
        }
    }
}

