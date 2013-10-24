moqingcucumber
==========================================

moqingcucumber is my attempt at providing gherkin-like syntax for use with Moq and XUnit.  

Installation
--------------------------------------------------
The recommened method for installing MoqingCucumber is to use the [Nuget package] (https://www.nuget.org/packages/MoqingCucumber/):

    Install-Package MoqingCucumber


Usage
--------------------------------------------------
Add the MoqingCucumber using directive to your test class

    using MoqingCucumber;
    
Then implement FactsFor<T> to set up the scenario you wish to test

    public class WhenUsingThisTestClass : FactsFor<SomeOtherClassIWantToTest>
    {
      public override void When(){}
      public override void Given()
      {
          Mock.Get(GetMock<IUserInput>()).Setup(x => x.GetInput(It.IsAny<string>())).Returns("Y");
      }
    }

You can now test all your 

        [Fact]
        public void ThenAutoGenerateColumns()
        {
            Target.GetColumns();
            Assert.Equal(true, Target.GridView.AutoGenerateColumns);
        }

        [Fact]
        public void ThenAllowPaging()
        {
            Target.SetPaging();
            Assert.Equal(true, Target.GridView.AllowPaging);
        }

        [Fact]
        public void ThenAllowSorting()
        {
            Target.SetSorting();
            Assert.Equal(true, Target.GridView.AllowSorting);
        }
    
    
