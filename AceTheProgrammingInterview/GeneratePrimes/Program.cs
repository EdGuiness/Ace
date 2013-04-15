using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneratePrimes
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberToGenerate = 100000;
            var timer = new Stopwatch();

            // Unoptimised naive
            timer.Start();
            var primes = GeneratePrimes(numberToGenerate);
            Console.WriteLine(string.Format(" GeneratePrimes: {0} primes generated in {1}", numberToGenerate, timer.Elapsed));
            timer.Reset(); 

            int last = primes.Last();

            // Optimised naive
            timer.Start();
            primes = GeneratePrimesOptimised(numberToGenerate);
            timer.Stop();
            if (primes.Last() != last) throw new Exception();

            Console.WriteLine(string.Format("GeneratePrimesOptimised: {0} primes generated in {1}", numberToGenerate, timer.Elapsed));


            // Sieve 1
            timer.Start();
            primes = EratosthenesSieve(last+1);
            timer.Stop(); 
            if (primes.Last() != last) throw new Exception();

            Console.WriteLine(string.Format("EratosthenesSieve: {0} primes generated in {1}", numberToGenerate, timer.Elapsed));
 
            Console.ReadLine();
        }


        public static List<int> GeneratePrimes(int n)
        {
            var primes = new List<int>();

            int nextCandidatePrime = 2;

            primes.Add(nextCandidatePrime);

            while (primes.Count < n)
            {
                if (isPrimeFaster(nextCandidatePrime))
                    primes.Add(nextCandidatePrime);

                nextCandidatePrime += 1;

                if (nextCandidatePrime % 10000 == 0)
                    Console.WriteLine(string.Format("{0} -> {1}", nextCandidatePrime, primes.Count));
            }

            return primes;
        }

        // Terrible, looks at every number up to n
        private static bool isPrimeSlowest(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Don't look any further than sqrt(n)
        private static bool isPrimeSlow(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Ignore even numbers, stop at sqrt(n)
        private static bool isPrimeFaster(int n)
        {
            if (n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        public static List<int> GeneratePrimesOptimised(int n)
        {
            var primes = new List<int>();

            // Prime our list of primes
            primes.Add(2);

            // Start from 3, since we already know 2 is a prime
            int nextCandidatePrime = 3;

            // Keep going until we have generated the required amount
            while (primes.Count < n)
            {
                // Assume the number is prime
                bool isPrime = true;
                for (int i = 0; primes[i] <= Math.Sqrt(nextCandidatePrime); i++)
                {
                    // Here we use our set of primes rather than a sequence of divisors
                    if (nextCandidatePrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primes.Add(nextCandidatePrime);

                // We proceed in steps of 2, avoiding the even numbers
                nextCandidatePrime += 2;
            }
            return primes;
        }

        static List<int> EratosthenesSieve(int candidate)
        {
            BitArray sieveContainer = new BitArray(candidate + 1, true);
            int marker = 2; //start
            int factor = 2; //start.

            sieveContainer[0] = false;//0 is not prime
            sieveContainer[1] = false;//1 is not prime

            while ((marker * marker) <= sieveContainer.Length)
            {
                while ((factor += marker) <= candidate)
                {
                    sieveContainer[factor] = false;
                };
                factor = ++marker; //reset
            }

            List<int> result = new List<int>();
            for (int i = 0; i < sieveContainer.Count; i++)
                if (sieveContainer[i])
                    result.Add(i);

            return result;
        }

    }
}