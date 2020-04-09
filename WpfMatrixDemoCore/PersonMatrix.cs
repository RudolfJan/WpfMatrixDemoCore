using System.Collections.Generic;
using System.Linq;
using MatrixLib.Matrix;
using WpfMatrixDemo.Data;

namespace WpfMatrixDemo
{
    /// <summary>
    /// A matrix that displays people in the columns 
    /// and countries in which people live in the rows.
    /// </summary>
    public class PersonMatrix : MatrixBase<string, Person>
    {
        #region Constructor

        public PersonMatrix()
        {
            _people = Database.GetPeople();
        }

        #endregion // Constructor

        #region Base Class Overrides

        protected override IEnumerable<Person> GetColumnHeaderValues()
        {
            return _people;
        }

        protected override IEnumerable<string> GetRowHeaderValues()
        {
            // Return a sorted list of unique country names.
            return
                from person in _people
                orderby person.CountryOfResidence
                group person by person.CountryOfResidence into countryGroup
                select countryGroup.Key;
        }

        protected override object GetCellValue(string rowHeaderValue, Person columnHeaderValue)
        {
            return rowHeaderValue == columnHeaderValue.CountryOfResidence;
        }

        #endregion // Base Class Overrides

        #region Fields

        readonly Person[] _people;

        #endregion // Fields
    }
}