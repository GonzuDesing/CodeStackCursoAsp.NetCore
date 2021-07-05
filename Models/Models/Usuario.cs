using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Models
{

    public class Usuario
    {

        //no usa mascara sino se ocupoa otra bibloioteca --no entendi bn esto
        //Genera el jqury sin tener que hacerlo a mano

        //Quiere decir que ese acmpo es requerido
        [Required(ErrorMessage = "Escriba su nombre.")]
        //Tamaño minimo
        [MinLength(4, ErrorMessage = "Ecriba al menos 5 caracteres.")]
        //Tamaño Maximo
        [MaxLength(50, ErrorMessage = "Escriba un maximo de 50 caracteres.")]


        public string Nombres { get; set; }
        //Quiere decir que ese acmpo es requerido
        [Required(ErrorMessage = "Escriba su apellido.")]
        //Tamaño minimo
        [MinLength(4, ErrorMessage = "Ecriba al menos 5 caracteres.")]
        //Tamaño Maximo
        [MaxLength(50, ErrorMessage = "Escriba un maximo de 50 caracteres.")]

        public string Apellidos { get; set; }


        //Quiere decir que ese acmpo es requerido
        [Required(ErrorMessage = "Escriba su dui.")]
        //Expreciones regulares cualquir numero de 0 a 9 {9} veces despues un - luego
        // un numero de 0 a 9 y va solo {1} vez formato dui
        [RegularExpression("^[0-9]{9}-[0-9]{1}$", ErrorMessage = "Escriba un Dui Valido")]

        public string Dui { get; set; }

        //Quiere decir que ese acmpo es requerido
        [Required(ErrorMessage = "Escriba su Correo.")]
        //Tiene que ser un correo obligatoriamente
        [EmailAddress(ErrorMessage ="Escriba un correo valido.")]

        public string Correo { get; set; }




        public bool EstaActivo { get; set; }

        [Required(ErrorMessage ="Escriba su fecha de nacimineto")]
        //el data type solo se usa para tipos de datos especiales.
        [DataType(DataType.Date)]


        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage ="Escriba su edad")]
        //Q se valide un rango de edad
        [Range(18,120, ErrorMessage ="El registro es solo para personas mayores de 18 años. ")]

        public int Edad { get; set; }


    }
}