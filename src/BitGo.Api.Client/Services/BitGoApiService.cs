using BitGo.Api.Client.Interfaces;
using BitGo.Api.Client.Options;
using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;
using Microsoft.Extensions.Options;
using BitGo.Api.Client.Models.Responses.PendingApproval;
using BitGo.Api.Client.Models.Requests.PendingApproval;

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

	public async Task<ApiResponse<IEnumerable<PendingApprovalModel>>> ListPendingApprovalsAsync(
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListPendingApprovalsAsync(token, cancellationToken);

	public async Task<ApiResponse<IEnumerable<PendingApprovalModel>>> ListPendingApprovalsAsync(
		string walletId,
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListPendingApprovalsAsync(walletId, token, cancellationToken);

	public async Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		string token,
		CancellationToken cancellationToken = default) =>
			await _bitGoApi.ListWalletsAsync(token, cancellationToken);

	public async Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
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
