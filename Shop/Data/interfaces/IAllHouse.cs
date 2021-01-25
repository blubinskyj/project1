using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllHouse
    {
        IEnumerable<House> Houses { get; }
        IEnumerable<House> getFavHouse { get; set; }
        House getObjeckHouse(int HouseId);
    }
}
