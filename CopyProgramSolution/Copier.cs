namespace CopyProgramSolution
{
    public class Copier
    {
        private readonly IRepository _repository;
        private readonly IActionInputProcess _inputProcess;
        public Copier(IRepository repo, IActionInputProcess actionInputProcess)
        {
            _repository = repo;
            _inputProcess = actionInputProcess;

        }
        public void Copy()
        {
            string value;
            while ((value = _inputProcess.Read()) != "-1")
            {
                _repository.Save(value);
            }
        }
    }
}
