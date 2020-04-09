using System.Collections.Generic;
using System.Globalization;
using Matrix.Library.Matrix;
using WpfMatrixDemo.Data;

namespace WpfMatrixDemo
{
    /// <summary>
    /// A matrix that displays countries in the columns
    /// and attributes of a country in the rows.
    /// </summary>
    class CountryMatrix : MatrixBase<string, Country>
    {
        #region Constructor

        public CountryMatrix()
        {
            _countries = Database.GetCountries();

            _rowHeaderToValueProviderMap = new Dictionary<string, CellValueProvider>();
            this.PopulateCellValueProviderMap();
        }

        #endregion // Constructor

        #region Base Class Overrides

        protected override IEnumerable<Country> GetColumnHeaderValues()
        {
            return _countries;
        }

        protected override IEnumerable<string> GetRowHeaderValues()
        {
            return _rowHeaderToValueProviderMap.Keys;
        }

        protected override object GetCellValue(string rowHeaderValue, Country columnHeaderValue)
        {
            return _rowHeaderToValueProviderMap[rowHeaderValue](columnHeaderValue);
        }

        #endregion // Base Class Overrides

        #region Private Helpers

        void PopulateCellValueProviderMap()
        {
            // Use the American culture to force currency 
            // formatting to use the dollar sign ($).
            CultureInfo culture = new CultureInfo("en-US");

            _rowHeaderToValueProviderMap.Add(
                "Exports (millions)",
                country => country.ExportsInMillions.ToString("c0", culture));

            _rowHeaderToValueProviderMap.Add(
                "External Debt (millions)",
                country => country.ExternalDebtInMillions.ToString("c0", culture));

            _rowHeaderToValueProviderMap.Add(
                "GDP (millions)",
                country => country.GDPInMillions.ToString("c0", culture));

            _rowHeaderToValueProviderMap.Add(
                "Life Expectancy",
                country => country.LifeExpectancy.ToString("f2"));
        }

        #endregion // Private Helpers

        #region Fields

        readonly Country[] _countries;
        readonly Dictionary<string, CellValueProvider> _rowHeaderToValueProviderMap;

        /// <summary>
        /// This delegate type describes the signature of a method 
        /// used to produce the value of a cell in the matrix.
        /// </summary>
        private delegate object CellValueProvider(Country country);

        #endregion // Fields
    }
}