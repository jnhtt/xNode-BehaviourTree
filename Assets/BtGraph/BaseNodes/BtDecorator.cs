using UnityEngine;

namespace AI.BtGraph.Base
{
    public class BtDecorator : Base.BtNode
    {
        //前への接続.
        [Input] public BtKnobEmpty inputKnob;
        //次への接続.
        [Output] public BtKnobEmpty outputKnob;

        public BtDecorator() : base(BtNodeType.Decorator)
        { }

        public override BtResult Exec(Data data)
        {
            if (Branch(data)) {
                Base.BtNode btNode = GetNext();
                if (btNode != null) {
                    return btNode.Exec(data);
                }
                return BtResult.Success;
            }
            return BtResult.Failure;
        }

        public virtual bool Branch(Data data)
        {
            return true;
        }
    }
}
