namespace WpfMatrixDemo.Data
{
    class Country
    {
        // http://en.wikipedia.org/wiki/List_of_countries_by_exports
        public double ExportsInMillions { get; set; }

        // http://en.wikipedia.org/wiki/List_of_countries_by_external_debt
        public double ExternalDebtInMillions { get; set; }

        public string FlagIcon { get; set; }

        //http://en.wikipedia.org/wiki/List_of_countries_by_GDP_(nominal)
        public double GDPInMillions { get; set; }

        // http://en.wikipedia.org/wiki/List_of_countries_by_life_expectancy
        public double LifeExpectancy { get; set; }

        public string Name { get; set; }
    }
}