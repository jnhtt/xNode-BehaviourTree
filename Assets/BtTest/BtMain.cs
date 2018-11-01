using UnityEngine;

public class Data
{
    public Goal goal;
    public Mover mover;
}

public class BtMain : MonoBehaviour
{
    public Goal goal;
    public Mover mover;

    private Data data;

    private void Start()
    {
        data = new Data();
        data.goal = goal;
        data.mover = mover;

        mover.Init(data);
    }
}
