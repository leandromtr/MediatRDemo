﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDemoDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Leandro", LastName = "Reis" });
            people.Add(new PersonModel { Id = 2, FirstName = "Lucas", LastName = "Souza" });
        }

        public IList<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel person = new() { FirstName = firstName, LastName = lastName };
            person.Id = people.Max(x => x.Id) + 1;
            people.Add(person);
            return person;
        }
    }
}
