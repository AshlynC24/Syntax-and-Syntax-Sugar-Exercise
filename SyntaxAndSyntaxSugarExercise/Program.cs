﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4; //inferred typeing 

            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than 9";
            //this is sytax sugar with interpolation($) and ternary operation

        }
    }
}
