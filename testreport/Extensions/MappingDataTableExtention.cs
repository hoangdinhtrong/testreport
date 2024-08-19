using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace testreport.Extensions
{
    public static class MappingDataTableExtention
    {
        public static List<T> CreateListFromTable<T>(this DataTable dataTable) where T : new()
        {
            // define return list
            List<T> items = new List<T>();

            // go through each row
            foreach (DataRow row in dataTable.Rows)
            {
                // add to the list
                items.Add(CreateItemFromRow<T>(row));
            }

            // return the list
            return items;
        }

        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            // create a new object
            T item = new T();

            // set the item
            SetItemFromRow(item, row);

            // return 
            return item;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // if exists, set the value
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
    }
}
