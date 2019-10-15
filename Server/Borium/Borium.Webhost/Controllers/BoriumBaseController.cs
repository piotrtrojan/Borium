using System.Collections;
using Borium.Application.Utils;
using Microsoft.AspNetCore.Mvc;
namespace Borium.Webhost.Controllers {

    /// <summary>
    /// Abstract Controller for whole Borium Webhost. Contains methods that converts QueryResult and CommandResult to ActionResult.
    /// </summary>
    public abstract class BoriumBaseController : Controller {
        
        /// <summary>
        /// Returns BadRequest ActionResult (400)
        /// </summary>
        /// <param name="error">error details, e.g. invalid parameters</param>
        /// <returns></returns>
        protected IActionResult Error (string error) => BadRequest (error);

        /// <summary>
        /// Converts CommandResult to ActionResult response.
        /// </summary>
        /// <param name="result">Command Result object.</param>
        /// <returns>NoContent(204) when command is successful, Error->BadRequest(400) when invalid.</returns>
        protected IActionResult HandleCommandResult (CommandResult result) => result.IsSuccess ? NoContent () : Error (result.Error);

        /// <summary>
        /// Converts QueryResult to ActionResult response.
        /// </summary>
        /// <param name="result">QueryResult object</param>
        /// <typeparam name="T">QueryResult content type</typeparam>
        /// <returns>Not found - when result is empty, Ok - when result is filled.</returns>
        protected IActionResult HandleQueryResult<T> (T result) {
            if (typeof (T) is ICollection)
                return HandleQueryCollectionResult (result);
            return HandleQueryElementResult (result);
        }

        /// <summary>
        /// Returns Ok response from given result.
        /// </summary>
        /// <param name="result">Result object</param>
        /// <typeparam name="T">Result type, should be collection</typeparam>
        /// <returns></returns>
        private IActionResult HandleQueryCollectionResult<T> (T result) {
            return Ok (result);
        }

        private IActionResult HandleQueryElementResult<T> (T result) {
            if (result == null)
                return NotFound ();
            return Ok (result);
        }
    }
}