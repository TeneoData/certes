﻿using System;
using System.Linq;

namespace Certes.Acme
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AcmeHttpResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcmeHttpResponse{T}"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="links">The links.</param>
        /// <param name="error">The error.</param>
        public AcmeHttpResponse(Uri location, T resource, ILookup<string, Uri> links, AcmeError error)
        {
            Location = location;
            Resource = resource;
            Links = links;
            Error = error;
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public Uri Location { get; }

        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <value>
        /// The resource.
        /// </value>
        public T Resource { get; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        public ILookup<string, Uri> Links { get; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public AcmeError Error { get; }
    }

}
