using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace JsonToForm.Extensions
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            this.maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;

            if (file != null)
            {
                if (file.Length > maxFileSize)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Максимальный размер зугружаемого файла {maxFileSize} байт.";
        }
    }
}
