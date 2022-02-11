namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class RegisterViewModel
    {

        public ContactValidViewModel Contact { get; set; }

        public AreasValidViewModel Areas { get; set; }

        public AddressValidViewModel Address { get; set; }

        public PasswordValidViewModel Password { get; set; }

    }
}
