using System.Net;

namespace PeekStock.Responses;

public readonly struct ApiResponse<T>(T? data, HttpStatusCode status, IReadOnlyList<string> errors)
{
	public T? Data { get; } = data;
	public HttpStatusCode Status { get; } = status;
	public IReadOnlyList<string> Errors { get; } = errors;
}
