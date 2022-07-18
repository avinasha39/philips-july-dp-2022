
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

// Problems
// 1. Method doing handling multiple checks breaking SRP 
// 2. Method is closed for extension and has to be modified in future. 

//Refacored Code
class Checker
{
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        return isTemperatureOk(temperature) && isSOCOk(soc) && ischargeRateOk(chargeRate);
    }
    
    public bool isTemperatureOk(float temperature){
        if(temperature < 0 || temperature > 45) {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
        return true;
    }
    
    public bool isSOCOk(float soc){
        if(soc < 20 || soc > 80) {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        }
        return true;
    }
    public bool ischargeRateOk(float chargeRate){
         if(chargeRate > 0.8) {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;
    }
}

// Fixes
// 1. Adding 3 different method to handle 3 responsiblity and retuen boolean
// 2. batteryIsOk should call different method, consolidate the result and return
