using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowXTargetSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13; i++)
            {
                Directory.CreateDirectory($"..\\..\\..\\Project{i:00}\\Code");

                for (int j = 0; j < 200; j++)
                {
                    var text = $"namespace Project{i}{{ class __{j:000} {{ }} }}";

                    File.WriteAllText($"..\\..\\..\\Project{i:00}\\Code\\File{j:000}.cs", text);
                }
            }

            for (int i = 1; i < 25; i++)
            {
                Directory.CreateDirectory($"..\\..\\..\\VeryLargeProject\\Code{i:00}");

                for (int j = 0; j < 200; j++)
                {
                    var text = $"namespace Project{i}{{ class __{j:000} {{ }} }}";

                    File.WriteAllText($"..\\..\\..\\VeryLargeProject\\Code{i:00}\\File{j:000}.cs", text);
                }
            }

        }
    }
}
