using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PeekStock.Responses;

public static class DefaultResponses
{
	public static IActionResult Success<T>(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
	{
		var response = new ApiResponse<T>(data, statusCode, []);
		return new ObjectResult(response) { StatusCode = (int)statusCode };
	}

	public static IActionResult Failure<T>(IReadOnlyList<string> errors, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
	{
		var response = new ApiResponse<T>(default, statusCode, errors);
		return new ObjectResult(response) { StatusCode = (int)statusCode };
	}

	public static IActionResult Failure<T>(string error, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
	{
		return Failure<T>([error], statusCode);
	}
}
