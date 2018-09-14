using System;

namespace _3PL.Net
{
    internal class Constants
    {
        public const string BaseUrl = "https://secure-wms.com";
        public const string ContentType_HAL_JSON= @"application/hal+json; charset=utf-8";
        public const string Accept_HAL_JSON = @"application/hal+json";
        public const string AuthorizationBearer = "Bearer {0}";
        public const string Accept_Encoding = "gzip,deflate,sdch";
        public const string Accept_Language = "en-US,en;q=0.8";
        public const string NoCache = "no-cache";
        public const string MissingAccessTokenMessage = "AccessToken should be provided from calling code for each request. Consider caching the token from authenticate request";
        public const string MissingCustomerIdMessage = "Invalid or Missing CustomerId argument";
        public const string MissingItemIdMessage = "Invalid or Missing ItemId argument";
        public const string MissingFacilityIdMessage = "Invalid or Missing Facility argument";
        public const string MissingOrderIdMessage = "Invalid or Missing OrderId argument";
        public const string ErroCodeInvalid = "Invalid";
        public const string ErrorCode = "ErrorCode";
        public const string ValueNotSupported = "ValueNotSupported";
    }
}
