using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.BtGraph;
using XNodeEditor;

namespace XNodeEditor.AI
{
    [CustomNodeGraphEditor(typeof(BtGraph))]
    public class BtGraphEditor : NodeGraphEditor
    {

        /// <summary> 
        /// Overriding GetNodeMenuName lets you control if and how nodes are categorized.
        /// </summary>
        public override string GetNodeMenuName(System.Type type)
        {
            if (type.Namespace == "AI.BtGraph")
            {
                return base.GetNodeMenuName(type).Replace("AI/BtGraph/", "");
            }
            else return null;
        }
    }
}