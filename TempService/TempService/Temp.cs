namespace TempService
{
    public class Temp
    {
        double ctf(double temp)
        {
            return  (temp * 9/5) +32;
        }

        double ftc(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}