
//C# Code
class Checker
{
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        if(temperature < 0 || temperature > 45) {
            Console.WriteLine("Temperature is out of range!");
            return false;
        } else if(soc < 20 || soc > 80) {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        } else if(chargeRate > 0.8) {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;
    }
}

// 
