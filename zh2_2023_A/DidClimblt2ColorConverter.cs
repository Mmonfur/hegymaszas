using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace zh2_2023_A
{
    public class DidClimbIt2ColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            bool hasClimbed = (bool)value;
            return hasClimbed ? Colors.Green : Colors.Black; // hasClimbed = true esetén zöld, egyébként fekete
        }

        object? IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
