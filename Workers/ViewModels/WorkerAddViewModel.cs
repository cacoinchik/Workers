using System.ComponentModel.DataAnnotations;

namespace Workers.ViewModels
{
    public class WorkerAddViewModel
    {
        [Required(ErrorMessage = "Введите фамилию")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Выберите пол")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Введите возраст")]
        public byte Age { get; set; }

        [Required(ErrorMessage = "Введите дату рождения")]
        public DateTime BirthdayDate { get; set; }

        [Required(ErrorMessage = "Выберите семейное положение")]
        public string FamilyStatus { get; set; }

        [Required(ErrorMessage = "Введите должность")]
        public string Post { get; set; }

        [Required(ErrorMessage = "Введите ученую степень")]
        public string Degree { get; set; }
    }
}
