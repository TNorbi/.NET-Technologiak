using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class AlgorithmRepository : IAlgorithmRepository
{
    private AppDbContext _context { get; set; }

    public AlgorithmRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddAlgorithm(AlgorithmViewModel viewModel)
    {
        Algorithm algorithm = new Algorithm
        {
            Name = viewModel.Name,
            Description = viewModel.Description,
            Type = viewModel.Type,
            Icon = viewModel.Icon,
            Url = viewModel.Url,
            AlgorithmNickname = viewModel.AlgorithmNickname
        };

        _context.Algorithms.Add(algorithm);

        _context.SaveChanges();
    }



    public async Task<Algorithm> GetSpecificAlgorithm(int id)
    {
        return await _context.Algorithms.FindAsync(id);
    }

    public async Task<List<Algorithm>> GetAllAlgorithms()
    {
        Algorithm algorithm = new Algorithm();
        var result = await _context.Algorithms.ToListAsync();

        return result;
    }

    public async Task<Algorithm> UpdateAlgorithm(int id, AlgorithmViewModel viewModel)
    {
        var chosenAlgorithm = await _context.Algorithms.FindAsync(id);

        if(chosenAlgorithm != null)
        {
            chosenAlgorithm.Name = viewModel.Name;
            chosenAlgorithm.Description = viewModel.Description;
            chosenAlgorithm.Type = viewModel.Type;
            chosenAlgorithm.Icon = viewModel.Icon;
            chosenAlgorithm.Url = viewModel.Url;
            chosenAlgorithm.AlgorithmNickname = viewModel.AlgorithmNickname;

            _context.Algorithms.Update(chosenAlgorithm);

            await _context.SaveChangesAsync();

            return chosenAlgorithm;
        }

        return null;
    }

    public async Task<Algorithm> DeleteAlgorithm(int id)
    {
        var result = await _context.Algorithms.FindAsync(id);

        if(result == null)
        {
            return null;
        }

        _context.Algorithms.Remove(result);

        await _context.SaveChangesAsync();

        return result;
    }
}
