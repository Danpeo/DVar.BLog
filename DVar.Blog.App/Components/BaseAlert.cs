using Microsoft.AspNetCore.Components;

namespace DVar.Blog.App.Components;

public class BaseAlert : ComponentBase
{
    [Parameter] [EditorRequired] public string Message { get; set; } = default!;
}