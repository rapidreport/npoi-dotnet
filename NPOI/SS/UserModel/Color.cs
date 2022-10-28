namespace jp.co.systembase.NPOI.SS.UserModel
{
    public interface IColor
    {
        short Indexed { get; }
        byte[] RGB { get; }
    }
}
