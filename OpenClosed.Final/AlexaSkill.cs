namespace OpenClosed.Final;

public abstract class AlexaSkill : IAlexaSkill
{
    public abstract bool CanHandleRequest(string request);


    public abstract void HandleRequest(string request);

    protected string GetParameter(string request, string token, string defaultValue)
    {
        return request.ToLower().Split(' ').SkipWhile(w => w != token.ToLower()).Skip(1).FirstOrDefault() ??
               defaultValue;
    }
}