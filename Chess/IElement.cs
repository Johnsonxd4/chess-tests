namespace Chess {
    public interface IElement
    {
        bool Accept(IVisitor visitor);
    }
}