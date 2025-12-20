[System.Serializable]
public class QuaVersionException : System.Exception
{
    public QuaVersionException() { }
    public QuaVersionException(string message) : base(message) { }
    public QuaVersionException(string message, System.Exception inner) : base(message, inner) { }
}