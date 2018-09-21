using System;

namespace TestRefStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f1;
            f1.x = 10;
            f1.bar.y = 10;

            Foo f2 = f1;
            f2.x = 20;
            f2.bar.y = 20;

            ref Foo f3 = ref f1;
            f3.x = 30;
            f3.bar.y = 30;

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());
        }
    }
    public ref struct Foo
    {
        public int x;
        public Bar bar;

        public override string ToString()
            => $"{x} and {bar.ToString()}";
    }

    public ref struct Bar
    {
        public int y;
        
        public override string ToString() => $"{y.ToString()}";
    }

}
