using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Enums;

public interface IAlgorithmRepository
{
    public void AddAlgorithm(AlgorithmViewModel viewModel);
    public Task<Algorithm> GetSpecificAlgorithm(int id);
    public Task<List<Algorithm>> GetAllAlgorithms();

    public Task<Algorithm> UpdateAlgorithm(int id,AlgorithmViewModel viewModel);
    //public void DeleteAlgorithm();

}
