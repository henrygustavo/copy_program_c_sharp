namespace CopyProgramSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Copier copier = new Copier(new DataBaseRepository(), new KeyBoardProcess());

            copier.Copy();

        }
    }
}
