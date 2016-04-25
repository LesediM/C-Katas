using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Helpers
{
    public class DueDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return false;
        }
}
}