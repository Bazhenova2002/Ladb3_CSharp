using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberLab
{
    class ComplexNumber
    {
        private readonly double realPart;  // поля класса действительная и мнимая часть
        private readonly double imaginaryPart;

        public double GetComplexNumberModule()  // метод расчета модуля комплекного числа 
        {
            return Math.Sqrt(Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2));
        }

        public double GetComplexNumberArgument()  // метод расчета аргумента комплексного числа
        {
            return Math.Acos(realPart / Math.Sqrt(Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2)));
        } 

        public ComplexNumber GetComplexNumberSqrt(double power)  // метод расчета корня н-ной степени комплексного числа 
        {
            double complexNumberModule = GetComplexNumberModule();
            double complexNumberArgument = GetComplexNumberArgument();

            double realPart = Math.Pow(complexNumberModule, 1 / power) * Math.Cos((complexNumberArgument + 2 * Math.PI) / power); 
            double imaginaryPart = Math.Pow(complexNumberModule, 1 / power) * Math.Sin((complexNumberArgument + 2 * Math.PI) / power);

            return new ComplexNumber(realPart, imaginaryPart);
        }

        public string Output()  // метод вывода вектора 
        {
            return (realPart + " + " + imaginaryPart + "i").ToString();
        }

        public static ComplexNumber operator +(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка сложения
        {
            return new ComplexNumber(arg1.realPart + arg2.realPart, arg1.imaginaryPart + arg2.imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка вычитания
        {
            return new ComplexNumber(arg1.realPart - arg2.realPart, arg1.imaginaryPart - arg2.imaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка умножения
        {
            return new ComplexNumber((arg1.realPart * arg2.realPart) - (arg1.imaginaryPart * arg2.imaginaryPart), 
                (arg1.realPart * arg2.imaginaryPart) + (arg2.realPart * arg1.imaginaryPart));
        }

        public static ComplexNumber operator /(ComplexNumber arg1, ComplexNumber arg2)  // перегрузка деления
        {
            return new ComplexNumber(0, 0);  // сделай сама, ибо я хз как там делить комплексные числа 
        }

        public static ComplexNumber operator ++(ComplexNumber arg)  // перегрузка увеличения действительной и мнимой части на 1
        {
            return new ComplexNumber(arg.realPart + 1, arg.imaginaryPart + 1);
        }

        public ComplexNumber(double realPart, double imaginaryPart)  // конструктор 
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }
    }
}