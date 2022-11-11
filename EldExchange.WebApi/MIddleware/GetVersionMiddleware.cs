namespace EldExchange.WebApi.MIddleware;

public class GetVersionMiddleware
{
    private readonly RequestDelegate _next;

    public GetVersionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var version = System.Reflection.Assembly.GetEntryAssembly()?.GetName().Version;
        if (version != null)
        {
            var IbVersion = string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            context.Response.Headers.Add("Version", IbVersion);
        }
        await _next(context);
    }
}
