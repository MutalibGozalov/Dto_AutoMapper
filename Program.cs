using System.Runtime.ConstrainedExecution;
using System;
namespace ReflectionsDemo;
using Models;    
using Dto_AutoMapper.Models;    
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {    
        SuperHero batman = new(1, "Bruce", "Wayne", "Batman", 38, "Wealth", "JL");
        SuperHero superman = new(2, "Clark", "Kent", "Superman", 35, "Super strength, super speed", "JL");

        SuperHeroDto batmanDto = new();
        SuperHeroDto supermanDto = new();

        AutoMapper<SuperHero, SuperHeroDto> mapper = new();

        mapper.Map(batmanDto, batman);
        mapper.Map(supermanDto, superman);
        
        Console.WriteLine(batmanDto);
        Console.WriteLine();
        Console.WriteLine(supermanDto);
    }
}