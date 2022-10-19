namespace PubLish.BuildingBlocks
{
    public interface IBusinessRule
    {
        bool IsBroken();
        string Message { get; }
    }
}