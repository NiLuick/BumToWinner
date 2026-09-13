namespace MasterCalculator;

public class QuadraticFormula
{
    public (double resultX1, double resultX2) CalculateResult(int parameterA, int parameterB, int parameterC)
    {
        double discriminant = Math.Pow((parameterB - parameterA), 2);

        double resultX1 = parameterA * parameterB * parameterC;
        double resultX2 = resultX1 * parameterC;

        return (resultX1, resultX2);
    }
}