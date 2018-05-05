namespace CopyProgramSolution
{
    public class FileSystemRepository: IRepository
    {
        public void Save(string value)
        {
            System.IO.File.WriteAllText(@"C:\temp\bd.txt", value);
        }
    }
}
