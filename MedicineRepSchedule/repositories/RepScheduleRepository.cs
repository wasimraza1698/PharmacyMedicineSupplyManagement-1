using MedicalRepresentativeSchedule.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRepresentativeSchedule.repositories 
{

    public class RepScheduleRepository : IRepScheduleRepository
    {
        private static List<Doctor> doctors;
        private static List<RepresentativeDetails> representatives;
        List<DoctorDTO> docDetails = new List<DoctorDTO>();
        List<RepresentativeDetailsDTO> repDetails = new List<RepresentativeDetailsDTO>();
        public RepScheduleRepository()
        {
            doctors = new List<Doctor>()
             {
               new Doctor { Name = "D1",ContactNumber=0987654321 , TreatingAilment="Orthopaedics"},
               new Doctor { Name = "D2",ContactNumber=0987654321 , TreatingAilment="General"},
               new Doctor { Name = "D3",ContactNumber=0987654321 , TreatingAilment="Gynecology"},
               new Doctor { Name = "D4",ContactNumber=0987654321 , TreatingAilment="Orthopaedics"},
               new Doctor { Name = "D5",ContactNumber=0987654321 , TreatingAilment="General"},
               new Doctor { Name = "D6",ContactNumber=0987654321 , TreatingAilment="Gynecology"},
             };

            representatives = new List<RepresentativeDetails>()
            {
                new RepresentativeDetails{RepresentativeName= "R1" },
                new RepresentativeDetails{RepresentativeName= "R2" },
                new RepresentativeDetails{RepresentativeName= "R3" }
            };


        }
        public List<DoctorDTO> GetDoctorDetails()
        {
            foreach (var i in doctors)
            {
                docDetails.Add(new DoctorDTO { Name = i.Name, ContactNumber = i.ContactNumber, TreatingAilment = i.TreatingAilment });
            }
            return docDetails;
        }
        public List<RepresentativeDetailsDTO> GetRepresentativesDetails()
        {
            foreach (var i in representatives)
            {
                repDetails.Add(new RepresentativeDetailsDTO { RepresentativeName = i.RepresentativeName });
            }
            return repDetails;
        }

    }
        
    
}
