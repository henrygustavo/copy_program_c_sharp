using System;

namespace CopyProgramSolution
{
   public class DataBaseRepository : IRepository
    {
        public void Save(string value)
        {
            Console.WriteLine(" *Database: " + value);
        }
    }
}
