using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Room
    {

        private Room? north;
        private Room? south;
        private Room? east;
        private Room? west;

        public Loot loot;
        public Enemies enemy;

        public string Description { get; set; } = "";

        public void AddNorth(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom.south = this;
            north = otherRoom;
        }
        public void AddSouth(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom.north = this;
            south = otherRoom;
        }
        public void AddEast(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom.west = this;
            east = otherRoom;
        }
        public void AddWest(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom.east = this;
            west = otherRoom;
        }
    }
}
