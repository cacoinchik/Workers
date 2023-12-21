using System.ComponentModel.DataAnnotations;

namespace Workers.ViewModels
{
    public class ChildAddViewModel
    {
        public int WorkerId { get; set; }

        [Required(ErrorMessage = "Введите ФИО ребенка")]
        public string FIO { get; set; }

        [Required(ErrorMessage = "Введите возраст ребенка")]
        public byte Age { get; set; }
    }
}
