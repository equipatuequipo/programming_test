using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
	[ApiController]
	[Route("/customers")]
	public class CustomerController : ControllerBase
	{
		private readonly DatabaseContext _dbContext;

		public CustomerController(DatabaseContext dbContext)
		{
			_dbContext = dbContext;
		}
	}
}
