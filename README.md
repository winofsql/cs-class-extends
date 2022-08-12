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

### 呼び出し( NextClass )
```cs
using System.Diagnostics;

namespace form_01;

public partial class Form1 : Form
{

    private NextClass nextClass;

    public Form1()
    {
        InitializeComponent();

        nextClass = new NextClass("継承元の処理の確認");
        nextClass.StartMessage("処理開始");
    }

    private void action_Click(object sender, EventArgs e)
    {

        Debug.WriteLine("DBG:こんにちは世界");

        string Name = nextClass.Name;

        NextClass.print( Name );

    }

}
```
