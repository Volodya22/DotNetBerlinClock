using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClock.Domain.Interfaces.Time;
using BerlinClock.Domain.Models.Time;
using BerlinClock.Domain.Models.Factory;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private ITimeConverter berlinClock;
        private string theTime;

        public TheBerlinClockSteps()
        {
            berlinClock = new TimeConverter(new TimeParser(), new ConverterFactory().Create());
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(berlinClock.ConvertTime(theTime), theExpectedBerlinClockOutput);
        }
    }
}
