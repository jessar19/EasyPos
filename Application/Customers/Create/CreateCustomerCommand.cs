using System;
using MediatR;

namespace Application.Customers.Create
{
	public record CreateCustomerCommand(
		string Name,
		string LasName,
		string Email,
		string PhoneNumber,
		string Country,
		string Line1,
		string Line2,
		string City,
		string State,
		string ZipCode
	) : IRequest<Unit>;
}

