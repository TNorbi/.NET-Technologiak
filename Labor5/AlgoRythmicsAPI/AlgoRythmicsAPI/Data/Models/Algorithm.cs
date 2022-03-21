using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using static Enums;

public class Algorithm
{
    
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public AlgorithmType Type { get; set; }
    public string? Icon { get; set; }
    public string? Url { get; set; }
    public string? AlgorithmNickname { get; set; }
    public bool? IsPublished { get; set; }
    public DateTime CreationDate { get; set; }
}