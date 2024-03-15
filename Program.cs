namespace GenericAnimalClass
{
    public class Animal<T>
    {
        public T data;

        public Animal(T data)
        {
            this.data = data;
        }

        public T getAnimal()
        {
            return data;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Rabbit");
            Animal<string> animalHabitat = new Animal<string>("Rabbit habitats include meadows, woods, forests, grasslands, deserts and wetlands.");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(10);

            Console.WriteLine($"Animal Information: {animalName.getAnimal()}\n" +
                $"Habitat: {animalHabitat.getAnimal()}\nLifespan: {averageLifespan.getAnimal()} years\n" +
                $"Endangered? {endangered.getAnimal()}\nExtinct? {extinct.getAnimal()}");
        }
    }
}
