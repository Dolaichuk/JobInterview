using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class JobInterviews
        {
            public const string GetAll = Base + "/jobInterviews";
            public const string Get = Base + "/jobInterviews{id}";
            public const string Create = Base + "/jobInterviews";
            public const string Update = Base + "/jobInterviews";
            public const string Delete = Base + "/jobInterviews{id}";
        }
    }
}