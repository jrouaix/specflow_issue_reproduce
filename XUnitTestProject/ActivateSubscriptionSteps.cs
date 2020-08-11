
using Newtonsoft.Json;
using NFluent;
using NSubstitute;
using System;
using System.Net;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace XUnitTestProject
{
    [Binding]
    public class ActivateSubscriptionSteps : BaseSubscriptionSteps
    {
      
        public ActivateSubscriptionSteps(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        { }

        [Given(@"requests body ""(.*)"" valid"), Scope(Feature = "ActivateSubscription")]
        public void GivenRequestsBodyIsValid(GivenIsOrIsNot givenIsOrIsNot)
        {
     
        }

        [Given(@"subscription ""(.*)"" exists"), Scope(Feature = "ActivateSubscription")]
        public void GivenSubscriptionDoesNotAlreadyExists(GivenIsOrIsNot givenIsOrIsNot)
        {

        }

        [When(@"activate Subscription is called"), Scope(Feature = "ActivateSubscription")]
        public void WhenActivateSubscriptionIsCalled()
        {
        }

        [Then(@"the REST API HTTP status must be (.*)"), Scope(Feature = "ActivateSubscription")]
        public void ThenTheRESTAPIHTTPStatusMustBe(HttpStatusCode httpStatusCode)
        {
        }

        [Then(@"the actor ""(.*)"" called"), Scope(Feature = "ActivateSubscription")]
        public void ThenTheActorHasBeenCalled(GivenIsOrIsNot givenIsOrIsNot)
        {
        }
    }
}
