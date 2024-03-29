﻿using Singleton;
using System;

using System.Collections.Generic;

using System.Threading;


namespace DoFactory.GangOfFour.Singleton.RealWorld
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Singleton Design Pattern.

    /// </summary>

    public class Program
    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main(string[] args)
        {

            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();

            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();



            // Same instance?

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {

                Console.WriteLine("Same instance\n");

            }


            // Load balance 15 server requests

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {

                string server = balancer.Server;

                Console.WriteLine("Dispatch Request to: " + server);

            }

            // Wait for user

            Console.ReadKey();

        }

    }

}
