using Microsoft.EntityFrameworkCore;
using api_with_cosmosdb.Data;
using api_with_cosmosdb.models;



using (var api_with_cosmosdb = new NorthWindContext())
{
    var employe1 = new Employer()
    {
        Id = Guid.NewGuid().ToString(),
        LastName = "Meireles",
        FirstName = "Arthur",
        Title = "Developer",
        BirthDate = new DateTime(1999, 4, 29),
        HireDate = new DateTime(2017, 9, 12),
        Address = "Cohatrac 5, quadra 29, villagio",
        City = "São Luís",
        PostalCode = "6511-0000",
        Country = "Brasil",
        EmployerPhone = "98970221807",
    };


    var employe2 = new Employer()
    {
        Id = Guid.NewGuid().ToString(),
        LastName = "Castro",
        FirstName = "Vitor",
        Title = "Developer",
        BirthDate = new DateTime(1999, 4, 29),
        HireDate = new DateTime(2017, 9, 12),
        Address = "Cohatrac 5, quadra 29, villagio",
        City = "São Luís",
        PostalCode = "6511-0000",
        Country = "Brasil",
        EmployerPhone = "98970221807",
    };

    api_with_cosmosdb.Employers.Add(employe1);
    api_with_cosmosdb.Employers.Add(employe2);

    await api_with_cosmosdb.SaveChangesAsync();
}



