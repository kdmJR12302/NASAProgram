using System;

/*
 * 
 * 
 * 
 * 
 * 
 */


namespace NASA_Program
{
    class Program
    {
        static void Main(string[] args)
        {


            



        }
    }


    class PodProperties
    {

        //

        double podMass = 3315.3576;
        double velocityX; // m/s
        double velocityY; // m/s
        double podRadius; // m
        double velocity; // m/s

        double launchHeight; // km
        const double launchAngle = 0; // degree
        double impactAngle; // degree

    }


    class MoonProperties
    {
        const double moonRadius = 1737.12591; // km
        const double moonCircumference = 10921.01; // km
        double moonMass = 7.342 * Math.Pow(10, 22); // kg
        const double moonGravity = 1.625; // m/s


        const double moonMinOrbitV = 0.970; // km/s
        const double moonMaxOrbitV = 1.082; // km/s


    }


}
