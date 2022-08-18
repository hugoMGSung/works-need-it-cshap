using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRPApp.View.Setting;
using System;
using System.Linq;

namespace MRPApp.Test
{
    [TestClass]
    public class SettingsTest
    {
        // Db사에 중복된 데이터 있는지 테스트
        [TestMethod]
        public void IsDuplicateDataTest()
        {
            var inputCode = "PC010001"; // DB상에 잇는 값
            var expectVal = true; // 예상값

            var code = Logic.DataAccess.GetSettings().Where(d => d.BasicCode.Contains(inputCode)).FirstOrDefault();
            var realVal = code != null ? true : false;

            Assert.AreEqual(expectVal, realVal); // 값이 같으면 Pass, 다르면 Fail
        }

        [TestMethod]
        public void IsCodeSearched()
        {
            var expectVal = 2; // 예상값
            var inputCode = "설비";

            var realVal = Logic.DataAccess.GetSettings().Where(d => d.CodeName.Contains(inputCode)).Count();

            Assert.AreEqual(expectVal, realVal);
        }

        [TestMethod]
        public void IsEmailCorrect()
        {
            var inputEmail = "personar95@naver.com";
            Assert.IsTrue(Commons.IsValidEmail(inputEmail));
        }

        [TestMethod]
        public void IsEmailIncorrect()
        {
            var inputEmail = "personar95@naver";
            Assert.IsFalse(Commons.IsValidEmail(inputEmail));
        }
    }
}
