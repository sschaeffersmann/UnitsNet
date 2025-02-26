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
using System.Collections.Generic;
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
    /// Test of SpecificFuelConsumption.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificFuelConsumptionTestsBase : QuantityTestsBase
    {
        protected abstract double GramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond { get; }
        protected abstract double KilogramsPerKilogramForceHourInOneGramPerKiloNewtonSecond { get; }
        protected abstract double KilogramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond { get; }
        protected abstract double PoundsMassPerPoundForceHourInOneGramPerKiloNewtonSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerKiloNewtonSecondTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerKilogramForceHourTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerKiloNewtonSecondTolerance { get { return 1e-5; } }
        protected virtual double PoundsMassPerPoundForceHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(SpecificFuelConsumptionUnit unit)
        {
            return unit switch
            {
                SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond => (GramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance),
                SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour => (KilogramsPerKilogramForceHourInOneGramPerKiloNewtonSecond, KilogramsPerKilogramForceHourTolerance),
                SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond => (KilogramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance),
                SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour => (PoundsMassPerPoundForceHourInOneGramPerKiloNewtonSecond, PoundsMassPerPoundForceHourTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond },
            new object[] { SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour },
            new object[] { SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond },
            new object[] { SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour },
        };

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption((double)0.0, SpecificFuelConsumptionUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SpecificFuelConsumption();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.PositiveInfinity, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond));
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.NegativeInfinity, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificFuelConsumption(double.NaN, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SpecificFuelConsumption(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new SpecificFuelConsumption(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (SpecificFuelConsumption) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void SpecificFuelConsumption_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);

            QuantityInfo<SpecificFuelConsumptionUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SpecificFuelConsumption.Zero, quantityInfo.Zero);
            Assert.Equal("SpecificFuelConsumption", quantityInfo.Name);
            Assert.Equal(QuantityType.SpecificFuelConsumption, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<SpecificFuelConsumptionUnit>().Except(new[] {SpecificFuelConsumptionUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void GramPerKiloNewtonSecondToSpecificFuelConsumptionUnits()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            AssertEx.EqualTolerance(GramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(KilogramsPerKilogramForceHourInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.KilogramsPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(PoundsMassPerPoundForceHourInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);
            AssertEx.EqualTolerance(1, quantity00.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, quantity00.Unit);

            var quantity01 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour);
            AssertEx.EqualTolerance(1, quantity01.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, quantity01.Unit);

            var quantity02 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond);
            AssertEx.EqualTolerance(1, quantity02.KilogramsPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond, quantity02.Unit);

            var quantity03 = SpecificFuelConsumption.From(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);
            AssertEx.EqualTolerance(1, quantity03.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
            Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, quantity03.Unit);

        }

        [Fact]
        public void FromGramsPerKiloNewtonSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromGramsPerKiloNewtonSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            AssertEx.EqualTolerance(GramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.As(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond), GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(KilogramsPerKilogramForceHourInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.As(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour), KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.As(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond), KilogramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(PoundsMassPerPoundForceHourInOneGramPerKiloNewtonSecond, gramperkilonewtonsecond.As(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour), PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new SpecificFuelConsumption(value: 1, unit: SpecificFuelConsumption.BaseUnit);
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
        public void Parse()
        {
            try
            {
                var parsed = SpecificFuelConsumption.Parse("1 g/(kN·s)", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = SpecificFuelConsumption.Parse("1 kg/(kgf·h)", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = SpecificFuelConsumption.Parse("1 kg/(kN·s)", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = SpecificFuelConsumption.Parse("1 lb/(lbf·h)", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(SpecificFuelConsumption.TryParse("1 g/(kN·s)", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, parsed.Unit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParse("1 kg/(kgf·h)", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerKilogramForceHour, KilogramsPerKilogramForceHourTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, parsed.Unit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParse("1 kg/(kN·s)", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilogramsPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond, parsed.Unit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParse("1 lb/(lbf·h)", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PoundsMassPerPoundForceHour, PoundsMassPerPoundForceHourTolerance);
                Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = SpecificFuelConsumption.ParseUnit("g/(kN·s)", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = SpecificFuelConsumption.ParseUnit("kg/(kgf·h)", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = SpecificFuelConsumption.ParseUnit("kg/(kN·s)", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = SpecificFuelConsumption.ParseUnit("lb/(lbf·h)", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(SpecificFuelConsumption.TryParseUnit("g/(kN·s)", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, parsedUnit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParseUnit("kg/(kgf·h)", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, parsedUnit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParseUnit("kg/(kN·s)", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond, parsedUnit);
            }

            {
                Assert.True(SpecificFuelConsumption.TryParseUnit("lb/(lbf·h)", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(SpecificFuelConsumptionUnit unit)
        {
            var inBaseUnits = SpecificFuelConsumption.From(1.0, SpecificFuelConsumption.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(SpecificFuelConsumptionUnit unit)
        {
            var quantity = SpecificFuelConsumption.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(SpecificFuelConsumptionUnit unit)
        {
            // See if there is a unit available that is not the base unit.
            var fromUnit = SpecificFuelConsumption.Units.FirstOrDefault(u => u != SpecificFuelConsumption.BaseUnit && u != SpecificFuelConsumptionUnit.Undefined);

            // If there is only one unit for the quantity, we must use the base unit.
            if (fromUnit == SpecificFuelConsumptionUnit.Undefined)
                fromUnit = SpecificFuelConsumption.BaseUnit;

            var quantity = SpecificFuelConsumption.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(gramperkilonewtonsecond.GramsPerKiloNewtonSecond).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(gramperkilonewtonsecond.KilogramsPerKilogramForceHour).GramsPerKiloNewtonSecond, KilogramsPerKilogramForceHourTolerance);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromKilogramsPerKiloNewtonSecond(gramperkilonewtonsecond.KilogramsPerKiloNewtonSecond).GramsPerKiloNewtonSecond, KilogramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(1, SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(gramperkilonewtonsecond.PoundsMassPerPoundForceHour).GramsPerKiloNewtonSecond, PoundsMassPerPoundForceHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificFuelConsumption v = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            AssertEx.EqualTolerance(-1, -v.GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(2, (SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(3)-v).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(2, (SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(10)/5).GramsPerKiloNewtonSecond, GramsPerKiloNewtonSecondTolerance);
            AssertEx.EqualTolerance(2, SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(10)/SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(5), GramsPerKiloNewtonSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificFuelConsumption oneGramPerKiloNewtonSecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            SpecificFuelConsumption twoGramsPerKiloNewtonSecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(2);

            Assert.True(oneGramPerKiloNewtonSecond < twoGramsPerKiloNewtonSecond);
            Assert.True(oneGramPerKiloNewtonSecond <= twoGramsPerKiloNewtonSecond);
            Assert.True(twoGramsPerKiloNewtonSecond > oneGramPerKiloNewtonSecond);
            Assert.True(twoGramsPerKiloNewtonSecond >= oneGramPerKiloNewtonSecond);

            Assert.False(oneGramPerKiloNewtonSecond > twoGramsPerKiloNewtonSecond);
            Assert.False(oneGramPerKiloNewtonSecond >= twoGramsPerKiloNewtonSecond);
            Assert.False(twoGramsPerKiloNewtonSecond < oneGramPerKiloNewtonSecond);
            Assert.False(twoGramsPerKiloNewtonSecond <= oneGramPerKiloNewtonSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.Equal(0, gramperkilonewtonsecond.CompareTo(gramperkilonewtonsecond));
            Assert.True(gramperkilonewtonsecond.CompareTo(SpecificFuelConsumption.Zero) > 0);
            Assert.True(SpecificFuelConsumption.Zero.CompareTo(gramperkilonewtonsecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.Throws<ArgumentException>(() => gramperkilonewtonsecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.Throws<ArgumentNullException>(() => gramperkilonewtonsecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            var b = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            var b = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            object b = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.True(v.Equals(SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1), GramsPerKiloNewtonSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificFuelConsumption.Zero, GramsPerKiloNewtonSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.False(gramperkilonewtonsecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificFuelConsumption gramperkilonewtonsecond = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1);
            Assert.False(gramperkilonewtonsecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificFuelConsumptionUnit.Undefined, SpecificFuelConsumption.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificFuelConsumptionUnit)).Cast<SpecificFuelConsumptionUnit>();
            foreach(var unit in units)
            {
                if (unit == SpecificFuelConsumptionUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificFuelConsumption.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 g/(kN·s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString());
                Assert.Equal("1 kg/(kgf·h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour).ToString());
                Assert.Equal("1 kg/(kN·s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond).ToString());
                Assert.Equal("1 lb/(lbf·h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString());
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

            Assert.Equal("1 g/(kN·s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString(swedishCulture));
            Assert.Equal("1 kg/(kgf·h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour).ToString(swedishCulture));
            Assert.Equal("1 kg/(kN·s)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond).ToString(swedishCulture));
            Assert.Equal("1 lb/(lbf·h)", new SpecificFuelConsumption(1, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s1"));
                Assert.Equal("0.12 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s2"));
                Assert.Equal("0.123 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s3"));
                Assert.Equal("0.1235 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s4"));
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
            Assert.Equal("0.1 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s1", culture));
            Assert.Equal("0.12 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s2", culture));
            Assert.Equal("0.123 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s3", culture));
            Assert.Equal("0.1235 g/(kN·s)", new SpecificFuelConsumption(0.123456, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SpecificFuelConsumption)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SpecificFuelConsumptionUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(QuantityType.SpecificFuelConsumption, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(SpecificFuelConsumption.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(SpecificFuelConsumption.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(1.0);
            Assert.Equal(new {SpecificFuelConsumption.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(value);
            Assert.Equal(SpecificFuelConsumption.FromGramsPerKiloNewtonSecond(-value), -quantity);
        }
    }
}
