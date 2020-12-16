using MedicalRepresentativeSchedule.Controllers;
using MedicalRepresentativeSchedule.models;
using MedicalRepresentativeSchedule.Providers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRepresentativeScheduleTest
{
    class TestController
    {
        Mock<IRepScheduleProvider> schedulepro;
        List<Doctor> doctors;
        List<MedicineStock> stock;
        List<RepresentativeDetails> representatives;
        
        [SetUp]
        public void Setup()
        {
            schedulepro = new Mock<IRepScheduleProvider>();
        }

        [TestCase("2020/11/12")]
        public void TestControllerLayerCorrectInput(DateTime startdate)
        {
            schedulepro.Setup(m => m.GetRepScheduleAsync(It.IsAny<DateTime>())).Returns(Task.FromResult(new List<RepSchedule>(){ 
                new RepSchedule {
                RepName = "R1", DoctorName = "D1", DateOfMeeting = "12-12-2020", DoctorContactNumber = 9099687, Medicine = "Aspirin", MeetingSlot = "1-2pm", TreatingAilment = "General"
            }
                })); 
            var pro = new RepScheduleController(schedulepro.Object);
            var res = pro.Get(startdate).Result as ObjectResult;
            Assert.AreEqual(res.StatusCode,200);
        }
       


        [TestCase("2020/11/10")]
        [TestCase("2020/11/11")]
        public void ScheduleMeetingController_GetMeetingStartDate(DateTime startdate)
        {
            schedulepro.Setup(s => s.GetRepScheduleAsync(startdate)).Returns(Task.FromResult(new List<RepSchedule>()));
            var pro = new RepScheduleController(schedulepro.Object);
            ObjectResult data = pro.Get(startdate).Result as ObjectResult;
            Assert.AreEqual(404, data.StatusCode);


    }
}
