using UnityEngine;
using AI.BtGraph;

public class Mover : BaseMover
{
    [SerializeField]
    private BtGraph btGraph;
    private Data data;

    public void Init(Data data)
    {
        this.data = data;
    }

    private void Update()
    {
        if (btGraph != null && data != null) {
            btGraph.Exec(data);
        }
    }
}
