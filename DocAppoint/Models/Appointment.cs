using System.ComponentModel.DataAnnotations;

namespace DocAppoint.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient name is required")]
        [StringLength(100)]
        public string PatientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string PatientEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone is required")]
        [Phone]
        [StringLength(15)]
        public string PatientPhone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select disease")]
        public string Disease { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select doctor")]
        public string DoctorName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; } = DateTime.Now;

    }
}