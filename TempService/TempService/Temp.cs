namespace TempService
{
    public class Temp
    {
        double celsiusToFarenheit(double temp)
        {
            return  (temp * 9/5) +32;
        }

        double farenheitToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
