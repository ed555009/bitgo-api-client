using RequestPendingApproval = BitGo.Api.Client.Models.Requests.PendingApproval;
using RequestUser = BitGo.Api.Client.Models.Requests.User;
using ResponsePendingApproval = BitGo.Api.Client.Models.Responses.PendingApproval;
using ResponseUser = BitGo.Api.Client.Models.Responses.User;
using ResponseWallet = BitGo.Api.Client.Models.Responses.Wallet;
using Refit;

namespace BitGo.Api.Client.Interfaces;

public interface IBitGoApiService
{
	// wallet

	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		CancellationToken cancellationToken = default);

	Task<ApiResponse<ResponseWallet.WalletListModel>> ListWalletsAsync(
		string coin, CancellationToken cancellationToken = default);

	// pending approval

	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> GetPendingApprovalAsync(
		string approvalId, CancellationToken cancellationToken = default);

	Task<ApiResponse<IEnumerable<ResponsePendingApproval.PendingApprovalModel>>> ListPendingApprovalsAsync(
		CancellationToken cancellationToken = default);

	Task<ApiResponse<IEnumerable<ResponsePendingApproval.PendingApprovalModel>>> ListPendingApprovalsAsync(
		string walletId, CancellationToken cancellationToken = default);

	Task<ApiResponse<string>> GetPendingApprovalsCountAsync(
		CancellationToken cancellationToken = default);

	Task<ApiResponse<ResponsePendingApproval.PendingApprovalModel>> UpdatePendingApprovalAsync(
		string approvalId,
		RequestPendingApproval.UpdatePendingApprovalModel data,
		CancellationToken cancellationToken = default);

	// user

	Task<ApiResponse<ResponseUser.LoginModel>> LoginAsync(
		RequestUser.LoginModel data,
		CancellationToken cancellationToken = default);
}
