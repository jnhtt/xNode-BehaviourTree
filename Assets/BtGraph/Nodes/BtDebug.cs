using UnityEngine;

namespace AI.BtGraph
{
    public class BtDebug : Base.BtNode
    {
        [Input] public BtKnobEmpty inputKnob;
        [Output] public BtKnobEmpty outputKnob;

        public string message;

        public BtDebug() : base(BtNodeType.Debug)
        {}

        public override BtResult Exec(Data data)
        {
            UnityEngine.Debug.Log(message);
            var next = GetNext();
            if (next != null)
            {
                return next.Exec(data);
            }
            return BtResult.Success;
        }
    }
}
