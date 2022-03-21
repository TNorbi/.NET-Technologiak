using System;
using System.Runtime.InteropServices;

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

    /*public void AddAlgorithm(int id, string name, string description, Enums.AlgorithmType type, string icon, string url, string algorithmNickname, bool? IsPublished, DateTime creationDate)
    {
        Algorithm algorithm = new Algorithm()
        {
            Id 
        }

        algorithm.Id = id;
        algorithm.Name = name;
        algorithm.Description = description;
        algorithm.Type = type;
        algorithm.Icon = icon;
        algorithm.Url = url;
        algorithm.AlgorithmNickname = algorithmNickname;
        algorithm.IsPublished = IsPublished;
        algorithm.CreationDate = creationDate;

        _context.Algorithms.Add(algorithm);
    }*/
}
