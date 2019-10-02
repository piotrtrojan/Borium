using Borium.Application.Epoch.Query;
using Borium.Webhost.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Borium.Webhost.Controllers
{
    [ApiController]
    [Route("api/epoch")]
    public class EpochController : BoriumBaseController
    {
        private readonly ApiExecutor _apiExecutor;

        public EpochController(ApiExecutor apiExecutor)
        {
            _apiExecutor = apiExecutor;
        }

        [HttpGet]
        public IActionResult GetEpochList()
        {
            var epoches = _apiExecutor.Dispatch(new GetEpochListQuery());
            return HandleQueryResult(epoches);
        }
    }
}