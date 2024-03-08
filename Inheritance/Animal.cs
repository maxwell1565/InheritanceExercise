using System;
namespace Inheritance
{
	public class Animal
	{
		public Animal()
		{
		}
        // Create a class Animal - done
        // give this class 4 members that all Animals have in common - done

			public bool HasFur { get; set; }
			public bool IsNocturnal { get; set; }
			public int HowManyLegs { get; set; }
			public bool IsHerbivore { get; set; }

		public Animal(bool hasFur, bool isNocturnal, int howManyLegs, bool isHerbivore)
		{
			HasFur = hasFur;
			IsNocturnal = isNocturnal;
			HowManyLegs = howManyLegs;
			IsHerbivore = isHerbivore;
		}

		public void AnimalProperties()
		{
			Console.WriteLine($"Does this animal have fur? {HasFur}. Are they nocturnal? {IsNocturnal}. They have {HowManyLegs} legs. Are they a herbivore? {IsHerbivore}!");
		}
		
	}
}

