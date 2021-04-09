using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDemoDataAccess
    {
        IList<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}