
using MiVale.Domain.Entities;

namespace MiVale.Domain.Repositories
{
    public interface LoanRepositorie
    {
        Task CreateLoan(Loan loan);

        Task UpdateLoan(Loan loan);

        Task DeleteLoan(int loanId);

        Task<Loan> GetLoanById(int loanId);

        Task<List<Loan>> GetLoans();

    }

}
