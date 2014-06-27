namespace Ims.Core
{
    public class ListRequest
    {
        public ListRequest(int pageIndex, int pageSize, ListRequestColumn[] listRequestColumns)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            ListRequestColumns = listRequestColumns;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public ListRequestColumn[] ListRequestColumns { get; set; }
    }

    public class ListRequestColumn
    {
        public ListRequestColumn(string name, int orderByIndex)
        {
            Name = name;
            OrderByIndex = orderByIndex;
        }

        public string Name { get; set; }
        public int OrderByIndex { get; set; }
    }
}
