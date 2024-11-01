using System.ComponentModel.DataAnnotations.Schema;

namespace My_Portfolio.Model
{
    public class SubmitionForm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
