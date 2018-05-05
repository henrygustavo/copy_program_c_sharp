using System;

namespace CopyProgramSolution
{
   public class KeyBoardProcess : IActionInputProcess
    {
        public string Read()
        {
            Console.WriteLine("Keyboard - Enter String:");
            return Console.ReadLine();
        }
    }
}
