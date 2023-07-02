namespace ASPHomeWork_1.Middlewares;

public class LoginCheck
{
    private RequestDelegate next;

    public LoginCheck(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("LOGIN CHECK MiddleWare Started");
        await next.Invoke(context);
        Console.WriteLine("LOGIN CHECK MiddleWare Ended");
    }
}
