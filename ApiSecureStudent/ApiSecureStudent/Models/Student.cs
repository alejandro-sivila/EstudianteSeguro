namespace ApiSecureStudent.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Key]
        [Range(1, 9999)]
        public int StudentId { get; set; }//prop + tab +tap

        [StringLength(30)]
        [Required(ErrorMessage = "YOU MUST ENTER THE FIELD {0}")]
        public string LastName { get; set; }
        [StringLength(30, ErrorMessage = "THE FIELD {0} MUST CONTAIN BETWEN {2} AND {1} CHARACTERS", MinimumLength = 2)] //EL 1 ES PARA EL EL 30 EL 2  PARA LA SEGUNDA CONDICION Y EL 0 PARA, EN ESTE CASO EL "FIRST NAME""
        [Required(ErrorMessage = "YOU MUST ENTER THE FIELD {0}")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}