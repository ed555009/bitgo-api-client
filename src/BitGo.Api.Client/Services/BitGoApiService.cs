using BitGo.Api.Client.Interfaces;
using BitGo.Api.Client.Options;
using RequestUser = BitGo.Api.Client.Models.Requests.Users;
using ResponseUser = BitGo.Api.Client.Models.Responses.Users;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallets;
using Refit;
using Microsoft.Extensions.Options;
using BitGo.Api.Client.Models.Responses.PendingApprovals;
using BitGo.Api.Client.Models.Requests.PendingApprovals;
using BitGo.Api.Client.Models.Responses.Wallets;
using BitGo.Api.Client.Models.Responses.Transfers;
using RequestWallet = BitGo.Api.Client.Models.Requests.Wallets;

namespace BitGo.Api.Client.Services;

public class BitGoApiService(IBitGoApi bitGoApi, IOptionsMonitor<BitGoApiOptions> bitGoApiOptions) : IBitGoApiService
{
	private readonly IBitGoApi _bitGoApi = bitGoApi;
	private readonly BitGoApiOptions _bitGoApiOptions = bitGoApiOptions.CurrentValue;

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
		RequestWallet.InitiateTransactionModel data,
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
		string? prevId = null,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListTransfersAsync(coin, walletId, prevId ?? "", token, cancellationToken);

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

	public async Task<ApiResponse<PendingApprovalModel>> UpdatePendingApprovalAsync(
		string approvalId,
		UpdatePendingApprovalModel data,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.UpdatePendingApprovalAsync(approvalId, data, token, cancellationToken);
}
