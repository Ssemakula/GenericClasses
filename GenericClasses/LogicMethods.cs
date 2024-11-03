namespace GenericClasses
{
    public static class LogicMethods
    {
        /* Doing C type ifs on numbers
                * Will create a public class
                */
        public static bool IsTrue(byte a)
        {
            return a != 0;
        }

        public static bool IsTrue(sbyte a)
        {
            return a != 0;
        }

        public static bool IsTrue(char a)
        {
            return a != 0;
        }

        public static bool IsTrue(short a)
        {
            return a != 0;
        }

        public static bool IsTrue(ushort a)
        {
            return a != 0;
        }


        public static bool IsTrue(int a)
        {
            return a != 0;
        }

        public static bool IsTrue(uint a)
        {
            return a != 0;
        }

        public static bool IsTrue(nint a)
        {
            return a != 0;
        }

        public static bool IsTrue(nuint a)
        {
            return a != 0;
        }

        public static bool IsTrue(long a)
        {
            return a != 0;
        }

        public static bool IsTrue(ulong a)
        {
            return a != 0;
        }

        public static bool IsTrue(float a)
        {
            return a != 0;
        }

        public static bool IsTrue(decimal a)
        {
            return a != 0;
        }

        public static bool IsTrue(double a)
        {
            return a != 0;
        }

        public static bool IsTrue(bool a)
        {
            return a;
        }

        public static bool IsTrue(string a)
        {
            return !String.IsNullOrEmpty(a);
        }
    }
}
