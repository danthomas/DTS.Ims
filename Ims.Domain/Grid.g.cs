using System;

namespace Ims.Domain
{
    public class Grid
    {
        public Grid(byte gridId, string gridName)
        {
            GridId = gridId;
            GridName = gridName;
        }
    
        public byte GridId { get; set; }
        public string GridName { get; set; }
    }
}