﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Pressure change rate is the ratio of the pressure change to the time during which the change occurred (value of pressure changes per unit time).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct PressureChangeRate : IComparable, IComparable<PressureChangeRate>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable AtmospheresPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static PressureChangeRate? FromAtmospheresPerSecond(QuantityValue? atmospherespersecond)
        {
            return atmospherespersecond.HasValue ? FromAtmospheresPerSecond(atmospherespersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable KilopascalsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static PressureChangeRate? FromKilopascalsPerSecond(QuantityValue? kilopascalspersecond)
        {
            return kilopascalspersecond.HasValue ? FromKilopascalsPerSecond(kilopascalspersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable MegapascalsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static PressureChangeRate? FromMegapascalsPerSecond(QuantityValue? megapascalspersecond)
        {
            return megapascalspersecond.HasValue ? FromMegapascalsPerSecond(megapascalspersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable PascalsPerSecond.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static PressureChangeRate? FromPascalsPerSecond(QuantityValue? pascalspersecond)
        {
            return pascalspersecond.HasValue ? FromPascalsPerSecond(pascalspersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PressureChangeRateUnit" /> to <see cref="PressureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PressureChangeRate unit value.</returns>
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static PressureChangeRate? From(QuantityValue? value, PressureChangeRateUnit fromUnit)
        {
            return value.HasValue ? new PressureChangeRate((double)value.Value, fromUnit) : default(PressureChangeRate?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(PressureChangeRateUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static PressureChangeRate operator -(PressureChangeRate right)
        {
            return new PressureChangeRate(-right.Value, right.Unit);
        }

        public static PressureChangeRate operator +(PressureChangeRate left, PressureChangeRate right)
        {
            return new PressureChangeRate(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PressureChangeRate operator -(PressureChangeRate left, PressureChangeRate right)
        {
            return new PressureChangeRate(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PressureChangeRate operator *(double left, PressureChangeRate right)
        {
            return new PressureChangeRate(left * right.Value, right.Unit);
        }

        public static PressureChangeRate operator *(PressureChangeRate left, double right)
        {
            return new PressureChangeRate(left.Value * right, left.Unit);
        }

        public static PressureChangeRate operator /(PressureChangeRate left, double right)
        {
            return new PressureChangeRate(left.Value / right, left.Unit);
        }

        public static double operator /(PressureChangeRate left, PressureChangeRate right)
        {
            return left.PascalsPerSecond / right.PascalsPerSecond;
        }

        #endregion

        public static bool operator <=(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static PressureChangeRate Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<PressureChangeRate, PressureChangeRateUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    PressureChangeRateUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromPascalsPerSecond(x.PascalsPerSecond + y.PascalsPerSecond));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out PressureChangeRate result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(PressureChangeRate);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static PressureChangeRateUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<PressureChangeRateUnit>(str.Trim());

            if (unit == PressureChangeRateUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized PressureChangeRateUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(PressureChangeRateUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(PressureChangeRateUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(PressureChangeRateUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
