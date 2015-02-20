﻿using System;
using System.Security.Authentication;

namespace UniTimetable.Model.ImportExport.Login
{
    public class FailedLoginException : AuthenticationException
    {
        public string User { get; private set; }
        public FailedLoginException(string user, string messageOrCode, Exception innerException = null)
            : base(messageOrCode, innerException)
        {
            User = user;
        }
    }

    public class InvalidLoginHandleException : Exception
    {
        public InvalidLoginHandleException(bool import, string message)
            : base("Timetable could not be " + (import ? "imported" : "exported") + "as " + message + ".")
        {}
    }

    public class InvalidLoginFieldException : Exception
    {
        public LoginField LoginField { get; private set; }
        public InvalidLoginFieldException(LoginField field, string type)
            : base("LoginField \"" + field.Name + "\" cannot be used with type " + type + ".")
        {
            LoginField = field;
        }
    }
}
