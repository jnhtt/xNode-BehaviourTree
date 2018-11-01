using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using AI.BtGraph;
using AI.BtGraph.Base;

namespace XNodeEditor.AI
{
    [CustomNodeEditor(typeof(BtNode))]
    public class BtNodeEditor : NodeEditor
    {

        public override void OnHeaderGUI()
        {
            GUI.color = Color.white;
            BtNode node = target as BtNode;
            BtGraph graph = node.graph as BtGraph;

            string title = target.name;
            GUILayout.Label(title, NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
            GUI.color = Color.white;
        }

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            BtNode node = target as BtNode;
            BtGraph graph = node.graph as BtGraph;
        }
    }
}