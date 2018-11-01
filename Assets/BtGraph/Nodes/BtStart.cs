namespace AI.BtGraph
{
    public class BtStart : Base.BtNode
    {
        //次への接続.
        [Output(ShowBackingValue.Never, ConnectionType.Override)] public BtKnobEmpty outputKnob;

        public BtStart() : base(BtNodeType.Start)
        {}

        public override BtResult Exec(Data data)
        {
            var next = GetNext();
            if (next != null) {
                return next.Exec(data);
            }
            return BtResult.Failure;
        }
    }
}
