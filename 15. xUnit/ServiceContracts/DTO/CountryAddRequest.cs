using Entities;

namespace ServiceContracts.DTO;

public class CountryAddRequest
{
    /// <summary>
    /// DTO class that is used for adding request
    /// </summary>
    public string? CountryName {get; set;}
    public Country ToCountry()
    {
        return new Country()
        {
            CountryName = CountryName
        };
    }
}