using System;

namespace Prototype2
{
    [Serializable]
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString() 
        {
            return $"Street name: {StreetName}, house number: {HouseNumber}";
        }
    }
}