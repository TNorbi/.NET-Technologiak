using System;
using System.Runtime.InteropServices;
using static Enums;

public class AlgorithmViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public AlgorithmType Type { get; set; }
    public string? Icon { get; set; }
    public string? Url { get; set; }
    public string? AlgorithmNickname { get; set; }

}
