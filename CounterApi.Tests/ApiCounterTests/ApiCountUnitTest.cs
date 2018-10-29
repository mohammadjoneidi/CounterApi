using CounterApi.Services;
using Xunit;

namespace CounterApi.Tests
{
    public class CounterServiceTest
    {     
        private readonly CounterService _counterService;

        public CounterServiceTest()
        {
            _counterService = new CounterService();
        } 

        [Fact]
        public void ShouldBeAbleToRetrieveTheCounter()
        {
           var result =  _counterService.GetCounterValue();
           Assert.True(result ==0,"The resualt is not retrived");
        }
      
    }
}
