using Entities;
using ServiceContracts.Enums;

namespace ServiceContracts.DTO;

/// <summary>
/// DTO class that is used for adding request
/// </summary>
public class PersonAddRequest
{
    public string? PersonName {get; set;}
    public string? Email {get; set;}
    public DateTime? DateOfBirth {get; set;}
    public GenderOptions? Gender {get; set;}
    public Guid? CountryId {get; set;}
    public string? Address {get; set;}
    public bool ReceiveNewsLetters {get; set;}

    /// <summary>
    /// Converts PersonAddRequest object into a new Person object
    /// </summary>
    /// <returns></returns>
    public Person ToPerson()
    {
        return new Person()
        {
            PersonName = PersonName,
            Email = Email,
            DateOfBirth = DateOfBirth,
            Gender = Gender.ToString(),
            CountryId = CountryId,
            Address = Address,
            ReceiveNewsLetters = ReceiveNewsLetters
        };
    }
}