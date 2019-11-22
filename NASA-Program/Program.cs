using System;

/*
 * For this program, we'll be using the METRIC system
 * You can add another class declaration, or you can make a separate namespace (basically separate class, like java) and import it into this one
 * The locations could change though if we determine that there needs to be more organization
 * You may add elements to the properties classes (pod properties, moon properties), but please don't change the names of the ones we
 * already have in there
 * Please comment everything you put in here
 * That's it for now
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
        const double launchAngle = 0; // degree, needs to be 0 (our pod isn't being "shot" out of a module in orbit, it is being dropped downward)
                                      //                       (of course it will need some kind of force to push it down initially, though)
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
