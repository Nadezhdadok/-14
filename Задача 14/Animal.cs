using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    abstract internal class Animal
    {
        public abstract string Name { get; set; }
        public Animal (string name)
        {
            this.Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        private string say;
        private string name;
        public override string Name 
        { 
            get => name; 
            set => name=value; 
        }
        public Cat(string name, string say)
            :base(name)
        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        private string say;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
