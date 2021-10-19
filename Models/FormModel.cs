using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class FormModel
    {
        [Required]
        [Display(Name = "Imię")]

        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]

        public System.DateTime Birthday { get; set; }

        [Display(Name = "Liczba dni od daty urodzenia")]
        public int DaysSinceBirthday {
            get => System.Math.Abs((System.DateTime.Today.Date - Birthday.Date).Days);
        }

        [Display(Name = "Czy rok urodzenia był rokiem przestępnym?")]
        public bool IsLeapYear { get => System.DateTime.IsLeapYear(Birthday.Year); }
        static string GetBooleanValue(bool boolean) => boolean ? "Tak" : "Nie";
    }
}