
namespace Homework
{
    class Programm
    {
        static void Main()
        {
            byte a = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", "Type", "Size", "Example", "Minimal value", "Maximum value");
            Console.WriteLine("|{0}|{0}|{0}|{0}|{0}|", "----------");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (byte), sizeof (byte), a, byte.MaxValue, byte.MinValue);
            sbyte b = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (sbyte), sizeof (sbyte), b, sbyte.MaxValue, sbyte.MinValue);
            short c = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (short), sizeof (short), c, short.MaxValue, short.MinValue);
            ushort d = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (ushort), sizeof (ushort), d, ushort.MaxValue, ushort.MinValue);
            int e = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (int), sizeof (int), e, int.MaxValue, int.MinValue);
            uint f = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (uint), sizeof (uint), f, uint.MaxValue, uint.MinValue);
            long g = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (long), sizeof (long), g, long.MaxValue, long.MinValue);
            ulong h = 12;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (ulong), sizeof (ulong), h, ulong.MaxValue, ulong.MinValue);
        }
    }
}
