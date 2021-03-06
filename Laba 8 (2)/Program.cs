using System;
using System.IO;

namespace _2
{
    class Program
    {
        static int count = 0;
        public int[] text;
        public string[] st;
        public string b;

        static void Main(string[] args)
        {
            Program a = new Program();
            string s = "D://f.txt";

            if (!File.Exists(s))
                File.Create(s);
            using (StreamWriter n = new StreamWriter(s))
            {

                for (int i = 0; i < 20; i++)
                {
                    n.Write(i + " ");
                }

            }
            using (FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader r = new StreamReader(fs))
                {
                    a.b = r.ReadToEnd();
                }
            }

            a.st = a.b.Split(' ');
            a.text = new int[a.st.Length - 1];

            for (int i = 0; i < a.st.Length; i++)
            {
                try
                {
                    a.text[i] = Int32.Parse(a.st[i]);
                }
                catch { }
            }

            for (int i = 0; i < a.text.Length; i++)
            {
                if (a.text[i] % 2 == 0)
                    count++;
                if (i == (a.text.Length - 1))
                    Console.WriteLine("Парних: " + count);
            }
            count = 0;
            for (int i = 0; i < a.text.Length; i++)
            {
                if (a.text[i] % 2 == 0 && a.text[i] % 4 == 0)
                    count++;
                if (i == (a.text.Length - 1))
                    Console.WriteLine("Подвiйних парних: " + count);
            }
            count = 0;
            for (int i = 0; i < a.text.Length; i++)
            {
                if (a.text[i] % 2 != 0 && Math.Sqrt(a.text[i]) * Math.Sqrt(a.text[i]) == a.text[i])
                    count++;
                if (i == (a.text.Length - 1))
                    Console.WriteLine("Квадратiв непарних: " + count);
            }
        }
    }
}
