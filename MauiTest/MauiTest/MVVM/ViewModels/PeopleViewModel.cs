using MauiTest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new List<Person>
            { 
                new Person{
                Name = "Juan",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) },
                  new Person{
                Name = "Cristian",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) },
                    new Person{
                Name = "Pepe",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) },
                      new Person{
                Name = "Luis",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) },
                  new Person{
                Name = "Maria",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) },
                    new Person{
                Name = "Silvina",
                Age = 48,
                Married = true,
                BirthDate = new DateTime(1974, 9, 23),
                Weight = 89,
                LunchTime = new TimeSpan(10, 0, 0) }
            };

        }

        public List<Person> People { get; set; }
    }
}
