using MTK.JanitorHelper.DataItemServices.Customers;
using MTK.JanitorHelper.DataItemServices.Customers.Dto;
using MTK.JanitorHelper.Sessions;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MTK.JanitorHelper.Tests.DataItems.Customer
{
    public class CustomerAppService_Tests : JanitorHelperTestBase
    {


        private readonly ICustomerAppService customerAppService;

        public CustomerAppService_Tests()
        {
            this.customerAppService = Resolve<ICustomerAppService>();
        }

        [Fact]
        public void Should_Get_All_Customers_Without_Any_Filter()
        {
            //Act
            var persons = this.customerAppService.GetCustomers(new GetCustomersInput());

            //Assert
            persons.Items.Count.ShouldBe(1);
        }

        [Fact]
        public void Should_Get_Customers_With_Filter()
        {
            //Act
            var persons = this.customerAppService.GetCustomers(new GetCustomersInput()
            {
                Filter = "dummy"
            });

            //Assert
            persons.Items.Count.ShouldBe(1);
            persons.Items[0].LastName.ShouldBe("dummies");

        }
    }
}

