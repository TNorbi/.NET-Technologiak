using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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

    public async Task<Algorithm> DeleteAlgorithm(int id)
    {
        var result = await _repo.DeleteAlgorithm(id);

        if(result == null)
        {
            return null;
        }

        return result;
    }

    public async Task<List<Algorithm>> GetAllAlgorithms()
    {
        return await _repo.GetAllAlgorithms();
    }

    public async Task<Algorithm> GetSpecificAlgorithm(int id)
    {
        return await _repo.GetSpecificAlgorithm(id);
    }

    public async Task<Algorithm> UpdateAlgorithm(int id, AlgorithmViewModel viewModel)
    {
        var result = await _repo.UpdateAlgorithm(id, viewModel);

        if(result == null)
        {
            return null; 
        }

        return result;
    }
}