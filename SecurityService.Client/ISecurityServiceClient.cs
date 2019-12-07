﻿namespace SecurityService.Client
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using DataTransferObjects;
    using DataTransferObjects.Requests;
    using DataTransferObjects.Responses;

    /// <summary>
    /// 
    /// </summary>
    public interface ISecurityServiceClient
    {
        #region Methods

        /// <summary>
        /// Creates the API resource.
        /// </summary>
        /// <param name="createApiResourceRequest">The create API resource request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<CreateApiResourceResponse> CreateApiResource(CreateApiResourceRequest createApiResourceRequest,
                                                          CancellationToken cancellationToken);

        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <param name="createClientRequest">The create client request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<CreateClientResponse> CreateClient(CreateClientRequest createClientRequest,
                                                CancellationToken cancellationToken);

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="createUserRequest">The create user request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<CreateUserResponse> CreateUser(CreateUserRequest createUserRequest,
                                            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the API resource.
        /// </summary>
        /// <param name="apiResourceName">Name of the API resource.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<ApiResourceDetails> GetApiResource(String apiResourceName,
                                                CancellationToken cancellationToken);

        /// <summary>
        /// Gets the API resources.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<List<ApiResourceDetails>> GetApiResources(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<ClientDetails> GetClient(String clientId,
                                      CancellationToken cancellationToken);

        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<List<ClientDetails>> GetClients(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<TokenResponse> GetToken(String username,
                                     String password,
                                     String clientId,
                                     String clientSecret,
                                     CancellationToken cancellationToken);

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<TokenResponse> GetToken(String clientId,
                                     String clientSecret,
                                     CancellationToken cancellationToken);

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<TokenResponse> GetToken(String clientId,
                                     String clientSecret,
                                     String refreshToken,
                                     CancellationToken cancellationToken);

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<UserDetails> GetUser(Guid userId,
                                  CancellationToken cancellationToken);

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<List<UserDetails>> GetUsers(String userName,
                                         CancellationToken cancellationToken);

        #endregion
    }
}