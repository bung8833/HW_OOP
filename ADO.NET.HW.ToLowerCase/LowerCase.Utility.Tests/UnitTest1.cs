namespace LowerCase.Utility.Tests
{
    public class Tests
    {
        [TestCase("iPhone", "i_phone")]
        [TestCase("BatMan", "bat_man")]
        [TestCase("AppleCat", "apple_cat")]
        [TestCase("c_chat", "c_chat")]
        [TestCase("Ver1.0.2", "ver1.0.2")]
        [TestCase("MCHammer", "m_c_hammer")]
        public void ToLowerCaseTest_大寫改為底線加小寫_開頭無底線
                    (string strA, string expected)
        {
            string actual = ToLowerCaseUtility.ToLowerCase(strA);

            Assert.AreEqual(expected, actual);
        }
    }
}