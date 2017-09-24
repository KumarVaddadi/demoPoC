using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableApp.Models
{
    public class Consist
    {
        /*
         * <BusVersion i:nil="true"/>
            <GPRSIpAddress>10.149.234.74</GPRSIpAddress>
            <IpAddress/>
            <Name>187010</Name>
            <NrOfCars>1</NrOfCars>
            <SoldTime>2017-06-14T20:40:00</SoldTime>
            <StateId>0</StateId>
            <VehiclePos>0</VehiclePos>
         */

        public string GPRSIpAddress { get; set; }
        public int Name { get; set; }
        public int NrOfCars { get; set; }
        public string SoldTime { get; set; }
        public int StateId { get; set; }
        public int VehiclePos { get; set; }
    }
}
