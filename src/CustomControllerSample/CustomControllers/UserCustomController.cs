using CustomControllerSample.DynamicController;
using Microsoft.AspNetCore.Mvc;

namespace CustomControllerSample.CustomControllers
{
    public class UserCustomController<T> : AutoGenericBaseController<T> where T : class
    {
        [HttpGet]
        public string GetTestAction()
        {
            return "Test Method Başarılı";
        }
    }
}
