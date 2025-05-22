using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDataGrid
{
    /// <summary>
    /// Represents a column in a data grid with filtering capabilities.
    /// </summary>
    public interface IDataGridColumn
    {
        /// <summary>
        /// Gets or sets the field name associated with the column.
        /// </summary>
        string FieldName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the column is currently filtered.
        /// </summary>
        bool IsColumnFiltered { get; set; }
    }
}
