using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDemoDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}