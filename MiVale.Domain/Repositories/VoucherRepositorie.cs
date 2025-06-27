
using MiVale.Domain.Entities;

namespace MiVale.Domain.Repositories
{
    public interface VoucherRepositorie
    {
        Task CreateVoucher(Voucher voucher);

        Task UpdateVoucher(Voucher voucher);

        Task DeleteVoucher(Voucher voucher);

        Task<Voucher> GetVoucherById(int voucherId);

        Task<List<Voucher>> GetAllVouchers();

    }
}
