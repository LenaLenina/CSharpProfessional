﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ContactManager
{
    [ValueConversion(typeof(int), typeof(int))]
    public class CountryIdToPositionConverter : IValueConverter
    {
        private readonly CountrySource countries = new CountrySource();

      #region IValueConverter Members

      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int? countryId = (int?) value;
            if (!countryId.HasValue) return -1;
            return countries.FindIndex(countryId.Value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = (int) value;
            if (index < 0 || index >= countries.Count) return null;

            return countries[index].Id;
        }

      #endregion
    }
}