using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Runtime.InteropServices;

public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            if(context != null && !context.Algorithms.Any())
            {
                context.Algorithms.AddRange(
                    new Algorithm()
                    {
                        Name = "Bubble sort",
                        Description = "This is a sorting algorithm",
                        AlgorithmNickname = "bubble",
                        Type = Enums.AlgorithmType.Sorting,
                        CreationDate = DateTime.Now,
                        IsPublished = true,
                       Url = "https://www.youtube.com/watch?v=lyZQPjUT5B4"
                    },
                    new Algorithm()
                    {
                        Name = "Insertion sort",
                        Description = "This is a sorting algorithm",
                        AlgorithmNickname = "insertion",
                        Type = Enums.AlgorithmType.Sorting,
                        CreationDate = DateTime.Now,
                        IsPublished = false,
                        Url = "https://www.youtube.com/watch?v=ROalU379l3U&t=8s"
                    },
                    new Algorithm()
                    {
                        Name = "Selection sort",
                        Description = "This is a sorting algorithm",
                        AlgorithmNickname = "selection",
                        Type = Enums.AlgorithmType.Sorting,
                        CreationDate = DateTime.Now,
                        IsPublished = true,
                        Url = "https://www.youtube.com/watch?v=Ns4TPTC8whw&t=6s"
                    },
                    new Algorithm()
                    {
                        Name = "Merge sort",
                        Description = "This is a sorting algorithm",
                        AlgorithmNickname = "merge",
                        Type = Enums.AlgorithmType.Sorting,
                        CreationDate = DateTime.Now,
                        IsPublished = true,
                        Url = "https://www.youtube.com/watch?v=XaqR3G_NVoo"
                    },
                    new Algorithm()
                    {
                        Name = "Binary search",
                        Description = "This is a searching algorithm",
                        AlgorithmNickname = "binary",
                        Type = Enums.AlgorithmType.Searching,
                        CreationDate = DateTime.Now,
                        IsPublished = false,
                        Url = "https://www.youtube.com/watch?v=iP897Z5Nerk"
                    }
               ); 
            }
        }
    }
}
