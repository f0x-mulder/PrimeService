using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesChecker
{
    public class PrimeService
    {
        const long mint = 10000000;
        public int[] prime = new int[mint];
        public void sieve()
        {
            for (long i = 0; i < mint; i++) prime[i] = 1;
            for (int i = 2; i < mint; i++)
            {
                if (prime[i] == 1)
                {
                    for (long j = (long) i * i; j  < mint; j += i)
                    {
                        prime[j] = 0;
                    }
                }
            }
        }

        public PrimeService()
        {
            sieve();
        }

        public bool IsPrime(int cand) {
            if (cand >= mint) throw new Exception("");
            return prime[cand] == 1;
        }
    }
}
