using UnityEngine;
using AI.BtGraph.Base;

namespace AI.BtGraph
{
    public class BtAround : BtAction
    {
        public enum Rot
        {
            Right = 0,
            Left,
        }
        public Rot rot;

        public override BtResult Exec(Data data)
        {
            float angle = rot == Rot.Right ? 30f : -30f;
            data.mover.CachedTransform.RotateAround(data.goal.CachedTransform.position, Vector3.up, angle * Time.deltaTime);
            return BtResult.Success;
        }
    }
}
