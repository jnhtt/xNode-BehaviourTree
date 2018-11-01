using UnityEngine;
using XNode;

namespace AI.BtGraph
{
    // fileName : 新規のBehaviourTreeのScriptableObjectのファイル名
    // menuName : メニューAssets/Create/AI/BtGraphを選択したらNewBTGraphを作成する
    [CreateAssetMenu(fileName = "NewBTGraph", menuName = "AI/BtGraph")]
    public class BtGraph : NodeGraph
    {
        // BtStartノードを取得.
        // BtStartノードは必ずあるものとする.
        public BtStart GetStartNode()
        {
            BtStart startNode = null;
            foreach (var node in nodes) {
                startNode = node as BtStart;
                if (startNode != null) {
                    return startNode;
                }
            }
            return null;
        }

        // DataにBtGraph内のノードでアクセスしたいデータを入れておく想定.
        public void Exec(Data data)
        {
            var startNode = GetStartNode();
            if (startNode != null) {
                startNode.Exec(data);
            }
        }
    }
}
