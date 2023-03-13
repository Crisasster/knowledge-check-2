using DogBreeds;
Console.WriteLine("How many Breeds do you want to add?");
var numberOfBreeds = int.Parse(Console.ReadLine());

var Breed = new List<Dog>();
for (int i = 0; i < numberOfBreeds; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myDog = new Dog();

    Console.WriteLine("Which breed would you like to add");
    myDog.numberOfBreeds = Convert.ToInt32(Console.ReadLine());


    Breed.Add(myDog);

    Console.WriteLine("Number of Breeds: " + myDog.numberOfBreeds);
}

// Print out the list of breeds using Console.WriteLine()
string Breeds;
{
    Console.WriteLine("Bark Bark !!");
    Console.WriteLine("Husky");
    Console.WriteLine("Samouyed");
    Console.WriteLine("Greyhound");
    Console.WriteLine("Borzoi");

}