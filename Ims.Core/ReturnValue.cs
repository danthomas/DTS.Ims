using System.Collections.Generic;
using System.Linq;

namespace Ims.Core
{
    public class ReturnValue
    {
        public bool Success { get; set; }
    }

    public class ReturnValue<T> : ReturnValue
    {
    }

    public class ListReturnValue<T> : ReturnValue
    {
        public ListReturnValue(IEnumerable<T> items, int totalItems, int pageIndex)
        {
            Items = items.ToArray();
            TotalItems = totalItems;
            PageIndex = pageIndex;
        }

        public T[] Items { get; set; }
        public int TotalItems { get; set; }
        public int PageIndex { get; set; }
    }
}
