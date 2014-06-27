using System.Data;

namespace Ims.Core
{
    public class Parameter
    {
        public Parameter(string name, SqlDbType sqlDbType, object value)
        {
            Name = name;
            SqlDbType = sqlDbType;
            Value = value;
        }

        public string Name { get; set; }
        public SqlDbType SqlDbType { get; set; }
        public object Value { get; set; }
    }
}