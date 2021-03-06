using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HelloHttpFunction
{
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logic for your function goes here.
        /// </summary>
        /// <param name="context">The HTTP context, containing the request and the response.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsync("Hello, Functions Framework.");
        }
    }
}

/*
 * gcloud functions deploy hello-http-function --runtime=dotnet3 --trigger-http --entry-point HelloHttpFunction.Function --allow-unauthenticated
 */