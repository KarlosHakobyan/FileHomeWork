internal partial class Program
{
    public class Student : Person ,IUniversity
    {   
        public int Group;
        public string UniName { get; set; }
        public Student(string name , int age , int group, string uniName) : base(name,age)
        {
            UniName = uniName;
            SetGroup(group);
        }

        public void SetGroup(int group)
        {
            Group = group;   
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Group: {Group}, University: {UniName}";
        }

    }
}