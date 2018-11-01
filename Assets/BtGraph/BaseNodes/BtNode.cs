using System;
using XNode;

namespace AI.BtGraph.Base
{
    [Serializable]
    public class BtNode : Node
    {
        public int Priority;

        public BtNodeType NodeType { get; protected set; }

        public BtNode(BtNodeType nodeType)
        {
            NodeType = nodeType;
        }

        public virtual BtResult Exec(Data data)
        {
            return BtResult.Success;
        }

        public virtual BtNode GetNext()
        {
            var port = GetOutputPort("outputKnob");
            BtNode next = null;
            if (port != null && port.IsConnected) {
                next = port.Connection.node as BtNode;
            }
            return next;
        }

        public virtual void Setup()
        { }
    }
}