using V_Speeds.ConstantsAndConverters;

namespace V_Speeds.Model.Aircrafts
{
    public class ExternalAircraft : Aircraft
    {
        public ExternalAircraft()
        {
            Gw = 50000;
            Lsa = 50;
            Cl = 1.23;
            Clg = 0.123;
            Thr = 100000;
            Bf = 50000;
            Rc = 2;
            Cd = 0.1;
            Rtr = 0.667;
            Rfc = 0.05;
        }

        public override double Thrust(double tas, double density)
        {
            return Math.Min(1, density / Constants.p0);
        }

    }

    public class ExternalAircraftAB : AircraftAB
    {
        public ExternalAircraftAB()
        {
            Gw = 100000;
            Lsa = 50;
            Cl = 1.23;
            Clg = 0.123;
            Thr = 125000;
            ThrAB = 250000;
            Bf = 75000;
            Rc = 2.5;
            RcAB = 3.5;
            Cd = 0.08;
            Rtr = 0.6;
            Rfc = 0.06;
        }

        public override double Thrust(double tas, double density)
        {
            return Math.Min(1, density / Constants.p0);
        }
    }
}