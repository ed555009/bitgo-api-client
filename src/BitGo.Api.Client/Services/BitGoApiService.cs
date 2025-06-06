using BitGo.Api.Client.Interfaces;
using RequestUser = BitGo.Api.Client.Models.Requests.Users;
using ResponseUser = BitGo.Api.Client.Models.Responses.Users;
using Refit;
using BitGo.Api.Client.Models.Responses.PendingApprovals;
using BitGo.Api.Client.Models.Requests.PendingApprovals;
using BitGo.Api.Client.Models.Responses.Wallets;
using BitGo.Api.Client.Models.Responses.Transfers;
using RequesTransaction = BitGo.Api.Client.Models.Requests.Transactions;
using BitGo.Api.Client.Models.Responses.Transactions;

namespace BitGo.Api.Client.Services;

public class BitGoApiService(IBitGoApi bitGoApi) : IBitGoApiService
{
	private readonly IBitGoApi _bitGoApi = bitGoApi;

	public async Task<ApiResponse<BuildTransactionModel>> BuildTransactionAsync(
		string coin,
		string walletId,
		RequesTransaction.BuildTransactionModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.BuildTransactionAsync(coin, walletId, data, token, cancellationToken);

	public async Task<ApiResponse<PendingApprovalModel>> GetPendingApprovalAsync(
		string approvalId,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.GetPendingApprovalAsync(approvalId, token, cancellationToken);

	public async Task<ApiResponse<string>> GetPendingApprovalsCountAsync(
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.GetPendingApprovalsCountAsync(token, cancellationToken);

	public async Task<ApiResponse<TransferModel>> GetTransferAsync(
		string coin,
		string walletId,
		string transferId,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.GetTransferAsync(coin, walletId, transferId, token, cancellationToken);

	public async Task<ApiResponse<WalletModel>> GetWalletAsync(
		string walletId,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.GetWalletAsync(walletId, token, cancellationToken);

	public async Task<ApiResponse<InitiateTransactionModel>> InitiateTransactionAsync(
		string coin,
		string walletId,
		RequesTransaction.InitiateTransactionModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.InitiateTransactionAsync(coin, walletId, data, token, cancellationToken);

	public async Task<ApiResponse<PendingApprovalsListModel>> ListPendingApprovalsAsync(
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListPendingApprovalsAsync(token, cancellationToken);

	public async Task<ApiResponse<PendingApprovalsListModel>> ListPendingApprovalsAsync(
		string walletId,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListPendingApprovalsAsync(walletId, token, cancellationToken);

	public async Task<ApiResponse<TransferListModel>> ListTransfersAsync(
		string coin,
		string walletId,
		string token,
		int limit = 25,
		string? prevId = null,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListTransfersAsync(coin, walletId, limit, prevId ?? "", token, cancellationToken);

	public async Task<ApiResponse<WalletListModel>> ListWalletsAsync(
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListWalletsAsync(token, cancellationToken);

	public async Task<ApiResponse<WalletListModel>> ListWalletsAsync(
		string coin,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListWalletsAsync(coin, token, cancellationToken);

	public async Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.LoginAsync(data, cancellationToken);

	public async Task<ApiResponse<TransferModel>> SendHalfSignedTransactionAsync(
		string coin,
		string walletId,
		RequesTransaction.SendHalfSignedTransactionModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.SendHalfSignedTransactionAsync(coin, walletId, data, token, cancellationToken);

	public async Task<ApiResponse<SendManyModel>> SendManyAsync(
		string coin,
		string walletId,
		RequesTransaction.SendManyModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.SendManyAsync(coin, walletId, data, token, cancellationToken);

	public async Task<ApiResponse<ResponseUser.UnlockModel>> UnlockAsync(
		RequestUser.UnlockModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.UnlockAsync(data, token, cancellationToken);

	public async Task<ApiResponse<PendingApprovalModel>> UpdatePendingApprovalAsync(
		string approvalId,
		UpdatePendingApprovalModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.UpdatePendingApprovalAsync(approvalId, data, token, cancellationToken);
}
