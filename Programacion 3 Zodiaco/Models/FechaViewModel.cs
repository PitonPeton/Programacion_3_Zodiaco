using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Programacion_3_Zodiaco.Models
{
    public class FechaViewModel
    {
        [BindProperty, DataType(DataType.Date)]
        public DateTime datetime { get; set; }  
    }
}
