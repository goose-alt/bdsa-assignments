using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Assignment0.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            
            // Assert
            Assert.Equal("Hello, World!", output);
        }
    }
}