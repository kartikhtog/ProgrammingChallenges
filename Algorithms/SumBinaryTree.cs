using System;
using System.Collections.Generic;


namespace Algorithms
{
    public class SumBinaryTree
    {

        List<int> list = new List<int>();
        int Sum;
        public int SumRootToLeaf(TreeNode root)
        {
            Travese(root);

            // Tervese Tree from left to right
            // keep track on binary numbers
            // when you hit a leaf
            // convert binary into number and add to tree

            return Sum;
        }
        private void Travese(TreeNode node)
        {
            list.Add(node.val);
            if (node.left != null)
            {
                Travese(node.left);
            }
            if (node.right != null)
            {
                Travese(node.right);
            }
            if (IsLeaf(node))
            {
                Sum += ConvertToNumber(list);
            }
            list.RemoveAt(list.Count - 1);
        }
        public int ConvertToNumber(List<int> binary)
        {
            var number = 0;
            for (int i = binary.Count - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                {
                    number += (int)Math.Pow(2, binary.Count - 1 - i);
                }
            }
            return number;
        }
        public bool IsLeaf(TreeNode treeNode)
        {
            if (treeNode.left == null && treeNode.right == null)
            {
                return true;
            }
            return false;
        }
    }
    /*var betterSynonyms = new List<List<string>>();
    for(int i = 0; i < synonyms.Count; i++)
    {
        var currentSynonyms = new List<String>();
        currentSynonyms.Add(synonyms[i][0]);
        currentSynonyms.Add(synonyms[i][1]);
        for(int j = i + 1; j < synonyms.Count; j++)
        {
            var currentSynonymsLength = currentSynonyms.Count;
            for(int k = 0; k < currentSynonymsLength; k++)
            {
                if (currentSynonyms[k] == synonyms[j][0])
                {
                    currentSynonyms.Add(synonyms[j][1]);
                    synonyms.RemoveAt(j);
                    j--;

                }
                else if (currentSynonyms[k] == synonyms[j][1])
                {
                    currentSynonyms.Add(synonyms[j][0]);
                    synonyms.RemoveAt(j);
                    j--;

                }
            }
        }
        betterSynonyms.Add(currentSynonyms);
    }*/
    /*                            newSentences.AddRange(sentences.SelectMany(x => 
                            {
                                var newList = new List<string>();
                                foreach (var replaceWord in synonymWords)
                                {
                                    newList.Add();
                                }
                                return newList;
                            }).ToList());
*/
}
