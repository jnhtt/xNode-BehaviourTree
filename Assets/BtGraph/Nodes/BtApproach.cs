using UnityEngine;
using AI.BtGraph.Base;

namespace AI.BtGraph
{
    public class BtApproach : BtAction
    {
        public override BtResult Exec(Data data)
        {
            Vector3 dir = data.goal.CachedTransform.position - data.mover.CachedTransform.position;
            data.mover.CachedTransform.position += dir.normalized * 4f * Time.deltaTime;
            return BtResult.Success;
        }
    }
}
