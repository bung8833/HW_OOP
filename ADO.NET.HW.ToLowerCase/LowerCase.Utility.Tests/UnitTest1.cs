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
        public void ToLowerCaseTest_�j�g�אּ���u�[�p�g_�}�Y�L���u
                    (string strA, string expected)
        {
            string actual = ToLowerCaseUtility.ToLowerCase(strA);

            Assert.AreEqual(expected, actual);
        }
    }
}