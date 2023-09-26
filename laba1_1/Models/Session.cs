using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace laba1_1.Models
{
    public class Session
    {
        [Key]
        public int Session_ID { get; set; }

        [Display(Name = "Время сессии")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime Date_Session { get; set; }
        [Display(Name = "Формат")]
        public Format Format_Session { get; set; }
        [Display(Name = "Психолог")]
        public int Psychologist_objId { get; set; }

        [Display(Name = "Клиент")]
        public int ClientID { get; set; }

        [Display(Name = "Статус")]
        public Status Status_Session { get; set; }
        [Display(Name = "Отзыв")]
        public string? Feedback { get; set; }

    }


    public enum Format
    {
        [Display(Name = "Онлайн")]
        Online,
        [Display(Name = "Лично")]
        Offline
    }
    public enum Status
    {
        [Display(Name = "Ожидается")]
        Wait,
        [Display(Name = "Отменена")]
        Cancelled,
        [Display(Name = "Завершена")]
        [Description("Завершена")]
        Completed
    }
  
}

