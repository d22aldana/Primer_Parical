using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prim_Parcial.Controllers;

namespace Prim_Parcial.Tests
{
    [TestClass]
    public class UnitTestGetAldana

    {
        [TestMethod]
        public void TestMethodGetAldanas()
        {
            //arrange
           AldanasController aldanacontroller = new AldanasController();
            //act
            var aldanas = aldanacontroller.GetAldanas();
            //assert
            Assert.IsNotNull(aldanas);
            
        }
        
        


    }
}
