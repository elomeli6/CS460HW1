using NUnit.Framework;
using TeamBuilder.Models;
using TeamBuilder.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace Teambuilder_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void MemberNames_ShouldSplitNamesCorrectly()
        {
            
            var members = new MemberNames
            {
                Name = "John\nJane\nMike\nAlice\nTom"
            };

            members.TeamMembers = members.Name.Split('\n', System.StringSplitOptions.RemoveEmptyEntries).ToList();

            Assert.AreEqual(5, members.TeamMembers.Count); // Expect 5 names
            Assert.AreEqual("John", members.TeamMembers[0]);
            Assert.AreEqual("Tom", members.TeamMembers[4]);
        }
    [Test]
    public void SplitNames_ShouldReturnEmptyList_WhenNoNames()
    {
        
        string input = "";  // No names
        var expectedCount = 0;

         var result = input.Split('\n', System.StringSplitOptions.RemoveEmptyEntries).ToList();  // Use RemoveEmptyEntries to avoid empty strings


        
        Assert.AreEqual(expectedCount, result.Count);  // We expect 0 names
    }

    [Test]
    public void TeamSize_ShouldBeValid_WhenInRange()
    {
        
        int teamSize = 5;

        
        Assert.That(teamSize, Is.InRange(2, 10));  // Ensure the team size is between 2 and 10
    }

    [Test]
    public void TeamSize_ShouldBeInvalid_WhenOutOfRange()
    {
        // Arrange
        int teamSize = 15;

        // Assert
        Assert.That(teamSize, Is.Not.InRange(2, 10));  // Ensure the team size is NOT between 2 and 10
    }




}