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
    /// Test of StandardVolumeFlow.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class StandardVolumeFlowTestsBase : QuantityTestsBase
    {
        protected abstract double StandardCubicCentimetersPerMinuteInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicFeetPerHourInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicFeetPerMinuteInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicFeetPerSecondInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicMetersPerDayInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicMetersPerHourInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicMetersPerMinuteInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardCubicMetersPerSecondInOneStandardCubicMeterPerSecond { get; }
        protected abstract double StandardLitersPerMinuteInOneStandardCubicMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double StandardCubicCentimetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicFeetPerHourTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicFeetPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicFeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicMetersPerDayTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicMetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicMetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double StandardCubicMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double StandardLitersPerMinuteTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new StandardVolumeFlow((double)0.0, StandardVolumeFlowUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new StandardVolumeFlow();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new StandardVolumeFlow(double.PositiveInfinity, StandardVolumeFlowUnit.StandardCubicMeterPerSecond));
            Assert.Throws<ArgumentException>(() => new StandardVolumeFlow(double.NegativeInfinity, StandardVolumeFlowUnit.StandardCubicMeterPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new StandardVolumeFlow(double.NaN, StandardVolumeFlowUnit.StandardCubicMeterPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new StandardVolumeFlow(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new StandardVolumeFlow(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (StandardVolumeFlow) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void StandardVolumeFlow_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerSecond);

            QuantityInfo<StandardVolumeFlowUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(StandardVolumeFlow.Zero, quantityInfo.Zero);
            Assert.Equal("StandardVolumeFlow", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<StandardVolumeFlowUnit>().Except(new[] {StandardVolumeFlowUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void StandardCubicMeterPerSecondToStandardVolumeFlowUnits()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(StandardCubicCentimetersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicCentimetersPerMinute, StandardCubicCentimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerHourInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicFeetPerHour, StandardCubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicFeetPerMinute, StandardCubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerSecondInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicFeetPerSecond, StandardCubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerDayInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicMetersPerDay, StandardCubicMetersPerDayTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerHourInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicMetersPerHour, StandardCubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicMetersPerMinute, StandardCubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerSecondInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StandardLitersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.StandardLitersPerMinute, StandardLitersPerMinuteTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute);
            AssertEx.EqualTolerance(1, quantity00.StandardCubicCentimetersPerMinute, StandardCubicCentimetersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute, quantity00.Unit);

            var quantity01 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicFootPerHour);
            AssertEx.EqualTolerance(1, quantity01.StandardCubicFeetPerHour, StandardCubicFeetPerHourTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerHour, quantity01.Unit);

            var quantity02 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicFootPerMinute);
            AssertEx.EqualTolerance(1, quantity02.StandardCubicFeetPerMinute, StandardCubicFeetPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerMinute, quantity02.Unit);

            var quantity03 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicFootPerSecond);
            AssertEx.EqualTolerance(1, quantity03.StandardCubicFeetPerSecond, StandardCubicFeetPerSecondTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerSecond, quantity03.Unit);

            var quantity04 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicMeterPerDay);
            AssertEx.EqualTolerance(1, quantity04.StandardCubicMetersPerDay, StandardCubicMetersPerDayTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerDay, quantity04.Unit);

            var quantity05 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicMeterPerHour);
            AssertEx.EqualTolerance(1, quantity05.StandardCubicMetersPerHour, StandardCubicMetersPerHourTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerHour, quantity05.Unit);

            var quantity06 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicMeterPerMinute);
            AssertEx.EqualTolerance(1, quantity06.StandardCubicMetersPerMinute, StandardCubicMetersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerMinute, quantity06.Unit);

            var quantity07 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardCubicMeterPerSecond);
            AssertEx.EqualTolerance(1, quantity07.StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerSecond, quantity07.Unit);

            var quantity08 = StandardVolumeFlow.From(1, StandardVolumeFlowUnit.StandardLiterPerMinute);
            AssertEx.EqualTolerance(1, quantity08.StandardLitersPerMinute, StandardLitersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardLiterPerMinute, quantity08.Unit);

        }

        [Fact]
        public void FromStandardCubicMetersPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => StandardVolumeFlow.FromStandardCubicMetersPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => StandardVolumeFlow.FromStandardCubicMetersPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromStandardCubicMetersPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => StandardVolumeFlow.FromStandardCubicMetersPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(StandardCubicCentimetersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute), StandardCubicCentimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerHourInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicFootPerHour), StandardCubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicFootPerMinute), StandardCubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicFeetPerSecondInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicFootPerSecond), StandardCubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerDayInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicMeterPerDay), StandardCubicMetersPerDayTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerHourInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicMeterPerHour), StandardCubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicMeterPerMinute), StandardCubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(StandardCubicMetersPerSecondInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardCubicMeterPerSecond), StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StandardLitersPerMinuteInOneStandardCubicMeterPerSecond, standardcubicmeterpersecond.As(StandardVolumeFlowUnit.StandardLiterPerMinute), StandardLitersPerMinuteTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new StandardVolumeFlow(value: 1, unit: StandardVolumeFlow.ConversionBaseUnit);
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
            var standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);

            var standardcubiccentimeterperminuteQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute);
            AssertEx.EqualTolerance(StandardCubicCentimetersPerMinuteInOneStandardCubicMeterPerSecond, (double)standardcubiccentimeterperminuteQuantity.Value, StandardCubicCentimetersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute, standardcubiccentimeterperminuteQuantity.Unit);

            var standardcubicfootperhourQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicFootPerHour);
            AssertEx.EqualTolerance(StandardCubicFeetPerHourInOneStandardCubicMeterPerSecond, (double)standardcubicfootperhourQuantity.Value, StandardCubicFeetPerHourTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerHour, standardcubicfootperhourQuantity.Unit);

            var standardcubicfootperminuteQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicFootPerMinute);
            AssertEx.EqualTolerance(StandardCubicFeetPerMinuteInOneStandardCubicMeterPerSecond, (double)standardcubicfootperminuteQuantity.Value, StandardCubicFeetPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerMinute, standardcubicfootperminuteQuantity.Unit);

            var standardcubicfootpersecondQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicFootPerSecond);
            AssertEx.EqualTolerance(StandardCubicFeetPerSecondInOneStandardCubicMeterPerSecond, (double)standardcubicfootpersecondQuantity.Value, StandardCubicFeetPerSecondTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicFootPerSecond, standardcubicfootpersecondQuantity.Unit);

            var standardcubicmeterperdayQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicMeterPerDay);
            AssertEx.EqualTolerance(StandardCubicMetersPerDayInOneStandardCubicMeterPerSecond, (double)standardcubicmeterperdayQuantity.Value, StandardCubicMetersPerDayTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerDay, standardcubicmeterperdayQuantity.Unit);

            var standardcubicmeterperhourQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicMeterPerHour);
            AssertEx.EqualTolerance(StandardCubicMetersPerHourInOneStandardCubicMeterPerSecond, (double)standardcubicmeterperhourQuantity.Value, StandardCubicMetersPerHourTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerHour, standardcubicmeterperhourQuantity.Unit);

            var standardcubicmeterperminuteQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicMeterPerMinute);
            AssertEx.EqualTolerance(StandardCubicMetersPerMinuteInOneStandardCubicMeterPerSecond, (double)standardcubicmeterperminuteQuantity.Value, StandardCubicMetersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerMinute, standardcubicmeterperminuteQuantity.Unit);

            var standardcubicmeterpersecondQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardCubicMeterPerSecond);
            AssertEx.EqualTolerance(StandardCubicMetersPerSecondInOneStandardCubicMeterPerSecond, (double)standardcubicmeterpersecondQuantity.Value, StandardCubicMetersPerSecondTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardCubicMeterPerSecond, standardcubicmeterpersecondQuantity.Unit);

            var standardliterperminuteQuantity = standardcubicmeterpersecond.ToUnit(StandardVolumeFlowUnit.StandardLiterPerMinute);
            AssertEx.EqualTolerance(StandardLitersPerMinuteInOneStandardCubicMeterPerSecond, (double)standardliterperminuteQuantity.Value, StandardLitersPerMinuteTolerance);
            Assert.Equal(StandardVolumeFlowUnit.StandardLiterPerMinute, standardliterperminuteQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1).ToBaseUnit();
            Assert.Equal(StandardVolumeFlow.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicCentimetersPerMinute(standardcubicmeterpersecond.StandardCubicCentimetersPerMinute).StandardCubicMetersPerSecond, StandardCubicCentimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicFeetPerHour(standardcubicmeterpersecond.StandardCubicFeetPerHour).StandardCubicMetersPerSecond, StandardCubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicFeetPerMinute(standardcubicmeterpersecond.StandardCubicFeetPerMinute).StandardCubicMetersPerSecond, StandardCubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicFeetPerSecond(standardcubicmeterpersecond.StandardCubicFeetPerSecond).StandardCubicMetersPerSecond, StandardCubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicMetersPerDay(standardcubicmeterpersecond.StandardCubicMetersPerDay).StandardCubicMetersPerSecond, StandardCubicMetersPerDayTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicMetersPerHour(standardcubicmeterpersecond.StandardCubicMetersPerHour).StandardCubicMetersPerSecond, StandardCubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicMetersPerMinute(standardcubicmeterpersecond.StandardCubicMetersPerMinute).StandardCubicMetersPerSecond, StandardCubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardCubicMetersPerSecond(standardcubicmeterpersecond.StandardCubicMetersPerSecond).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, StandardVolumeFlow.FromStandardLitersPerMinute(standardcubicmeterpersecond.StandardLitersPerMinute).StandardCubicMetersPerSecond, StandardLitersPerMinuteTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            StandardVolumeFlow v = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (StandardVolumeFlow.FromStandardCubicMetersPerSecond(3)-v).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (StandardVolumeFlow.FromStandardCubicMetersPerSecond(10)/5).StandardCubicMetersPerSecond, StandardCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, StandardVolumeFlow.FromStandardCubicMetersPerSecond(10)/StandardVolumeFlow.FromStandardCubicMetersPerSecond(5), StandardCubicMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            StandardVolumeFlow oneStandardCubicMeterPerSecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            StandardVolumeFlow twoStandardCubicMetersPerSecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(2);

            Assert.True(oneStandardCubicMeterPerSecond < twoStandardCubicMetersPerSecond);
            Assert.True(oneStandardCubicMeterPerSecond <= twoStandardCubicMetersPerSecond);
            Assert.True(twoStandardCubicMetersPerSecond > oneStandardCubicMeterPerSecond);
            Assert.True(twoStandardCubicMetersPerSecond >= oneStandardCubicMeterPerSecond);

            Assert.False(oneStandardCubicMeterPerSecond > twoStandardCubicMetersPerSecond);
            Assert.False(oneStandardCubicMeterPerSecond >= twoStandardCubicMetersPerSecond);
            Assert.False(twoStandardCubicMetersPerSecond < oneStandardCubicMeterPerSecond);
            Assert.False(twoStandardCubicMetersPerSecond <= oneStandardCubicMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.Equal(0, standardcubicmeterpersecond.CompareTo(standardcubicmeterpersecond));
            Assert.True(standardcubicmeterpersecond.CompareTo(StandardVolumeFlow.Zero) > 0);
            Assert.True(StandardVolumeFlow.Zero.CompareTo(standardcubicmeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => standardcubicmeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => standardcubicmeterpersecond.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.True(v.Equals(StandardVolumeFlow.FromStandardCubicMetersPerSecond(1), StandardCubicMetersPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(StandardVolumeFlow.Zero, StandardCubicMetersPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(StandardVolumeFlow.FromStandardCubicMetersPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.False(standardcubicmeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            StandardVolumeFlow standardcubicmeterpersecond = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1);
            Assert.False(standardcubicmeterpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(StandardVolumeFlowUnit.Undefined, StandardVolumeFlow.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(StandardVolumeFlowUnit)).Cast<StandardVolumeFlowUnit>();
            foreach(var unit in units)
            {
                if(unit == StandardVolumeFlowUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(StandardVolumeFlow.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 sccm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute).ToString());
                Assert.Equal("1 scfh", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerHour).ToString());
                Assert.Equal("1 scfm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerMinute).ToString());
                Assert.Equal("1 Sft³/s", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerSecond).ToString());
                Assert.Equal("1 Sm³/d", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerDay).ToString());
                Assert.Equal("1 Sm³/h", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerHour).ToString());
                Assert.Equal("1 Sm³/min", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerMinute).ToString());
                Assert.Equal("1 Sm³/s", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString());
                Assert.Equal("1 slm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardLiterPerMinute).ToString());
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

            Assert.Equal("1 sccm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute).ToString(swedishCulture));
            Assert.Equal("1 scfh", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerHour).ToString(swedishCulture));
            Assert.Equal("1 scfm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerMinute).ToString(swedishCulture));
            Assert.Equal("1 Sft³/s", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicFootPerSecond).ToString(swedishCulture));
            Assert.Equal("1 Sm³/d", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerDay).ToString(swedishCulture));
            Assert.Equal("1 Sm³/h", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerHour).ToString(swedishCulture));
            Assert.Equal("1 Sm³/min", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerMinute).ToString(swedishCulture));
            Assert.Equal("1 Sm³/s", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString(swedishCulture));
            Assert.Equal("1 slm", new StandardVolumeFlow(1, StandardVolumeFlowUnit.StandardLiterPerMinute).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s1"));
                Assert.Equal("0.12 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s2"));
                Assert.Equal("0.123 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s3"));
                Assert.Equal("0.1235 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 Sm³/s", new StandardVolumeFlow(0.123456, StandardVolumeFlowUnit.StandardCubicMeterPerSecond).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
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
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentUICulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(StandardVolumeFlow)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(StandardVolumeFlowUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(StandardVolumeFlow.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(StandardVolumeFlow.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(1.0);
            Assert.Equal(new {StandardVolumeFlow.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = StandardVolumeFlow.FromStandardCubicMetersPerSecond(value);
            Assert.Equal(StandardVolumeFlow.FromStandardCubicMetersPerSecond(-value), -quantity);
        }
    }
}
