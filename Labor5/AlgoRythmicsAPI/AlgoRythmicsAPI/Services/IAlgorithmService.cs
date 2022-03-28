using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public interface IAlgorithmService {
    public void AddAlgorithm(AlgorithmViewModel viewModel);
    public Task<Algorithm> GetSpecificAlgorithm(int id);

    public Task<ActionResult<IEnumerable<Algorithm>>> GetAllAlgorithms();

    public Task<Algorithm> UpdateAlgorithm(int id, AlgorithmViewModel viewModel);

    public Task<Algorithm> DeleteAlgorithm(int id);
}

