using System.Collections.Generic;
using System.Linq;

public class SimilarDominoes
{
    private class NumberOfDominoes
    {
        public int Count = 1;
    }
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        if (dominoes == null || dominoes.Length <= 1)
        {
            return 0;
        }

        var sameDominoCount = new Dictionary<string, NumberOfDominoes>();
        
        foreach (var domino in dominoes)
        {
            NumberOfDominoes count;
            if (sameDominoCount.TryGetValue(domino[0].ToString() + domino[1].ToString(), out count))
            {
                count.Count++;
            }
            else
            {
                sameDominoCount.Add(domino[0].ToString()+domino[1].ToString(), new NumberOfDominoes());
            }
        }
        
        var sortedDominoes = sameDominoCount.OrderBy(x => x.Key).ToList();
        var numEqual = 0;

        for (int i = 0; i < sortedDominoes.Count; i++)
        {
            for(int j = i + 1; j < sortedDominoes.Count; j++)
            {
                var first = sortedDominoes[i];
                var second = sortedDominoes[j];
                {
                    if (DominoesAreEqual(first.Key, second.Key))
                    {
                        numEqual += first.Value.Count * second.Value.Count;
                    }
                }
            }
        }

        foreach(var domino in sortedDominoes)
        {
            if (domino.Value.Count > 1)
            {
                numEqual += nCr(domino.Value.Count, 2);
            }
        }

        return numEqual;
    }

    private bool DominoesAreEqual(string dominoOne, string dominoTwo)
    {
        if (dominoOne == dominoTwo)
        {
            return true;
        }
        else if (dominoOne[0] == dominoTwo[1] && dominoOne[1] == dominoTwo[0])
        {
            return true;
        }
        return false;
    }
    private int fact(int factOf)
    {
        var result = 1;
        while(factOf != 1)
        {
            result *= factOf;
            factOf--;
        }
        return result;
    }
    public int nPr(int n, int r)
    {
        var result = 1;
        while (n != r)
        {
            result *= n;
            n--;
        }
        return result;
    }
    private int nCr(int n, int r)
    {
        return nPr(n, n-r) / fact(r);
    }
}