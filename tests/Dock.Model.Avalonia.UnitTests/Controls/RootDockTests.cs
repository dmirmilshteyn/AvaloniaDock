﻿using Dock.Model.Controls;
using Xunit;

namespace Dock.Model.Avalonia.UnitTests.Controls
{
    public class RootDockTests
    {
        [Fact]
        public void RootDock_Ctor()
        {
            var actual = new RootDock();
            Assert.NotNull(actual);
        }
    }
}
