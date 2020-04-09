namespace WpfMatrixDemo.Data
{
    static class Database
    {
        public static Person[] GetPeople()
        {
            return new Person[]
            {
                new Person 
                { 
                    Name= "Brennon", 
                    CountryOfResidence = "United Kingdom"
                },
                new Person
                {
                    Name="Josh", 
                    CountryOfResidence ="United States"
                },
                new Person
                {
                    Name="Karl", 
                    CountryOfResidence= "United States"
                },
                new Person
                {
                    Name="Laurent", 
                    CountryOfResidence="Switzerland"
                },
                new Person
                {
                    Name="Sacha", 
                    CountryOfResidence= "United Kingdom"
                }      
            };
        }

        public static Country[] GetCountries()
        {
            return new Country[]
            {
                new Country
                {
                    Name = "Switzerland",
                    ExportsInMillions = 172700,
                    ExternalDebtInMillions = 1340000,
                    FlagIcon = "Flags/switzerland.png",
                    GDPInMillions = 492595,
                    LifeExpectancy = 80.62
                },
                new Country
                {
                    Name = "United Kingdom",
                    ExportsInMillions = 468700,
                    ExternalDebtInMillions = 10450000,
                    FlagIcon = "Flags/uk.png",
                    GDPInMillions = 2674085,
                    LifeExpectancy = 78.7
                },
                new Country
                {
                    Name = "United States",
                    ExportsInMillions = 1377000,
                    ExternalDebtInMillions = 13703567,
                    FlagIcon = "Flags/usa.png",
                    GDPInMillions = 14264600,
                    LifeExpectancy = 78.06
                }
            };
        }
    }
}