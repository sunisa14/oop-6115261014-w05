using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w05
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLatitude;
        private string buildingLongitude;
        public string BuildingCode
        {
            get { return buildingCode; }
            set { this.buildingCode = value; }
        }
        public string BuildingName
        {
            get { return buildingName; }
            set { this.buildingName = value; }
        }
        public string BuildingLatitude
        {
            get { return buildingLatitude; }
            set { this.buildingLatitude = value; }
        }
        public string BuildingLongitude
        {
            get { return buildingLongitude; }
            set { this.buildingLongitude = value; }
        }
        public Building() { }
        public Building(string bc, string bn, string blat, string blong)
        {
            this.BuildingCode = bc;
            this.BuildingName = bn;
            this.BuildingLatitude = blat;
            this.BuildingLongitude = blong;
        }
        public override string ToString()
        {
            return this.BuildingCode + " " + this.BuildingName;
        }
    }
}