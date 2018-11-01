using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.BtGraph;

public class Data
{
    public Transform goal;
    public Transform mover;
}

public class BtMain : MonoBehaviour
{
    public Transform goal;
    public Transform target;
    public BtGraph graph;

    private Data data;

    private void Start()
    {
        data = new Data();
        data.goal = goal;
        data.mover = target;
    }

    private void Update()
    {
        try
        {
            graph.Exec(data);
        } catch (System.Exception e) {
            Debug.LogError(e);
        }
    }
}
