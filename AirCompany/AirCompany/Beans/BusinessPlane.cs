﻿using System;
using System.Xml.Serialization;

namespace AirCompany.Beans
{
    [Serializable]
    [XmlType("BusinessPlane")]
    public class BusinessPlane : Plane
    {
        private int _numOfVipPassengers;

        public BusinessPlane()
        {
        }

        public BusinessPlane(string name, int year, double price, int numOfVipPassengers, int maxDistance, int maxSpeed, double capacity, int maxLoad) : base(name, year, price, maxDistance, maxSpeed, capacity, maxLoad)
        {
            this._numOfVipPassengers = numOfVipPassengers;
        }

        [XmlElement("NumberOfVipPassengers")]
        public int numOfVipPassengers
        {
            get { return _numOfVipPassengers; }
            set { _numOfVipPassengers = value; }
        }

        public override string ToString()
        {
            return name + "\n\n. Type: " + GetType().Name + "\n. Year: " + year + "\n. Price, mln $: " + price
                + "\n. Number of VIP passengers: " + numOfVipPassengers + "\n. Max distance, km: " + maxDistance + "\n. Max speed, km/h: " + maxSpeed
                + "\n. Cargo capacity, m3: " + capacity + "\n. Max cargo load, kg: " + maxLoad + "\n";
        }
    }
}
