using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace RMDataManager.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = false,
                @default = "bearer gN6ALBFh_7erSa8N7C8zaX5bXOgH0VLgqOelHDqn8NBGT8p1HT0SEUdDuatFyvSJp1HlxowFqBM-2GD9TGxPEPYeobzBcu0wiIE-yE1fZLBoJ3H0iNahLbWPuKxZCYLsGKOFYryVXqsVD2Xppu9qYhrFVSUrTb41BAnbHjn8Xotwv5NOvu-W6npLl5DMWvJ1HsLXYB4djR4FODKQxrJyzIY7qrjMd6eh75rZLfzdduV1m0VJz78K2pBuOIxUilBEWfg_9No7GOYdRF0C6dCVIItkfp_lDbnI1Z9jyqIlWrAAZEXnbNGliVXxYhN75T0iDj4XSvzGurxCmeiPLXpi0RRkvVPBipf3wj5ftmJlJRTckn2aUl7ZEpd6LRfY6jBvSkXdsl-TRQfI1szdzQe9TZGhsQrSL5HQXKfbT1zXyUeWgFYDzvapewg8SmvTfm-Ql6Et-wLzdJCZ0TXUfInBTGslhkELm8gaZuxWsaI5L84wL-L7ksUABTVK1IGMzXho",
                type = "string"
            });
        }
    }
}