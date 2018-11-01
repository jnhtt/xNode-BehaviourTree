using System.Collections.Generic;
using UnityEngine;

namespace AI.BtGraph
{
    public class BtSequencer : Base.BtNode
    {
        [Input] BtKnobEmpty inputKnob;
        [Output] BtKnobEmpty outpuKnob;

        protected List<Base.BtNode> btNodeList;

        public BtSequencer() : base(BtNodeType.Sequencer)
        {
            btNodeList = new List<Base.BtNode>();
        }

        protected override void Init()
        {
            base.Init();

            btNodeList.Clear();
            Base.BtNode btNode = null;
            foreach (var port in Outputs) {
                if (port.IsConnected) {
                    btNode = port.Connection.node as Base.BtNode;
                    btNodeList.Add(btNode);
                }
            }
            // 降順:priorityの値が大きい順に実行.
            btNodeList.Sort((a, b) => b.Priority - a.Priority);
        }

        public override BtResult Exec(Data data)
        {
            foreach (var node in btNodeList) {
                if (node.Exec(data) == BtResult.Failure) {
                    return BtResult.Failure;
                }
            }
            return BtResult.Success;
        }
    }
}
