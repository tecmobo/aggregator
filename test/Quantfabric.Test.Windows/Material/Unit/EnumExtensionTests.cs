﻿using Material.Framework.Extensions;
using Material.Framework.Metadata;
using Xunit;

namespace Foundations.Test.Core
{
    [Trait("Category", "Continuous")]
    public class EnumExtensionTests
    {
        [Fact]
        public void UsingToStringOnEnumWithNoDescriptionGivesTheStringRepresentationOfTheName()
        {
            var expected = "NoDescription";

            var actual = TestEnum.NoDescription.EnumToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UsingToStringOnEnumWithDescriptionGivesDescription()
        {
            var expected = "Something";

            var actual = TestEnum.Description.EnumToString();

            Assert.Equal(expected, actual);
        }
    }

    public enum TestEnum
    {
        NoDescription,
        [Description("Something")]
        Description
    }
}
