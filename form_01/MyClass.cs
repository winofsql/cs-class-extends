using System.Diagnostics;
namespace form_01
{
    internal class MyClass
    {
        public MyClass()
        {
            this.Name = "MyClass";
        }
        public MyClass(string Name)
        {
            this.Name = Name;
        }

        public string? Title { get; set; }

        private string? myName;
        public string? Name
        {
            get { return myName; }
            set { myName = value; }
        }

        internal void StartMessage(string v)
        {
            //throw new NotImplementedException();
            Debug.WriteLine($"DBG:{v}");
        }

        internal static void print(string v)
        {
            //throw new NotImplementedException();
            Debug.WriteLine($"DBG:{v}");
        }
    }
}