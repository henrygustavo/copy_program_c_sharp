using System;

namespace CopyProgram1
{
    class Keyboard : IInput
    {
        public string Read()
        {
            Console.WriteLine("Keyboard - Enter String:");
            return Console.ReadLine();
	    }
    }
}
