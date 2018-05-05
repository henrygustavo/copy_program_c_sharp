using System;

namespace CopyProgramSolution
{
    public class ScannerInputProcess : IActionInputProcess
    {
        public string Read()
        {
            Console.WriteLine("Scanner - Enter String:");
            return Console.ReadLine();
        }
    }
}
