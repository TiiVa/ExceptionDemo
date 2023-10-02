namespace ClassLib;

public class IdiotUserException : Exception
{
    public override string Message { get; } = "Don't be a fool!";
}