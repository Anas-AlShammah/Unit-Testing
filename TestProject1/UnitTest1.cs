using ConsoleApp2;
using System.Xml.Serialization;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void ViewBlanceTest()
        {
            
            Assert.Equal(Atm.balance, Atm.ViewBlance());
        }
        [Theory]    
        [InlineData(50)]
        [InlineData(500)]
        [InlineData(-50)]
        public void WithDrawTest(decimal m)
        {
           
            Assert.Equal(Atm.balance-m, Atm.WithDraw(m));
            

        }

        [Theory]
        [InlineData(50)]
        [InlineData(250)]
        [InlineData(-50)]
        public void DepositTest(decimal m)
        {
            Assert.Equal(Atm.balance + m, Atm.Deposit(m));
        }

       
    }
}