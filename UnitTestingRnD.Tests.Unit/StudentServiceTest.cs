using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingRnD.Tests.Unit
{
    public class StudentServiceTest
    {
        [Fact]
        public void ShouldReturnFullNameByGettingFirstNameAndLastName()
        {
            //given

            var studentService = new StudentService();
            var randomFirstName = "Pasa5n";
            var randomLastName = "gunathilaka";
            var expectedFullName = "Pasan Gunathilaka";
            //when

            var actualFullName = studentService.CreateFullName(randomFirstName, randomLastName);

            // then

           // Assert.Equal(expectedFullName, actualFullName , ignoreCase: true , ignoreWhiteSpaceDifferences : true);
           Assert.Contains(randomFirstName, actualFullName);
          //Assert.Matches("[a-z] [a-z]", actualFullName); 


        }

    }
}
