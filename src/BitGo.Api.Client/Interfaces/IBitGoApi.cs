using RequestPendingApproval = BitGo.Api.Client.Models.Requests.PendingApproval;
using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponsePendingApproval = BitGo.Api.Client.Models.Responses.PendingApproval;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApi
{
	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.list
	/// </summary>
	[Get("/wallets")]
	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		[Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.listbycoin
	/// </summary>
	[Get("/{coin}/wallet")]
	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		string coin, [Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.getbyid
	/// </summary>
	[Get("/wallet/{walletId}")]
	Task<ApiResponse<ResponseWallet.WalletModel>> GetWalletAsync(
		string walletId, [Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.approval.get
	/// </summary>
	[Get("/pendingapprovals/{approvalId}")]
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> GetPendingApprovalAsync(
		string approvalId, [Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.approval.list
	/// </summary>
	[Get("/pendingApprovals")]
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalsListModel>> ListPendingApprovalsAsync(
		[Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.approval.list
	/// </summary>
	[Get("/pendingApprovals?walletId={walletId}")]
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalsListModel>> ListPendingApprovalsAsync(
		string walletId, [Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.pendingapprovals.count.list
	/// </summary>
	// TODO: Correct reponse type
	[Get("/pendingapprovals/count")]
	Task<ApiResponse<string>> GetPendingApprovalsCountAsync(
		[Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.approval.update
	/// </summary>
	[Put("/pendingapprovals/{approvalId}")]
	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> UpdatePendingApprovalAsync(
		string approvalId,
		[Body] RequestPendingApproval.UpdatePendingApprovalModel data,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.user.login
	/// </summary>
	[Post("/user/login")]
	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		[Body] RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
