﻿using System.Collections.Generic;

namespace LoginRadiusSDK.V2.Models
{
    public class ApiExceptionResponse
    {
        /// <summary>
        /// Deatiled error description. 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// LoginRadius API error code.
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Determines whether the error is of social provider. 
        /// </summary>
        public bool? IsProviderError { get; set; }

        /// <summary>
        /// Determines social provider error response.
        /// </summary>
        public string ProviderErrorResponse { get; set; }

        /// <summary>
        /// Represents errors that occurred during the server validation of request payload. 
        /// </summary>
        public List<ValidationErrors> Errors { get; set; }
    }

    public class ApiExceptionResponse<T> : ApiExceptionResponse
    {
        public T Data { get; set; }
    }
}