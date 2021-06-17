using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SuccessAdd = "Successfuly Added";
        public static string SuccessDelete = "Successfuly Deleted";
        public static string SuccessUpdated = "Successfuly Updated";
        public static string SuccessList = "Successfuly Listed";
        public static string SuccesFind = "Successfuly Finded";
        public static string UserRegistered;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
        public static string AuthorizationDenied;
    }
}
