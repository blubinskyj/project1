using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockHouse : IAllHouse
    {

        private readonly IHouseCategory _categoryHouses = new MockCategory();
        public IEnumerable<House> Houses
        {
            get
            {
                return new List<House>
                {
                };
            }
        }
        public IEnumerable<House> getFavHouses { get ; set; }

        public House getObjeckHouse(int houseId)
        {
            throw new NotImplementedException();
        }
    }
}
