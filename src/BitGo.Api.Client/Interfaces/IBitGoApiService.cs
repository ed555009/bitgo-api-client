using RequestPendingApproval = BitGo.Api.Client.Models.Requests.PendingApprovals;
using RequestUser = BitGo.Api.Client.Models.Requests.Users;
using ResponsePendingApproval = BitGo.Api.Client.Models.Responses.PendingApprovals;
using ResponseUser = BitGo.Api.Client.Models.Responses.Users;
using RequestTransaction = BitGo.Api.Client.Models.Requests.Transactions;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallets;
using ResponseTransfer = BitGo.Api.Client.Models.Responses.Transfers;
using Refit;
using BitGo.Api.Client.Models.Responses.Transactions;

namespace BitGo.Api.Client.Interfaces;

/// <summary>
/// Provides access to the BitGo API endpoints.
/// </summary>
public interface IBitGoApiService
{
	// wallet

	/// <summary>
	/// Lists all wallets associated with the authenticated user.
	/// </summary>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>A list of wallets.</returns>
	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Lists wallets for a specific coin type.
	/// </summary>
	/// <param name="coin">The coin type (e.g., 'btc', 'eth').</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>A list of wallets for the specified coin.</returns>
	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		string coin, string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Retrieves the details of a specific wallet by its ID.
	/// </summary>
	/// <param name="walletId">The unique identifier of the wallet.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The wallet details.</returns>
	Task<ApiResponse<ResponseWallet.WalletModel>> GetWalletAsync(
		string walletId, string token, CancellationToken cancellationToken = default);

	// transaction

	/// <summary>
	/// Initiates a transaction for a specific coin and wallet.
	/// </summary>
	/// <param name="coin">The coin type (e.g., 'btc', 'eth').</param>
	/// <param name="walletId">The unique identifier of the wallet.</param>
	/// <param name="data">The transaction initiation data.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The response from the transaction initiation.</returns>
	Task<ApiResponse<InitiateTransactionModel>> InitiateTransactionAsync(
		string coin,
		string walletId,
		RequestTransaction.InitiateTransactionModel data,
		string token,
		CancellationToken cancellationToken = default);

	Task<ApiResponse<BuildTransactionModel>> BuildTransactionAsync(
		string coin,
		string walletId,
		RequestTransaction.BuildTransactionModel data,
		string token,
		CancellationToken cancellationToken = default);

	// pending approval

	/// <summary>
	/// Retrieves a specific pending approval by its ID.
	/// </summary>
	/// <param name="approvalId">The ID of the pending approval.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The pending approval details.</returns>
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> GetPendingApprovalAsync(
		string approvalId, string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Lists all pending approvals for the authenticated user.
	/// </summary>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>A list of pending approvals.</returns>
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalsListModel>> ListPendingApprovalsAsync(
		string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Lists pending approvals for a specific wallet.
	/// </summary>
	/// <param name="walletId">The ID of the wallet.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>A list of pending approvals for the specified wallet.</returns>
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalsListModel>> ListPendingApprovalsAsync(
		string walletId, string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Gets the count of pending approvals.
	/// </summary>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The number of pending approvals as a string.</returns>
	Task<ApiResponse<string>> GetPendingApprovalsCountAsync(
		string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// Updates the status of a pending approval.
	/// </summary>
	/// <param name="approvalId">The ID of the pending approval to update.</param>
	/// <param name="data">The update data containing the new status and any additional information.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The updated pending approval.</returns>
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> UpdatePendingApprovalAsync(
		string approvalId,
		RequestPendingApproval.UpdatePendingApprovalModel data,
		string token,
		CancellationToken cancellationToken = default);

	// transfer
	/// <summary>
	/// Retrieves the details of a specific transfer by its ID for a given coin and wallet.
	/// </summary>
	/// <param name="coin">The coin type (e.g., 'btc', 'eth').</param>
	/// <param name="walletId">The unique identifier of the wallet.</param>
	/// <param name="transferId">The unique identifier of the transfer.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The transfer details.</returns>
	Task<ApiResponse<ResponseTransfer.TransferModel>> GetTransferAsync(
		string coin,
		string walletId,
		string transferId,
		string token,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Lists transfers for a specific coin and wallet, optionally paginated by a previous transfer ID.
	/// </summary>
	/// <param name="coin">The coin type (e.g., 'btc', 'eth').</param>
	/// <param name="walletId">The unique identifier of the wallet.</param>
	/// <param name="token">The authentication token.</param>
	/// <param name="limit">The maximum number of transfers to return (default is 25).</param>
	/// <param name="prevId">The ID of the previous transfer for pagination (optional).</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>A list of transfers for the specified wallet and coin.</returns>
	Task<ApiResponse<ResponseTransfer.TransferListModel>> ListTransfersAsync(
		string coin,
		string walletId,
		string token,
		int limit = 25,
		string? prevId = null,
		CancellationToken cancellationToken = default);

	// user

	/// <summary>
	/// Authenticates a user and creates a session.
	/// </summary>
	/// <param name="data">The login credentials.</param>
	/// <param name="cancellationToken">A token to cancel the async operation.</param>
	/// <returns>The login response containing session information.</returns>
	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
