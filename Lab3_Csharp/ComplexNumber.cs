using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Csharp
{
    class ComplexNumber
    {
        private readonly double realPart;  // поля класса действительная и мнимая часть
        private readonly double imaginaryPart;

        public double RealPart => realPart;
        public double ImaginaryPart => imaginaryPart;

        public double GetComplexNumberModule()  // метод расчета модуля комплекного числа 
        {
            return Math.Sqrt(Math.Pow(RealPart, 2) + Math.Pow(ImaginaryPart, 2));
        }

        public double GetComplexNumberArgument()  // метод расчета аргумента комплексного числа
        {
            return Math.Acos(RealPart / Math.Sqrt(Math.Pow(RealPart, 2) + Math.Pow(ImaginaryPart, 2)));
        }

        public ComplexNumber GetComplexNumberSqrt(double power)  // метод расчета корня н-ной степени комплексного числа 
        {
            double complexNumberModule = GetComplexNumberModule();
            double complexNumberArgument = GetComplexNumberArgument();

            double realPart = Math.Pow(complexNumberModule, 1 / power) * Math.Cos((complexNumberArgument + 2 * Math.PI) / power);
            double imaginaryPart = Math.Pow(complexNumberModule, 1 / power) * Math.Sin((complexNumberArgument + 2 * Math.PI) / power);

            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            return (RealPart + " + " + ImaginaryPart + "i").ToString();
        }

        public static ComplexNumber operator +(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка сложения
        {
            return new ComplexNumber(arg1.RealPart + arg2.RealPart, arg1.ImaginaryPart + arg2.ImaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка вычитания
        {
            return new ComplexNumber(arg1.RealPart - arg2.RealPart, arg1.ImaginaryPart - arg2.ImaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка умножения
        {
            return new ComplexNumber((arg1.RealPart * arg2.RealPart) - (arg1.ImaginaryPart * arg2.ImaginaryPart),
                (arg1.RealPart * arg2.ImaginaryPart) + (arg2.RealPart * arg1.ImaginaryPart));
        }

        public static ComplexNumber operator /(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка деления
        {
            return new ComplexNumber(0, 0);  // сделай сама, ибо я хз как там делить комплексные числа 
        }

        public static ComplexNumber operator ++(ComplexNumber arg)  // перегрузка увеличения действительной и мнимой части на 1
        {
            return new ComplexNumber(arg.RealPart + 1, arg.ImaginaryPart + 1);
        }

        public ComplexNumber(double realPart, double imaginaryPart)  // конструктор 
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }
    }
}