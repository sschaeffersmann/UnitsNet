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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricResistivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricResistivityTestsBase
    {
        protected abstract double MicroohmMetersInOneOhmMeter { get; }
        protected abstract double MilliohmMetersInOneOhmMeter { get; }
        protected abstract double NanoohmMetersInOneOhmMeter { get; }
        protected abstract double OhmMetersInOneOhmMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MicroohmMetersTolerance { get { return 1e-5; } }
        protected virtual double MilliohmMetersTolerance { get { return 1e-5; } }
        protected virtual double NanoohmMetersTolerance { get { return 1e-5; } }
        protected virtual double OhmMetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void OhmMeterToElectricResistivityUnits()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            AssertEx.EqualTolerance(MicroohmMetersInOneOhmMeter, ohmmeter.MicroohmMeters, MicroohmMetersTolerance);
            AssertEx.EqualTolerance(MilliohmMetersInOneOhmMeter, ohmmeter.MilliohmMeters, MilliohmMetersTolerance);
            AssertEx.EqualTolerance(NanoohmMetersInOneOhmMeter, ohmmeter.NanoohmMeters, NanoohmMetersTolerance);
            AssertEx.EqualTolerance(OhmMetersInOneOhmMeter, ohmmeter.OhmMeters, OhmMetersTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricResistivity.From(1, ElectricResistivityUnit.MicroohmMeter).MicroohmMeters, MicroohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.From(1, ElectricResistivityUnit.MilliohmMeter).MilliohmMeters, MilliohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.From(1, ElectricResistivityUnit.NanoohmMeter).NanoohmMeters, NanoohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.From(1, ElectricResistivityUnit.OhmMeter).OhmMeters, OhmMetersTolerance);
        }

        [Fact]
        public void As()
        {
            var ohmmeter = ElectricResistivity.FromOhmMeters(1);
            AssertEx.EqualTolerance(MicroohmMetersInOneOhmMeter, ohmmeter.As(ElectricResistivityUnit.MicroohmMeter), MicroohmMetersTolerance);
            AssertEx.EqualTolerance(MilliohmMetersInOneOhmMeter, ohmmeter.As(ElectricResistivityUnit.MilliohmMeter), MilliohmMetersTolerance);
            AssertEx.EqualTolerance(NanoohmMetersInOneOhmMeter, ohmmeter.As(ElectricResistivityUnit.NanoohmMeter), NanoohmMetersTolerance);
            AssertEx.EqualTolerance(OhmMetersInOneOhmMeter, ohmmeter.As(ElectricResistivityUnit.OhmMeter), OhmMetersTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var ohmmeter = ElectricResistivity.FromOhmMeters(1);

            var microohmmeterQuantity = ohmmeter.ToUnit(ElectricResistivityUnit.MicroohmMeter);
            AssertEx.EqualTolerance(MicroohmMetersInOneOhmMeter, (double)microohmmeterQuantity.Value, MicroohmMetersTolerance);
            Assert.Equal(ElectricResistivityUnit.MicroohmMeter, microohmmeterQuantity.Unit);

            var milliohmmeterQuantity = ohmmeter.ToUnit(ElectricResistivityUnit.MilliohmMeter);
            AssertEx.EqualTolerance(MilliohmMetersInOneOhmMeter, (double)milliohmmeterQuantity.Value, MilliohmMetersTolerance);
            Assert.Equal(ElectricResistivityUnit.MilliohmMeter, milliohmmeterQuantity.Unit);

            var nanoohmmeterQuantity = ohmmeter.ToUnit(ElectricResistivityUnit.NanoohmMeter);
            AssertEx.EqualTolerance(NanoohmMetersInOneOhmMeter, (double)nanoohmmeterQuantity.Value, NanoohmMetersTolerance);
            Assert.Equal(ElectricResistivityUnit.NanoohmMeter, nanoohmmeterQuantity.Unit);

            var ohmmeterQuantity = ohmmeter.ToUnit(ElectricResistivityUnit.OhmMeter);
            AssertEx.EqualTolerance(OhmMetersInOneOhmMeter, (double)ohmmeterQuantity.Value, OhmMetersTolerance);
            Assert.Equal(ElectricResistivityUnit.OhmMeter, ohmmeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            AssertEx.EqualTolerance(1, ElectricResistivity.FromMicroohmMeters(ohmmeter.MicroohmMeters).OhmMeters, MicroohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.FromMilliohmMeters(ohmmeter.MilliohmMeters).OhmMeters, MilliohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.FromNanoohmMeters(ohmmeter.NanoohmMeters).OhmMeters, NanoohmMetersTolerance);
            AssertEx.EqualTolerance(1, ElectricResistivity.FromOhmMeters(ohmmeter.OhmMeters).OhmMeters, OhmMetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricResistivity v = ElectricResistivity.FromOhmMeters(1);
            AssertEx.EqualTolerance(-1, -v.OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistivity.FromOhmMeters(3)-v).OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistivity.FromOhmMeters(10)/5).OhmMeters, OhmMetersTolerance);
            AssertEx.EqualTolerance(2, ElectricResistivity.FromOhmMeters(10)/ElectricResistivity.FromOhmMeters(5), OhmMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricResistivity oneOhmMeter = ElectricResistivity.FromOhmMeters(1);
            ElectricResistivity twoOhmMeters = ElectricResistivity.FromOhmMeters(2);

            Assert.True(oneOhmMeter < twoOhmMeters);
            Assert.True(oneOhmMeter <= twoOhmMeters);
            Assert.True(twoOhmMeters > oneOhmMeter);
            Assert.True(twoOhmMeters >= oneOhmMeter);

            Assert.False(oneOhmMeter > twoOhmMeters);
            Assert.False(oneOhmMeter >= twoOhmMeters);
            Assert.False(twoOhmMeters < oneOhmMeter);
            Assert.False(twoOhmMeters <= oneOhmMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            Assert.Equal(0, ohmmeter.CompareTo(ohmmeter));
            Assert.True(ohmmeter.CompareTo(ElectricResistivity.Zero) > 0);
            Assert.True(ElectricResistivity.Zero.CompareTo(ohmmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            Assert.Throws<ArgumentException>(() => ohmmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            Assert.Throws<ArgumentNullException>(() => ohmmeter.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricResistivity v = ElectricResistivity.FromOhmMeters(1);
            Assert.True(v.Equals(ElectricResistivity.FromOhmMeters(1), OhmMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricResistivity.Zero, OhmMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            Assert.False(ohmmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricResistivity ohmmeter = ElectricResistivity.FromOhmMeters(1);
            Assert.False(ohmmeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricResistivityUnit.Undefined, ElectricResistivity.Units);
        }

    }
}
