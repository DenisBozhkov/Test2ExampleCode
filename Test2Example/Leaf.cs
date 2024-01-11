namespace Preparation
{
    class Leaf : Branch
    {
        public Leaf(int value, Node parent)
            : base(value, parent)
        { Type = "Leaf"; }
    }
}
