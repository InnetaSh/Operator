using Operator;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Создайте класс Complex, который представляет собой комплексное число и поддерживает основные операции над комплексными числами. Класс должен содержать:

//Поля:

//double Real -действительная часть комплексного числа.
//double Imaginary - мнимая часть комплексного числа.
//Конструкторы:

//Конструктор без параметров, инициализирующий нулями.
//Конструктор с параметрами для задания действительной и мнимой частей.
//Методы:


//ComplexNumber c1 = new ComplexNumber ( 12, 45 );
//ComplexNumber c2 = new ComplexNumber ( 23, 45 );
//ComplexNumber c3 = new ComplexNumber();
//c3 = c1 + c2;
//Console.WriteLine($"{c1},\n{c2},\n({c1}) + ({c2}) = {c3}");
//c3 = c1 - c2;
//Console.WriteLine($"({c1}) - ({c2}) = {c3}");
//c3 = c1 * c2;
//Console.WriteLine($"({c1}) * ({c2}) = {c3}");
//Console.WriteLine($"{c1} == {c2}: {c1 == c2} ");
//Console.WriteLine($"{c1} != {c2}: {c1 != c2} ");


namespace Operator
{
    internal class ComplexNumber
    {
        double Real { get; set; }
        double Imaginary { get; set; }

        public ComplexNumber() { }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;

        }

        //Переопределите метод ToString(), чтобы он возвращал строковое представление комплексного числа в формате "a + bi".

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        //Перегрузка операторов:
        //Перегрузите оператор + для сложения двух комплексных чисел.
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double Real = c1.Real + c2.Real;
            double Imaginary = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(Real, Imaginary);
     
        }


        //Перегрузите оператор - для вычитания одного комплексного числа из другого.

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            double Real = c1.Real - c2.Real;
            double Imaginary = c1.Imaginary - c2.Imaginary;
            return new ComplexNumber(Real, Imaginary);
        }


        //Перегрузите оператор * для умножения двух комплексных чисел.

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double Real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double Imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);
            return new ComplexNumber(Real, Imaginary);
        }

        //Перегрузите оператор == для сравнения двух комплексных чисел.
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
           return (c1.Real == c2.Real) && (c1.Imaginary == c2.Imaginary);
        }

        //Перегрузите оператор != для проверки на неравенство двух комплексных чисел.
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            //return (c1.Real != c2.Real && c1.Imaginary != c2.Imaginary);
            return !(c1 == c2);
        }
    }
}
