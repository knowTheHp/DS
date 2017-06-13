using System;

namespace BnBKnapsack {
    class KnapSackKnapSack {
        class Node:IComparable<Node> {
            double bound;
            public int CompareTo(Node other) {
                return (int)(other.bound-bound);
            }
        }
        static void Main(string[] args) {

        }
    }
}