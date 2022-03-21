using System.Runtime.InteropServices;

public class AlgorithmService : IAlgorithmService
{
    private readonly IAlgorithmRepository _repo;

    public AlgorithmService(IAlgorithmRepository repo)
    {
        _repo = repo;
    }

    public void AddAlgorithm(AlgorithmViewModel viewModel)
    {
        _repo.AddAlgorithm(viewModel);
    }
}