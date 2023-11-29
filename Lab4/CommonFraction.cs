using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4;

public class CommonFraction
{
    private int numerator;
    private int denominator;

    public CommonFraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public override string ToString()
    {
        return $"{this.numerator}/{this.denominator}";
    }

    public CommonFraction reverseFraction()
    {
        return new CommonFraction(denominator, numerator).reducingFraction();
    }

    public static CommonFraction operator +(CommonFraction first, CommonFraction second)
    {
        int sumNumerator = first.numerator * second.denominator + second.numerator * first.denominator;
        int sumDenominator = first.denominator * second.denominator;
        return new CommonFraction(sumNumerator, sumDenominator).reducingFraction();
    }

    public static CommonFraction operator -(CommonFraction first, CommonFraction second)
    {
        int sumNumerator = first.numerator * second.denominator - second.numerator * first.denominator;
        int sumDenominator = first.denominator * second.denominator;
        return new CommonFraction(sumNumerator, sumDenominator).reducingFraction();
    }

    public static CommonFraction operator *(CommonFraction first, CommonFraction second)
    {
        int sumNumerator = first.numerator * second.numerator;
        int sumDenominator = first.denominator * second.denominator;
        return new CommonFraction(sumNumerator, sumDenominator).reducingFraction();
    }

    private CommonFraction  reducingFraction()
    {
        CommonFraction result = this;
        for (int i = 9; i > 1; i--)
        {
            if ((result.numerator%i == 0) && (result.denominator % i == 0))
            {
                result.numerator = result.numerator / i;
                result.denominator = result.denominator / i;
            }
        }
        return result;
    }
}

