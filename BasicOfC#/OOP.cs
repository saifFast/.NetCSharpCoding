using System;

namespace BasicOfC_
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public abstract void PrintEmail();

    }

    public class Doctor : Person
    {
        public Doctor()
        {
            PrintName();
        }
        public override void PrintEmail()
        {
            Console.WriteLine(EmailAddress);
        }
    }

    public abstract class Human : Person
    {
        public abstract void PrintHuman();

        protected abstract void MakeHuman();
    }

    public class ImplementedMan : Human
    {
        public override void PrintEmail()
        {

        }

        public override void PrintHuman()
        {

        }

        protected override void MakeHuman()
        {

        }
    }
}