using UnityEngine;
using AI.BtGraph.Base;

namespace AI.BtGraph
{
    public class BtCheckDistance : BtDecorator
    {
        public enum Condition {
            Equal = 0,
            Less,
            LessEqual,
            Greater,
            GreaterEqual,
        }

        public Condition condition;
        public float distance;

        public override bool Branch(Data data)
        {
            float dist = Vector3.Distance(data.goal.CachedTransform.position, data.mover.CachedTransform.position);
            switch (condition) {
                case Condition.Equal:
                    return Mathf.Approximately(dist, distance);
                case Condition.Less:
                    return dist < distance;
                case Condition.LessEqual:
                    return dist <= distance;
                case Condition.Greater:
                    return dist > distance;
                case Condition.GreaterEqual:
                    return dist >= distance;
            }
            return false;
        }
    }
}
