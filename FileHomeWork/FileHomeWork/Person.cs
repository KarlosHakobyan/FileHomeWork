﻿internal partial class Program
{
    public class Person
    {
        public Person(string name,int age)
        {
            
        }
        private string _name;
        private string _surname;
        private int _age;
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}