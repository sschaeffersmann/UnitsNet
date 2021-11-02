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
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of RelativeHumidity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RelativeHumidityTestsBase : QuantityTestsBase
    {
        protected abstract double PercentInOnePercent { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double PercentTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RelativeHumidity((double)0.0, RelativeHumidityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RelativeHumidity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RelativeHumidityUnit.Percent, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RelativeHumidity(double.PositiveInfinity, RelativeHumidityUnit.Percent));
            Assert.Throws<ArgumentException>(() => new RelativeHumidity(double.NegativeInfinity, RelativeHumidityUnit.Percent));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RelativeHumidity(double.NaN, RelativeHumidityUnit.Percent));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RelativeHumidity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new RelativeHumidity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (RelativeHumidity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void RelativeHumidity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RelativeHumidity(1, RelativeHumidityUnit.Percent);

            QuantityInfo<RelativeHumidityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RelativeHumidity.Zero, quantityInfo.Zero);
            Assert.Equal("RelativeHumidity", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<RelativeHumidityUnit>().Except(new[] {RelativeHumidityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void PercentToRelativeHumidityUnits()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            AssertEx.EqualTolerance(PercentInOnePercent, percent.Percent, PercentTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RelativeHumidity.From(1, RelativeHumidityUnit.Percent);
            AssertEx.EqualTolerance(1, quantity00.Percent, PercentTolerance);
            Assert.Equal(RelativeHumidityUnit.Percent, quantity00.Unit);

        }

        [Fact]
        public void FromPercent_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RelativeHumidity.FromPercent(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RelativeHumidity.FromPercent(double.NegativeInfinity));
        }

        [Fact]
        public void FromPercent_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RelativeHumidity.FromPercent(double.NaN));
        }

        [Fact]
        public void As()
        {
            var percent = RelativeHumidity.FromPercent(1);
            AssertEx.EqualTolerance(PercentInOnePercent, percent.As(RelativeHumidityUnit.Percent), PercentTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RelativeHumidity(value: 1, unit: RelativeHumidity.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var percent = RelativeHumidity.FromPercent(1);

            var percentQuantity = percent.ToUnit(RelativeHumidityUnit.Percent);
            AssertEx.EqualTolerance(PercentInOnePercent, (double)percentQuantity.Value, PercentTolerance);
            Assert.Equal(RelativeHumidityUnit.Percent, percentQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = RelativeHumidity.FromPercent(1).ToBaseUnit();
            Assert.Equal(RelativeHumidity.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            AssertEx.EqualTolerance(1, RelativeHumidity.FromPercent(percent.Percent).Percent, PercentTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RelativeHumidity v = RelativeHumidity.FromPercent(1);
            AssertEx.EqualTolerance(-1, -v.Percent, PercentTolerance);
            AssertEx.EqualTolerance(2, (RelativeHumidity.FromPercent(3)-v).Percent, PercentTolerance);
            AssertEx.EqualTolerance(2, (v + v).Percent, PercentTolerance);
            AssertEx.EqualTolerance(10, (v*10).Percent, PercentTolerance);
            AssertEx.EqualTolerance(10, (10*v).Percent, PercentTolerance);
            AssertEx.EqualTolerance(2, (RelativeHumidity.FromPercent(10)/5).Percent, PercentTolerance);
            AssertEx.EqualTolerance(2, RelativeHumidity.FromPercent(10)/RelativeHumidity.FromPercent(5), PercentTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RelativeHumidity onePercent = RelativeHumidity.FromPercent(1);
            RelativeHumidity twoPercent = RelativeHumidity.FromPercent(2);

            Assert.True(onePercent < twoPercent);
            Assert.True(onePercent <= twoPercent);
            Assert.True(twoPercent > onePercent);
            Assert.True(twoPercent >= onePercent);

            Assert.False(onePercent > twoPercent);
            Assert.False(onePercent >= twoPercent);
            Assert.False(twoPercent < onePercent);
            Assert.False(twoPercent <= onePercent);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            Assert.Equal(0, percent.CompareTo(percent));
            Assert.True(percent.CompareTo(RelativeHumidity.Zero) > 0);
            Assert.True(RelativeHumidity.Zero.CompareTo(percent) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            Assert.Throws<ArgumentException>(() => percent.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            Assert.Throws<ArgumentNullException>(() => percent.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = RelativeHumidity.FromPercent(1);
            Assert.True(v.Equals(RelativeHumidity.FromPercent(1), PercentTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RelativeHumidity.Zero, PercentTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RelativeHumidity.FromPercent(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RelativeHumidity.FromPercent(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            Assert.False(percent.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RelativeHumidity percent = RelativeHumidity.FromPercent(1);
            Assert.False(percent.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RelativeHumidityUnit.Undefined, RelativeHumidity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RelativeHumidityUnit)).Cast<RelativeHumidityUnit>();
            foreach(var unit in units)
            {
                if(unit == RelativeHumidityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RelativeHumidity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 %RH", new RelativeHumidity(1, RelativeHumidityUnit.Percent).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 %RH", new RelativeHumidity(1, RelativeHumidityUnit.Percent).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s1"));
                Assert.Equal("0.12 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s2"));
                Assert.Equal("0.123 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s3"));
                Assert.Equal("0.1235 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s1", culture));
            Assert.Equal("0.12 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s2", culture));
            Assert.Equal("0.123 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s3", culture));
            Assert.Equal("0.1235 %RH", new RelativeHumidity(0.123456, RelativeHumidityUnit.Percent).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentUICulture(string format)
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentUICulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(RelativeHumidity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RelativeHumidityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(RelativeHumidity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(RelativeHumidity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RelativeHumidity.FromPercent(1.0);
            Assert.Equal(new {RelativeHumidity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RelativeHumidity.FromPercent(value);
            Assert.Equal(RelativeHumidity.FromPercent(-value), -quantity);
        }
    }
}
