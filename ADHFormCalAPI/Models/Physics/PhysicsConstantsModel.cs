using System;
namespace ADHFormCalAPI.Models.Physics
{

    public class PhysicsConstantsModel
    {
        public double LightSpeedValue => 299792458;
        public char LightSpeedSymbol => 'c';
        public string LightSpeedUnit => "m.s";
        public double NewtonianGravitationValue => 6.67408 * Math.Pow(10, -11);
        public char NewtonianGravitationSymbol => 'G';
        public string NewtonianGravitationUnit => "m^3.kg^-1.s^-2";
    }
}
