namespace Preparation
{
    class Root : Node
    {
        public Root(int value)
            : base(value, "Root") { }
        public override int GetDepth()
        {
            return 0;
        }
    }
}
