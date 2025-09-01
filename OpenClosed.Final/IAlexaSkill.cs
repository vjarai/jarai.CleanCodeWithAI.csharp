namespace OpenClosed.Final;

public interface IAlexaSkill
{
    bool CanHandleRequest(string request);
    void HandleRequest(string request);
}