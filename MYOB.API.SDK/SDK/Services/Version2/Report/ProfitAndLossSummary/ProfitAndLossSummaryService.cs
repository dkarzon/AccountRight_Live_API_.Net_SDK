﻿using MYOB.AccountRight.SDK.Communication;
using MYOB.AccountRight.SDK.Contracts.Version2.Report.ProfitAndLossSummary;
using MYOB.AccountRight.SDK.Contracts.Version2.Report.TaxCodeSummary;

namespace MYOB.AccountRight.SDK.Services
{
    /// <summary>
    /// A service that provide access to the <see cref="TaxCodeSummary"/> resource.
    /// </summary>
    public sealed class ProfitAndLossSummaryService : GetOnlyService<ProfitAndLossSummary>
    {
        /// <summary>
        /// Initialise a service that can fetch <see cref="TaxCodeSummary"/> information
        /// </summary>
        /// <param name="configuration">The configuration required to communicate with the API service</param>
        /// <param name="webRequestFactory">A custom implementation of the <see cref="WebRequestFactory"/>, if one is not supplied a default <see cref="WebRequestFactory"/> will be used.</param>
        /// <param name="keyService">An implementation of a service that will store/persist the OAuth tokens required to communicate with the cloud based API at http://api.myob.com/accountright </param>
        /// <param name="apiRequestHandlerFactory">A custom implementation of the <see cref="IApiRequestHandlerFactory"/>, if one is not supplied a default <see cref="ApiRequestHandlerFactory"/> will be used.</param>
        public ProfitAndLossSummaryService(IApiConfiguration configuration, IWebRequestFactory webRequestFactory = null, IOAuthKeyService keyService = null, IApiRequestHandlerFactory apiRequestHandlerFactory = null)
            : base(configuration, webRequestFactory, keyService, apiRequestHandlerFactory)
        {
        }

        /// <summary>
        /// The route to the service (after the company file identifier)
        /// </summary>
        public override string Route
        {
            get { return "Report/ProfitAndLossSummary"; }
        }
    }
}
