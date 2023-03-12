using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Models
{
    public class TransactionModel
    {
        public int? Id { get; set; }
        [Display(Name = "Data da Transação")]
        public DateTime DateTransaction { get; set; }
        [Display(Name = "Valor")]
        public Decimal Value { get; set; }
        public String? History { get; set; }
        public int AccountPlanId { get; set; }
        public String AccountPlanType {get; set;}
        public AccountPlanModel AccountPlanTransaction { get; set; }
        public IEnumerable<SelectListItem>? AccountPlans { get; set; }
    }
}