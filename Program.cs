namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("dog", 12);
            animal1.info();

            Cat cat1 = new Cat("cat one", 2);
            cat1.info();
            cat1.action();
        }
    }
}
