﻿using CustomControllerSample.DynamicController;
using System;

namespace CustomControllerSample.Models
{
    [AutoController("/User/[action]")]
    public class UserModelOne 
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
