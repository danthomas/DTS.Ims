using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Ims.Core
{
    public static class DataTableExtensions
    {
        private readonly static object MapLock;
        private static readonly Dictionary<string, object> Funcs;

        static DataTableExtensions()
        {
            MapLock = new object();
            Funcs = new Dictionary<string, object>();
        }

        public static IEnumerable<T> ObjectForEachRow<T>(this DataTable thisDataTable)
        {
            Func<DataRow, T> func;

            string[] names = thisDataTable.Columns.Cast<DataColumn>()
                 .Join(typeof(T).GetProperties(), column => column.ColumnName, info => info.Name, (column, info) => column.ColumnName).ToArray();

            string key = String.Format("{0}.{1}", typeof(T).FullName, names.OrderBy(name => name).Aggregate((a, b) => a + "." + b));

            lock (MapLock)
            {
                if (Funcs.ContainsKey(key))
                {
                    func = (Func<DataRow, T>)Funcs[key];
                }
                else
                {
                    ParameterExpression dataRowExpression = Expression.Parameter(typeof(DataRow));
                    ParameterExpression objectExpression = Expression.Variable(typeof(T));

                    List<Expression> expressions = new List<Expression>
                    {
                        //T object = new T();
                        Expression.Assign(objectExpression, Expression.New(typeof (T)))
                    };

                    foreach (PropertyInfo propertyInfo in typeof(T).GetProperties().Where(item => names.Contains(item.Name)))
                    {
                        //object.Property = dataRow.Field<PropertyType>("PropertyName");

                        expressions.Add(Expression.Assign(Expression.Property(objectExpression, propertyInfo),
                            Expression.Call(typeof(DataRowExtensions), "Field", new[] { propertyInfo.PropertyType }, dataRowExpression, Expression.Constant(propertyInfo.Name))));
                    }

                    expressions.Add(objectExpression);

                    func = Expression.Lambda<Func<DataRow, T>>(Expression.Block(new[] { objectExpression }, expressions), new[] { dataRowExpression }).Compile();

                    Funcs.Add(key, func);
                }
            }

            return from DataRow dataRow in thisDataTable.Rows select func(dataRow);
        }
    }
}
