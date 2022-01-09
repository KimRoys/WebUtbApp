using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUtbApp.Models
{
    public class DoctorModel
    {
        public float Temp { get; set; }
        public static float Fever = 37;
        public static float Hypothermia = 36;
        public bool IsCelsius { get; set; }
        public bool IsFahrenheit { get; set; }

        public static string Fevercheck(float temp)
        {
            string message;

            if (temp > Fever)
            {
                message = "You have a fever!";
            }
            else if (temp < Hypothermia)
            {
                message = "You have Hypothermia!";
            }
            else
            {
                message = "You are healthy!";
            }

            return message;

            // else if (isFahrenheit)
            //{
            //    Fever = 99;
            //    Hypothermia = 97;
            //
            //    if (temp > Fever)
            //    {
            //        message = "You have a fever!";
            //    }
            //    else if (temp < Hypothermia)
            //    {
            //        message = "You have Hypothermia!";
            //    }
            //    else
            //    {
            //        message = "You are healthy!";
            //    }
            //    return message;
            //}
            //else
            //{
            //    message = "Something went wrong";
            //    return message;
            //}
            //Celsius
            //@Html.RadioButtonFor(model => model.IsCelsius, "Celsius")
            //            Fahrenheit
            //@Html.RadioButtonFor(model => model.IsFahrenheit, "Fahrenheit")
            //< input type = "submit" value = "Testa" />

        }

        public static string WriteMessage()
        {
            return "Please enter your temperature:";
        }
    }
}
