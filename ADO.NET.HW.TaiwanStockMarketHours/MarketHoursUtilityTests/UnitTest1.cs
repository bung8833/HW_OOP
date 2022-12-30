namespace MarketHoursUtilityTests
{
    public class Tests
    {
        [TestCase(2022, 12, 12, 08, 59, 59, false)]
        [TestCase(2022, 12, 12, 09, 00, 00, true)]

        [TestCase(2022, 12, 12, 13, 30, 00, true)]
        [TestCase(2022, 12, 12, 13, 30, 01, false)]

        [TestCase(2022, 12, 16,  9, 00, 00, true)]

        [TestCase(2022, 12, 17,  9, 00, 00, false)]
        [TestCase(2022, 12, 18, 13, 30, 00, false)]
        public void TesIsMarketHoursTest_判斷是否為股票交易時間
            (int year, int month, int day, int hour, int minute, int second, bool expected)
        {
            var theDate = new DateTime(year, month, day, hour, minute, second);
            bool actual = MarketHoursUtility.IsMarketHoursUtility.IsMarketHours(theDate);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("2022/12/16 9:00:00")]
        [TestCase("2022/12/16 13:30:00")]
        [TestCase("2022/12/12 9:00:00")]
        [TestCase("2022/12/12 13:30:00")]
        public void IsTradingHours_是交易時間(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = MarketHoursUtility.IsMarketHoursUtility.IsMarketHours(dt);

            Assert.IsTrue(actual);
        }


        [TestCase("2022/12/16 8:59:59")]
        [TestCase("2022/12/16 13:30:01")]
        [TestCase("2022/12/12 8:59:59")]
        [TestCase("2022/12/12 13:30:01")]
        public void IsTradingHours_是平日_但不是交易時間_ReturnsFalse(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = MarketHoursUtility.IsMarketHoursUtility.IsMarketHours(dt);

            Assert.IsFalse(actual);
        }


        [TestCase("2022/12/17 9:00:00")]
        [TestCase("2022/12/17 13:30:00")]
        [TestCase("2022/12/18 9:00:00")]
        [TestCase("2022/12/18 13:30:00")]
        public void IsTradingHours_星期六日_但時間交易時間_ReturnsFalse(string dtValue)
        {
            DateTime dt = Convert.ToDateTime(dtValue);

            bool actual = MarketHoursUtility.IsMarketHoursUtility.IsMarketHours(dt);

            Assert.IsFalse(actual);
        }


    }
}