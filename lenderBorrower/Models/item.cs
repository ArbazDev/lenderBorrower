using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace lenderBorrower.Models
{
    public class item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        public string Item { get; set; }

    }
}
