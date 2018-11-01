using UnityEngine;
using AI.BtGraph.Base;

namespace AI.BtGraph
{
    public class BtRandom : BtDecorator
    {
        public override bool Branch(Data data)
        {
            return Random.Range(0, 1) == 0;
        }
    }
}
