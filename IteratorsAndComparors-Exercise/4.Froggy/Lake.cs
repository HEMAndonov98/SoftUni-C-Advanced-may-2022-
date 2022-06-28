using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4.Froggy
{
	public class Lake : IEnumerable<int>
	{
		private List<int> stones;

		public Lake(params int[] nums)
		{
			this.stones = nums.ToList();
		}

        public IEnumerator<int> GetEnumerator()
        {
            var oddStones = new List<int>();
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
                else
                {
                    oddStones.Add(this.stones[i]);
                }
            }

            oddStones.Reverse();
            foreach (var stone in oddStones)
            {
                yield return stone;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

