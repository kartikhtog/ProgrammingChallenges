using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class FindAllPrimes
	{

	
		
		/// <summary>
		/// Find primes up to max
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public IEnumerable<int> FindPrimes(int max)
		{
			//return SimpleApproach(max);
			return SlighlyBetterApproach(max);
		}


		public Func<int, IEnumerable<int>> SimpleApproach()
		{
			return new Func<int, IEnumerable<int>>((max) =>
			{
				return SimpleApproach(max);
			});
		}

		/// <summary>
		/// Run time O(n^2)
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public IEnumerable<int> SimpleApproach(int max)
		{
			var list = new List<int>();
			for(int i = 1;i <= max; i++)
			{
				var isPrime = true;
				for(int j = 2; j< i;j++)
				{
					if (i%j == 0 )
					{
						isPrime = false;
					}
				}
				if (isPrime)
				{
					list.Add(i);
				}
			}
			return list;
		}


		public Func<int, IEnumerable<int>> SlighlyBetterApproach()
		{
			return new Func<int, IEnumerable<int>>((max) =>
			{
				return SlighlyBetterApproach(max);
			});
		}
		/// <summary>
		/// Run time?
		/// https://math.stackexchange.com/questions/1241864/sum-of-square-roots-formula/1739708
		/// >O(nlogn) , < O(n^2)
		/// = O(n^(3/2))
		/// it is sum of 1^(1/2) + 2^(1/2) + ..... + n^(1/2) = O(n^(3/2)) for the leading term
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public IEnumerable<int> SlighlyBetterApproach(int max)
		{
			var list = new List<int>();
			for (int i = 1; i <= max; i++)
			{
				var isPrime = true;
				for (int j = 2; j < Math.Sqrt(i); j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
					}
				}
				if (isPrime)
				{
					list.Add(i);
				}
			}
			return list;
		}


		public Func<int, IEnumerable<int>> EvenBetterApproach()
		{
			return new Func<int, IEnumerable<int>>((max) =>
			{
				return EvenBetterApproach(max);
			});
		}

		// Run time O(n), space O(n)
		public IEnumerable<int> EvenBetterApproach(int max)
		{
			var primes = new List<int>();
			var lastPrime = 1;
			var nextPrime = 1;
			bool[] isNotPrime = new bool[max + 1];
			primes.Add(lastPrime); 
			while (true)
			{ 
				nextPrime = findNextPrime(lastPrime, max, isNotPrime);
				if (nextPrime == 0)
				{
					break;
				}
				RemoveNonPrimes(nextPrime, max, isNotPrime);
				lastPrime = nextPrime;
				primes.Add(lastPrime);
			}

			return primes;
		}
		private void RemoveNonPrimes(int prime, int max, bool[] isNotPrime)
		{
			for (int i = prime * prime; i <= max &&  i > 0; i += prime)
			{
				try
				{
					isNotPrime[i] = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error here1");
					throw ex;
				}
			}
		}

		private int findNextPrime(int lastPrime, int max, bool[] isNotPrime)
		{
			while (lastPrime < max)
			{
				if (!isNotPrime[++lastPrime])
				{
					return lastPrime;
				}
			}
			return 0;
		}

		public Func<int, IEnumerable<int>> BestApproach()
		{
			return new Func<int, IEnumerable<int>>((max) =>
			{
				return EvenBetterApproach(max);
			});
		}

		public IEnumerable<int> BestApproach(int max)
		{
			var primes = new List<int>();
			var lastPrime = 1;
			var nextPrime = 1;
			bool[] isNotPrime = new bool[max + 1];
			primes.Add(lastPrime);
			var maxPrime = (int)Math.Sqrt(max) + 1;
			while (nextPrime < maxPrime)
			{
				nextPrime = findNextPrime(lastPrime, max, isNotPrime);

				RemoveNonPrimes(nextPrime, max, isNotPrime);
				lastPrime = nextPrime;
				primes.Add(lastPrime);
			}
			return primes;
		}
	}
}
