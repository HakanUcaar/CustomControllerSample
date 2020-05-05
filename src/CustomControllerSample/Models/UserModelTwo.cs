using CustomControllerSample.CustomControllers;
using CustomControllerSample.DynamicController;
using System;

namespace CustomControllerSample.Models
{
    [AutoController("/UserTwo/[action]", typeof(UserCustomController<>))]
    public class UserModelTwo
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
