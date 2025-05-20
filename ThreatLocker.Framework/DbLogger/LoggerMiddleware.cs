#if NET6_0_OR_GREATER
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
#endif
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.DbLogger
{
#if NET6_0_OR_GREATER

    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private readonly IConfiguration _configuration;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger, IConfiguration configuration)
        {
            _next = next;
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<string> GetBodyString(HttpRequest request)
        {
            int maxBodyLength = 32768; // 2^15 chars
            string requestBody = string.Empty;
            string method = request.Method;
            bool attemptRead = false; 

            try
            {
                long bodyLength = request.Body.Position;
                attemptRead = request.Body.CanRead && (method == HttpMethods.Post || method == HttpMethods.Put);

                if (bodyLength > maxBodyLength)
                {
                    requestBody = "Request body exceeds maxiumum logging length.";
                }
                else if (attemptRead)
                {
                    request.Body.Position = 0;
                    using (HttpRequestStreamReader reader = new HttpRequestStreamReader(request.Body, Encoding.UTF8))
                    {
                        requestBody = await reader.ReadToEndAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                requestBody = $"Failed to read body.\n Error: {ex.ToSafeString()}";
            }
            finally
            {
                // Reset stream position, so next middleware can read it
                if (attemptRead)
                    request.Body.Position = 0;
            }

            return requestBody;
        }

        private async Task WriteResponseAsync(Guid loggerId, HttpContext context, Exception exception)
        {
            var response = new WebApiException(loggerId, context.Response.StatusCode, exception.Message);
            var json = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(json);
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string method = context.Request.Method;
            if (!context.Request.Body.CanSeek &&
                (method == HttpMethods.Post || method == HttpMethods.Put))
            {
                // We only do this if the stream isn't *already* seekable,
                // as EnableBuffering will create a new stream instance
                // each time it's called
                context.Request.EnableBuffering();
            }

            try
            {
                await _next(context);
            } 
            catch (UnauthorizedAccessException exception)
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                await WriteResponseAsync(loggerId, context, exception);
            } 
            catch (ValidationException exception)
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.ExpectationFailed;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                await WriteResponseAsync(loggerId, context, exception);

            } 
            catch (BadRequestException exception) 
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                await WriteResponseAsync(loggerId, context, exception);

            }
            catch (ForbiddenException exception)
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                await WriteResponseAsync(loggerId, context, exception);

            }
            catch (InformativeException exception)
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 418;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                await WriteResponseAsync(loggerId, context, exception);

            }
            catch (Exception exception)
            {
                var loggerId = Guid.NewGuid();

                if (!exception.Data.Contains("AppLoggerId"))
                {
                    exception.Data.Add("AppLoggerId", loggerId);
                }

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                string requestBody = await GetBodyString(context.Request);
                exception.Data.Add("Body", requestBody);

                _logger.LogError(exception, exception.Message);

                bool isMasterOrganization = (context.Items["IsLoggedIntoMaster"] != null) ? context.Items["IsLoggedIntoMaster"].ToSafeBool() : false;

                await WriteResponseAsync(loggerId, context, exception);
            }
        }
    }

    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }

#endif
}
