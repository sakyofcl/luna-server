using Microsoft.OpenApi.Models;
using System;

namespace LunaServer
{
    public class APIDocs
    {
        public static OpenApiInfo getDocsInfo()
        {
            return new OpenApiInfo
            {
                Version = "v1.0.0",
                Title = "Luna API Documentation",
                Description = "The Luna is a outpatient's tracking system is tracking the patient activity in the hospital since they are making an appointment. It’ll will track the all their activity, so it eliminate the patient waiting and reduced the paper works as well as its reduced crowd are waiting in hospital."
            };
        }
    }
}
