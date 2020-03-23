namespace DoctorsOffice.Models
{
  public class DoctorSpecialty
  {
    public int DoctorSpecialtyId { get; set; }
    public int DoctorId { get; set; }
    public int SpecialtyId { get; set; }
    public Doctor doctor { get; set; }
    public Specialty specialty { get; set; }
  }

}