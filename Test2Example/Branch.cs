namespace Preparation
{
    class Branch : Node
    {
        public Node Parent { get; set; }
        public Branch(int value, Node parent)
            : base(value, "Branch")
        { Parent = parent; }
        public override void Add(int value)
        {
            base.Add(value);
            Parent.Add(value);
        }
        public override int GetDepth()
        {
            return 1 + Parent.GetDepth();
        }
    }
}
