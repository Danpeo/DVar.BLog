using Danilvar.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace DVar.BLog.Domain.ValueObjects;

[Owned]
public class FullName : ValueObject
{
    public string Surname { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string? MiddleName { get; set; } = "";

    public FullName(string surname, string firstName, string? middleName)
    {
        Surname = surname;
        FirstName = firstName;
        MiddleName = middleName;
    }

    public FullName()
    {
        
    }
    
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Surname;
        yield return FirstName;
        if (MiddleName != null) yield return MiddleName;
    }
}