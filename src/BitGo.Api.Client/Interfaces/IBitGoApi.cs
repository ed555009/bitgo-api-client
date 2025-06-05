using RequestPendingApproval = BitGo.Api.Client.Models.Requests.PendingApprovals;
using ResponsePendingApproval = BitGo.Api.Client.Models.Responses.PendingApprovals;
using ResponseTransfer = BitGo.Api.Client.Models.Responses.Transfers;
using RequestUser = BitGo.Api.Client.Models.Requests.Users;
using ResponseUser = BitGo.Api.Client.Models.Responses.Users;
using RequestTransaction = BitGo.Api.Client.Models.Requests.Transactions;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallets;
using Refit;
using BitGo.Api.Client.Models.Responses.Transactions;
using BitGo.Api.Client.Models.Responses.Transfers;

namespace BitGo.Api.Client.Interfaces;

[Headers("User-Agent: BitGo.Api.Client", "Accept: application/json", "Content-Type: application/json")]
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
	[Get("/wallet/{walletId}?allTokens=true&expandAdvancedWhitelist=true")]
	Task<ApiResponse<ResponseWallet.WalletModel>> GetWalletAsync(
		string walletId, [Authorize("Bearer")] string token, CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.tx.initiate
	/// </summary>
	[Post("/{coin}/wallet/{walletId}/tx/initiate")]
	Task<ApiResponse<InitiateTransactionModel>> InitiateTransactionAsync(
			string coin,
			string walletId,
			[Body] RequestTransaction.InitiateTransactionModel data,
			[Authorize("Bearer")] string token,
			CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.tx.build
	/// </summary>
	[Post("/{coin}/wallet/{walletId}/tx/build")]
	Task<ApiResponse<BuildTransactionModel>> BuildTransactionAsync(
		string coin,
		string walletId,
		[Body] RequestTransaction.BuildTransactionModel data,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.tx.send
	/// </summary>
	[Post("/{coin}/wallet/{walletId}/tx/send")]
	Task<ApiResponse<TransferModel>> SendHalfSignedTransactionAsync(
		string coin,
		string walletId,
		[Body] RequestTransaction.SendHalfSignedTransactionModel data,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);

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
	/// https://developers.bitgo.com/api/v2.wallet.gettransfer
	/// </summary>
	[Get("/{coin}/wallet/{walletId}/transfer/{transferId}")]
	Task<ApiResponse<ResponseTransfer.TransferModel>> GetTransferAsync(
		string coin,
		string walletId,
		string transferId,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.wallet.listtransfers
	/// </summary>
	[Get("/{coin}/wallet/{walletId}/transfer?allTokens=true&limit={limit}&prevId={prevId}")]
	Task<ApiResponse<ResponseTransfer.TransferListModel>> ListTransfersAsync(
		string coin,
		string walletId,
		int limit,
		string prevId,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/v2.user.login
	/// </summary>
	[Post("/user/login")]
	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		[Body] RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// https://developers.bitgo.com/api/user.unlock
	/// </summary>
	[Post("/user/unlock")]
	Task<ApiResponse<ResponseUser.UnlockModel>> UnlockAsync(
		[Body] RequestUser.UnlockModel data,
		[Authorize("Bearer")] string token,
		CancellationToken cancellationToken = default);
}
