using System.Collections.Generic;
using System.Threading.Tasks;

namespace ViaCepDotNet
{
    public interface IViaCepClient
    {
        Task<ViaCepResult> QueryByAsync(string zipCode);
        Task<IEnumerable<ViaCepResult>> QueryByAsync(
            string stateInitials,
            string city,
            string street
        );
    }
}
