using Borium.Application.Epoch.Query;
using Borium.Webhost.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Borium.Webhost.Controllers {
    /// <summary>
    /// Controller for Epoch specific Endpoits.
    /// </summary>
    [ApiController]
    [Route ("api/epoch")]
    public class EpochController : BoriumBaseController {
        private readonly ApiExecutor _apiExecutor;

        /// <summary>
        /// Initializes new instance of EpochController.
        /// </summary>
        /// <param name="apiExecutor">Dispatcher for Queries and Commands</param>
        public EpochController (ApiExecutor apiExecutor) {
            _apiExecutor = apiExecutor;
        }

        /// <summary>
        /// Endpoint that returns all Epoches.
        /// </summary>
        /// <returns>Epoches Collection.</returns>
        [HttpGet]
        public IActionResult GetEpochList () {
            var epoches = _apiExecutor.Dispatch (new GetEpochListQuery ());
            return HandleQueryResult (epoches);
        }
    }
}