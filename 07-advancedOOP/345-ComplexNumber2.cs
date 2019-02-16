// Adrián Navarro Gabino

using System;

class ComplexNumber
{
    protected double real;
    protected double imag;
    
    public void SetReal(double real) { this.real = real; }
    public void SetImag(double imag) { this.imag = imag; }
    
    public double GetReal() { return real; }
    public double Getimag() { return imag; }
    
    public ComplexNumber(double real, double imag)
    {
        this.real = real;
        this.imag = imag;
    }
    
    public override string ToString()
    {
        return "(" + this.real + ", " + this.imag + ")";
    }
    
    public double GetMagnitude()
    {
        return Math.Sqrt(
            Math.Pow(this.real, 2) + Math.Pow(this.imag, 2));
    }
    
    public void Add(ComplexNumber c)
    {
        this.real += c.real;
        this.imag += c.imag;
    }
    
    public static ComplexNumber operator + (ComplexNumber c1,
        ComplexNumber c2)
    {
        ComplexNumber result = new ComplexNumber(c1.real, c1.imag);
        result.Add(c2);
        return result;
    }
    
    public static ComplexNumber operator - (ComplexNumber c1,
        ComplexNumber c2)
    {
        return new ComplexNumber(c1.real - c2.real, c1.imag - c2.imag);
    }
}

class ComplexNumberTest
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(3.4, 6.7);
        Console.WriteLine("c1 = " + c1);
        Console.WriteLine("|c1| = " + c1.GetMagnitude());
        ComplexNumber c2 = new ComplexNumber(10, 4.78);
        Console.WriteLine("c2 = " + c2);
        Console.WriteLine("|c2| = " + c2.GetMagnitude());
        c1.Add(c2);
        Console.WriteLine("c1 + c2 = " + c1);
    }
}
