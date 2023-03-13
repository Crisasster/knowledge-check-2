namespace DogBreeds
{
    public class Breed
    {
        public bool Samoyed { get; set; }
        public bool Huskey { get; set; }
        public bool Borzoi { get; set; }
        public bool Greyhound { get; set; }

        public Breed()
        {
            this.Samoyed = false;
            this.Huskey = false;
            this.Borzoi = false;
            this.Greyhound = false;
        }
    }

    public class Dog : Breed
    {
        public int numberOfBreeds { get; set; }
        public Dog()
        {
            this.Samoyed = false;
            this.Huskey = false;
            this.Borzoi = true;
            this.Greyhound = false;
            this.numberOfBreeds = 0;
        }
    }
}