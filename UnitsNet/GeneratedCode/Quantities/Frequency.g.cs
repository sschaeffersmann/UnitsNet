//------------------------------------------------------------------------------
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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    [DataContract]
    public partial struct Frequency : IQuantity<FrequencyUnit>, IComparable, IComparable<Frequency>, IConvertible, IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 0)]
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 1)]
        private readonly FrequencyUnit? _unit;

        static Frequency()
        {
            BaseDimensions = new BaseDimensions(0, 0, -1, 0, 0, 0, 0);

            Info = new QuantityInfo<FrequencyUnit>("Frequency",
                new UnitInfo<FrequencyUnit>[] {
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.BeatPerMinute, "BeatsPerMinute", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.BUnit, "BUnits", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.CyclePerHour, "CyclesPerHour", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.CyclePerMinute, "CyclesPerMinute", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.Gigahertz, "Gigahertz", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.Hertz, "Hertz", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.Kilohertz, "Kilohertz", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.Megahertz, "Megahertz", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.PerSecond, "PerSecond", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.RadianPerSecond, "RadiansPerSecond", BaseUnits.Undefined),
                    new UnitInfo<FrequencyUnit>(FrequencyUnit.Terahertz, "Terahertz", BaseUnits.Undefined),
                },
                ConversionBaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Frequency(double value, FrequencyUnit unit)
        {
            if(unit == FrequencyUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        /// <summary>
        /// Creates an instance of the quantity with the given numeric value in units compatible with the given <see cref="UnitSystem"/>.
        /// If multiple compatible units were found, the first match is used.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unitSystem">The unit system to create the quantity with.</param>
        /// <exception cref="ArgumentNullException">The given <see cref="UnitSystem"/> is null.</exception>
        /// <exception cref="ArgumentException">No unit was found for the given <see cref="UnitSystem"/>.</exception>
        public Frequency(double value, UnitSystem unitSystem)
        {
            if(unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<FrequencyUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Frequency, which is Hertz. All conversions go via this value.
        /// </summary>
        public static FrequencyUnit ConversionBaseUnit { get; } = FrequencyUnit.Hertz;

        /// <summary>
        ///     All units of measurement for the Frequency quantity.
        /// </summary>
        public static FrequencyUnit[] Units { get; } = Enum.GetValues(typeof(FrequencyUnit)).Cast<FrequencyUnit>().Except(new FrequencyUnit[]{ FrequencyUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Hertz.
        /// </summary>
        public static Frequency Zero { get; } = new Frequency(0, ConversionBaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public FrequencyUnit Unit => _unit.GetValueOrDefault(ConversionBaseUnit);

        /// <inheritdoc />
        public QuantityInfo<FrequencyUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Frequency.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Frequency in BeatsPerMinute.
        /// </summary>
        public double BeatsPerMinute => As(FrequencyUnit.BeatPerMinute);

        /// <summary>
        ///     Get Frequency in BUnits.
        /// </summary>
        public double BUnits => As(FrequencyUnit.BUnit);

        /// <summary>
        ///     Get Frequency in CyclesPerHour.
        /// </summary>
        public double CyclesPerHour => As(FrequencyUnit.CyclePerHour);

        /// <summary>
        ///     Get Frequency in CyclesPerMinute.
        /// </summary>
        public double CyclesPerMinute => As(FrequencyUnit.CyclePerMinute);

        /// <summary>
        ///     Get Frequency in Gigahertz.
        /// </summary>
        public double Gigahertz => As(FrequencyUnit.Gigahertz);

        /// <summary>
        ///     Get Frequency in Hertz.
        /// </summary>
        public double Hertz => As(FrequencyUnit.Hertz);

        /// <summary>
        ///     Get Frequency in Kilohertz.
        /// </summary>
        public double Kilohertz => As(FrequencyUnit.Kilohertz);

        /// <summary>
        ///     Get Frequency in Megahertz.
        /// </summary>
        public double Megahertz => As(FrequencyUnit.Megahertz);

        /// <summary>
        ///     Get Frequency in PerSecond.
        /// </summary>
        public double PerSecond => As(FrequencyUnit.PerSecond);

        /// <summary>
        ///     Get Frequency in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond => As(FrequencyUnit.RadianPerSecond);

        /// <summary>
        ///     Get Frequency in Terahertz.
        /// </summary>
        public double Terahertz => As(FrequencyUnit.Terahertz);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(FrequencyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static string GetAbbreviation(FrequencyUnit unit, IFormatProvider? provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Frequency from BeatsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromBeatsPerMinute(QuantityValue beatsperminute)
        {
            double value = (double) beatsperminute;
            return new Frequency(value, FrequencyUnit.BeatPerMinute);
        }
        /// <summary>
        ///     Get Frequency from BUnits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromBUnits(QuantityValue bunits)
        {
            double value = (double) bunits;
            return new Frequency(value, FrequencyUnit.BUnit);
        }
        /// <summary>
        ///     Get Frequency from CyclesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerHour(QuantityValue cyclesperhour)
        {
            double value = (double) cyclesperhour;
            return new Frequency(value, FrequencyUnit.CyclePerHour);
        }
        /// <summary>
        ///     Get Frequency from CyclesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromCyclesPerMinute(QuantityValue cyclesperminute)
        {
            double value = (double) cyclesperminute;
            return new Frequency(value, FrequencyUnit.CyclePerMinute);
        }
        /// <summary>
        ///     Get Frequency from Gigahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromGigahertz(QuantityValue gigahertz)
        {
            double value = (double) gigahertz;
            return new Frequency(value, FrequencyUnit.Gigahertz);
        }
        /// <summary>
        ///     Get Frequency from Hertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromHertz(QuantityValue hertz)
        {
            double value = (double) hertz;
            return new Frequency(value, FrequencyUnit.Hertz);
        }
        /// <summary>
        ///     Get Frequency from Kilohertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromKilohertz(QuantityValue kilohertz)
        {
            double value = (double) kilohertz;
            return new Frequency(value, FrequencyUnit.Kilohertz);
        }
        /// <summary>
        ///     Get Frequency from Megahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromMegahertz(QuantityValue megahertz)
        {
            double value = (double) megahertz;
            return new Frequency(value, FrequencyUnit.Megahertz);
        }
        /// <summary>
        ///     Get Frequency from PerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromPerSecond(QuantityValue persecond)
        {
            double value = (double) persecond;
            return new Frequency(value, FrequencyUnit.PerSecond);
        }
        /// <summary>
        ///     Get Frequency from RadiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromRadiansPerSecond(QuantityValue radianspersecond)
        {
            double value = (double) radianspersecond;
            return new Frequency(value, FrequencyUnit.RadianPerSecond);
        }
        /// <summary>
        ///     Get Frequency from Terahertz.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Frequency FromTerahertz(QuantityValue terahertz)
        {
            double value = (double) terahertz;
            return new Frequency(value, FrequencyUnit.Terahertz);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
        public static Frequency From(QuantityValue value, FrequencyUnit fromUnit)
        {
            return new Frequency((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
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
        public static Frequency Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static Frequency Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<Frequency, FrequencyUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse(string? str, out Frequency result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParse(string? str, IFormatProvider? provider, out Frequency result)
        {
            return QuantityParser.Default.TryParse<Frequency, FrequencyUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FrequencyUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FrequencyUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse<FrequencyUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.FrequencyUnit)"/>
        public static bool TryParseUnit(string str, out FrequencyUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out FrequencyUnit unit)
        {
            return UnitParser.Default.TryParse<FrequencyUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Frequency operator -(Frequency right)
        {
            return new Frequency(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Frequency"/> from adding two <see cref="Frequency"/>.</summary>
        public static Frequency operator +(Frequency left, Frequency right)
        {
            return new Frequency(left.Value + right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Frequency"/> from subtracting two <see cref="Frequency"/>.</summary>
        public static Frequency operator -(Frequency left, Frequency right)
        {
            return new Frequency(left.Value - right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Frequency"/> from multiplying value and <see cref="Frequency"/>.</summary>
        public static Frequency operator *(double left, Frequency right)
        {
            return new Frequency(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Frequency"/> from multiplying value and <see cref="Frequency"/>.</summary>
        public static Frequency operator *(Frequency left, double right)
        {
            return new Frequency(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Frequency"/> from dividing <see cref="Frequency"/> by value.</summary>
        public static Frequency operator /(Frequency left, double right)
        {
            return new Frequency(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Frequency"/> by <see cref="Frequency"/>.</summary>
        public static double operator /(Frequency left, Frequency right)
        {
            return left.Hertz / right.Hertz;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Frequency left, Frequency right)
        {
            return left.Value <= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Frequency left, Frequency right)
        {
            return left.Value >= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Frequency left, Frequency right)
        {
            return left.Value < right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Frequency left, Frequency right)
        {
            return left.Value > right.GetValueAs(left.Unit);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Frequency objFrequency)) throw new ArgumentException("Expected type Frequency.", nameof(obj));

            return CompareTo(objFrequency);
        }

        /// <inheritdoc />
        public int CompareTo(Frequency other)
        {
            return _value.CompareTo(other.GetValueAs(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Frequency within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Frequency other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Frequency.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(FrequencyUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = GetValueAs(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public double As(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        double IQuantity.As(Enum unit)
        {
            if(!(unit is FrequencyUnit unitAsFrequencyUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(FrequencyUnit)} is supported.", nameof(unit));

            return As(unitAsFrequencyUnit);
        }

        /// <summary>
        ///     Converts this Frequency to another Frequency with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Frequency with the specified unit.</returns>
        public Frequency ToUnit(FrequencyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Frequency(convertedValue, unit);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if(!(unit is FrequencyUnit unitAsFrequencyUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(FrequencyUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsFrequencyUnit);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public Frequency ToUnit(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<FrequencyUnit> IQuantity<FrequencyUnit>.ToUnit(FrequencyUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<FrequencyUnit> IQuantity<FrequencyUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case FrequencyUnit.BeatPerMinute: return _value/60;
                case FrequencyUnit.BUnit: return Math.Sqrt(_value * 1e3);
                case FrequencyUnit.CyclePerHour: return _value/3600;
                case FrequencyUnit.CyclePerMinute: return _value/60;
                case FrequencyUnit.Gigahertz: return (_value) * 1e9d;
                case FrequencyUnit.Hertz: return _value;
                case FrequencyUnit.Kilohertz: return (_value) * 1e3d;
                case FrequencyUnit.Megahertz: return (_value) * 1e6d;
                case FrequencyUnit.PerSecond: return _value;
                case FrequencyUnit.RadianPerSecond: return _value/6.2831853072;
                case FrequencyUnit.Terahertz: return (_value) * 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        internal Frequency ToBaseUnit()
        {
            var baseUnitValue = GetValueInBaseUnit();
            return new Frequency(baseUnitValue, ConversionBaseUnit);
        }

        private double GetValueAs(FrequencyUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case FrequencyUnit.BeatPerMinute: return baseUnitValue*60;
                case FrequencyUnit.BUnit: return baseUnitValue * baseUnitValue * 1e-3;
                case FrequencyUnit.CyclePerHour: return baseUnitValue*3600;
                case FrequencyUnit.CyclePerMinute: return baseUnitValue*60;
                case FrequencyUnit.Gigahertz: return (baseUnitValue) / 1e9d;
                case FrequencyUnit.Hertz: return baseUnitValue;
                case FrequencyUnit.Kilohertz: return (baseUnitValue) / 1e3d;
                case FrequencyUnit.Megahertz: return (baseUnitValue) / 1e6d;
                case FrequencyUnit.PerSecond: return baseUnitValue;
                case FrequencyUnit.RadianPerSecond: return baseUnitValue*6.2831853072;
                case FrequencyUnit.Terahertz: return (baseUnitValue) / 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentUICulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<FrequencyUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Frequency)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Frequency)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Frequency)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(Frequency))
                return this;
            else if(conversionType == typeof(FrequencyUnit))
                return Unit;
            else if(conversionType == typeof(QuantityInfo))
                return Frequency.Info;
            else if(conversionType == typeof(BaseDimensions))
                return Frequency.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Frequency)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
