using System;
using System.Collections.Generic;
using System.Text;

namespace myNIC
{
    enum NIC_Type
    {
        Ethernet,
        tokenRing
    }
    class NIC
    {
        public string Manufacture { get; } = "Blaa manufacturer";
        public string MAC_Address { get; } = "00:1A:C2:7B:00:47";
        public NIC_Type myType { get; } = NIC_Type.Ethernet;
        private NIC() { }
        public static NIC oneInstance = new NIC();
        public override string ToString()
        {
            return $"Manufacturer: {Manufacture}, Mac address: {MAC_Address}, NIC Type: {myType}";
        }
    }
}
