﻿using System.Net.NetworkInformation;

namespace Utils
{
    public static class Utilities
    {
        public static bool IsNullEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);
        public static bool IsZeroOrNegative(int value)
        {
            // Simple technique -> returns expression
            // return value <= 0; //true | false

            // Explicit technique -> declare all parts
            //bool result;

            //if (value <= 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}

            //return result;

            // Simple but explicit -> conditional / terneray operator
            

            return value <=0 ? true : false;
            //    if(        ) a   else    b
            
        }

        public static bool IsPositive(int value) => value > 0;
        public static bool IsPositive(double value) => value > 0.0;
        public static bool IsPositive(decimal value) => value > 0M;

        /// <summary>
        /// Determines if a DateOnly is in the future, tomorrow or greater
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInTheFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}