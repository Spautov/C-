using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class PointCurrencyExchange
    {
        [Key]
        public int Id { get; private set; } //Уникальный номер объекта
       // public int Unn { get; set; }
        public virtual Сoordinate Coordinates { get; set; } //координаты объекта
        public string Address { get; set; } //адрес объекта
        public virtual Bank Bank { get; set; } // банка к которому относится объект
        public string Name { get; set; } //наименование объекта
        public string TelephonNumber { get; set; } //номер телефона
        public DateTime OpenDate { get; set; } // дата открытия
        public string TimeOfWork { get; set; } //время работы
        public virtual Сashier Сashier { get; set; } // данные о кассире
        public virtual ICollection<Comment> Comments { get; set; } //отзывы
        public virtual ICollection<ServiceType> ServicesType { get; set; } // виды услуг
        public string AdditionalInfo { get; set; } // дополнительная информация


        public PointCurrencyExchange()
        {
            //Bank = new Bank();
            //Coordinates = new Сoordinate();
            OpenDate = new DateTime(1980, 1, 1);
            //Сashier = new Сashier();
            Comments = new BindingList<Comment>();
            ServicesType = new BindingList<ServiceType>();
        }
    }
}
