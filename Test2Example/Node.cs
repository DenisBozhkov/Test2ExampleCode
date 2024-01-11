namespace Preparation
{
    abstract class Node
    {
        public int Value { get; set; }
        public string Type { get; set; }
        public Node(int value, string type)
        {
            Value = value;
            Type = type;
        }
        public virtual void Add(int value)
        {
            Value += value;
        }
        public abstract int GetDepth();
        public override string ToString()
        {
            return string.Format("{0} -> Depth: {1}; Value: {2}", Type, GetDepth(), Value);
        }
    }
}
