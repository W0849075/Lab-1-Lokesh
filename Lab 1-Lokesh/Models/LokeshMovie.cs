﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab_1_Lokesh.Models;

    public class LokeshMovie
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]

    public string? Title { get; set; }
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]

    public decimal price { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]

    public string? Genre { get; set; }
    
    public string? Rating { get; set; }

}
