namespace HelloWorld
{
    class Animal
    {
        private string name;

        private int age { get; set; }

        public Animal(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public void info()
        {
            Console.WriteLine("Name is " + this.name);
            Console.WriteLine("Age is " + this.age);
        }
    }
}
