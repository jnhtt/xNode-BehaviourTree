using UnityEngine;
using AI.BtGraph.Base;

namespace AI.BtGraph
{
    public class BtApproach : BtAction
    {
        public override BtResult Exec(Data data)
        {
            Vector3 dir = data.goal.position - data.mover.position;
            data.mover.position += dir.normalized * 4f * Time.deltaTime;
            return BtResult.Success;
        }
    }
}
