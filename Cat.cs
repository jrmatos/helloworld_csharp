namespace HelloWorld
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) {}

        public void action()
        {
            Console.WriteLine("cat playing");
        }
    }
}
