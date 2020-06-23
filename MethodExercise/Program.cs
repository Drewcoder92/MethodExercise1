using System;


namespace MethodExercise



// EXAMPLE:
// var name = Console.ReadLine();

//  Record user input, for each of these.Combine all answers for a fun, short story.
// Hint:
//FW




// Name: Michael
//Favorite Color: Blue
//Favorite Animal: Walrus
// Favorite Band: The Beatles
// Extra points - turn the answers into a fun short story!

{ class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("---------------------------------");




            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
        }

    }

}


