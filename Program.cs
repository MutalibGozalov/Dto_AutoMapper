using System.Runtime.ConstrainedExecution;
using System;
namespace ReflectionsDemo;
using Models;    
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
    #region Tests
        // MemberInfo info = typeof(MyClass);
        // object[] attributes = info.GetCustomAttributes(true);
         


        // for (int i = 0; i < attributes.Length; i++) 
        // {
        //    Console.WriteLine(attributes[i]);
        // }

        // Type type = typeof(MyClass);
        // foreach (MethodInfo m in type.GetMethods())
        // {
        // //   System.Console.WriteLine();
        // }
        // var mete = new MyClass();
        // type.GetProperty("Name").SetValue(mete,"Mutalib");

        // System.Console.WriteLine(mete.Name);
    
#endregion
    
        SuperHero batman = new(1, "Bruce", "Wayne", "Batman", 38, "Wealth", "JL");
        SuperHero superman = new(2, "Clark", "Kent", "Superman", 35, "Super strength, super speed", "JL");

        SuperHeroDto batmanDto = new();
        SuperHeroDto supermanDto = new();

        Type superHero = typeof(SuperHero);
        Type superHeroDto = typeof(SuperHeroDto);

        foreach (var dtoProp in superHeroDto.GetProperties())
        {
            foreach (var heroProp in superHero.GetProperties())
            {
                if (dtoProp.Name == heroProp.Name)
                {
                    dtoProp.SetValue(batmanDto, heroProp.GetValue(batman));
                    dtoProp.SetValue(supermanDto, heroProp.GetValue(superman));
                }
            }
        }
        Console.WriteLine(batmanDto);
        Console.WriteLine();
        Console.WriteLine(supermanDto);
    }
}