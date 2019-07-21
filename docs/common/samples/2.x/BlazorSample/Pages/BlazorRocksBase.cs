using Microsoft.AspNetCore.Blazor.Components;

public class BlazorRocksBase : BlazorComponent
{
    public string BlazorRocksText { get; set; } = "Blazor rocks the browser!";

    public string ReturnString(string text)
    {
        return text;
    }
}
