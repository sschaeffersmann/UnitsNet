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
    /// Test of RatioChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioChangeRateTestsBase : QuantityTestsBase
    {
        protected abstract double DecimalFractionsPerSecondInOneDecimalFractionPerSecond { get; }
        protected abstract double PercentsPerSecondInOneDecimalFractionPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PercentsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate((double)0.0, RatioChangeRateUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RatioChangeRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.PositiveInfinity, RatioChangeRateUnit.DecimalFractionPerSecond));
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.NegativeInfinity, RatioChangeRateUnit.DecimalFractionPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate(double.NaN, RatioChangeRateUnit.DecimalFractionPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RatioChangeRate(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new RatioChangeRate(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (RatioChangeRate) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void RatioChangeRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond);

            QuantityInfo<RatioChangeRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RatioChangeRate.Zero, quantityInfo.Zero);
            Assert.Equal("RatioChangeRate", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<RatioChangeRateUnit>().Except(new[] {RatioChangeRateUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void DecimalFractionPerSecondToRatioChangeRateUnits()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RatioChangeRate.From(1, RatioChangeRateUnit.DecimalFractionPerSecond);
            AssertEx.EqualTolerance(1, quantity00.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, quantity00.Unit);

            var quantity01 = RatioChangeRate.From(1, RatioChangeRateUnit.PercentPerSecond);
            AssertEx.EqualTolerance(1, quantity01.PercentsPerSecond, PercentsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.PercentPerSecond, quantity01.Unit);

        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RatioChangeRate.FromDecimalFractionsPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.DecimalFractionPerSecond), DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.PercentPerSecond), PercentsPerSecondTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RatioChangeRate(value: 1, unit: RatioChangeRate.ConversionBaseUnit);
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
            var decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);

            var decimalfractionpersecondQuantity = decimalfractionpersecond.ToUnit(RatioChangeRateUnit.DecimalFractionPerSecond);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, (double)decimalfractionpersecondQuantity.Value, DecimalFractionsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, decimalfractionpersecondQuantity.Unit);

            var percentpersecondQuantity = decimalfractionpersecond.ToUnit(RatioChangeRateUnit.PercentPerSecond);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, (double)percentpersecondQuantity.Value, PercentsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.PercentPerSecond, percentpersecondQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = RatioChangeRate.FromDecimalFractionsPerSecond(1).ToBaseUnit();
            Assert.Equal(RatioChangeRate.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromDecimalFractionsPerSecond(decimalfractionpersecond.DecimalFractionsPerSecond).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromPercentsPerSecond(decimalfractionpersecond.PercentsPerSecond).DecimalFractionsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RatioChangeRate v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(3)-v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(10)/5).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, RatioChangeRate.FromDecimalFractionsPerSecond(10)/RatioChangeRate.FromDecimalFractionsPerSecond(5), DecimalFractionsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RatioChangeRate oneDecimalFractionPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            RatioChangeRate twoDecimalFractionsPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(2);

            Assert.True(oneDecimalFractionPerSecond < twoDecimalFractionsPerSecond);
            Assert.True(oneDecimalFractionPerSecond <= twoDecimalFractionsPerSecond);
            Assert.True(twoDecimalFractionsPerSecond > oneDecimalFractionPerSecond);
            Assert.True(twoDecimalFractionsPerSecond >= oneDecimalFractionPerSecond);

            Assert.False(oneDecimalFractionPerSecond > twoDecimalFractionsPerSecond);
            Assert.False(oneDecimalFractionPerSecond >= twoDecimalFractionsPerSecond);
            Assert.False(twoDecimalFractionsPerSecond < oneDecimalFractionPerSecond);
            Assert.False(twoDecimalFractionsPerSecond <= oneDecimalFractionPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Equal(0, decimalfractionpersecond.CompareTo(decimalfractionpersecond));
            Assert.True(decimalfractionpersecond.CompareTo(RatioChangeRate.Zero) > 0);
            Assert.True(RatioChangeRate.Zero.CompareTo(decimalfractionpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentException>(() => decimalfractionpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => decimalfractionpersecond.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.True(v.Equals(RatioChangeRate.FromDecimalFractionsPerSecond(1), DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RatioChangeRate.Zero, DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RatioChangeRate.FromDecimalFractionsPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RatioChangeRateUnit.Undefined, RatioChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RatioChangeRateUnit)).Cast<RatioChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == RatioChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RatioChangeRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 /s", new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond).ToString());
                Assert.Equal("1 %/s", new RatioChangeRate(1, RatioChangeRateUnit.PercentPerSecond).ToString());
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

            Assert.Equal("1 /s", new RatioChangeRate(1, RatioChangeRateUnit.DecimalFractionPerSecond).ToString(swedishCulture));
            Assert.Equal("1 %/s", new RatioChangeRate(1, RatioChangeRateUnit.PercentPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s1"));
                Assert.Equal("0.12 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s2"));
                Assert.Equal("0.123 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s3"));
                Assert.Equal("0.1235 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 /s", new RatioChangeRate(0.123456, RatioChangeRateUnit.DecimalFractionPerSecond).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
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
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentUICulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(RatioChangeRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RatioChangeRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(RatioChangeRate.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(RatioChangeRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(1.0);
            Assert.Equal(new {RatioChangeRate.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RatioChangeRate.FromDecimalFractionsPerSecond(value);
            Assert.Equal(RatioChangeRate.FromDecimalFractionsPerSecond(-value), -quantity);
        }
    }
}
