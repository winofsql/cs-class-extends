# cs-class-extends

```cs
namespace form_01
{
    internal class NextClass : MyClass
    {
        public NextClass()
        {
            // MyClass() が呼ばれる
        }
        public NextClass(string Name)
        {
            // MyClass() が呼ばれる
        }
    }
}
```

```cs
namespace form_01
{
    internal class NextClass : MyClass
    {
        public NextClass()
        {
        }
        public NextClass(string Name) : base(Name)
        {
            // MyClass(string Name) が呼ばれる
        }
    }
}
```
