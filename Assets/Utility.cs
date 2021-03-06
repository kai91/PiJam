﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public static class Utility
    {
        public static KeyValuePair<int, int> getRange(bool easy)
        {
            if (easy) return getFruitRangePair(2,7,4);
            else return getFruitRangePair(2,7,2);
        }

        public static KeyValuePair<int, int> getFruitRangePair(int lowLimitOfStartValue, int highLimitOfStartValue, int desiredRange)
        {
            var random = new Random((int)DateTime.Now.Ticks);

            var lowValue = (int)(random.NextDouble() * (highLimitOfStartValue - lowLimitOfStartValue)) + lowLimitOfStartValue;
            var highValue = lowValue + desiredRange;

            return new KeyValuePair<int, int>(lowValue, highValue);
        }
    }
}
