namespace Fina.Core.Requests;

public class CreateCategoryRequest : Request
{

}

public abstract class Request
{
    public string UserId { get; set; } = string.Empty;
}
