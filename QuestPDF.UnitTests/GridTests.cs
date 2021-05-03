﻿using FluentAssertions;
using NUnit.Framework;
using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.UnitTests.TestEngine;

namespace QuestPDF.UnitTests
{
    /*[TestFixture]
    public class GridTests
    {
        #region Alignment
        
        [Test]
        public void AlignLeft()
        {
            // arrange
            var structure = new Container();

            var childA = TestPlan.CreateUniqueElement();
            var childB = TestPlan.CreateUniqueElement();
            var childC = TestPlan.CreateUniqueElement();
            var childD = TestPlan.CreateUniqueElement();
            var childE = TestPlan.CreateUniqueElement();

            // act
            structure
                .Grid(grid =>
                {
                    grid.AlignLeft();
                    
                    grid.Item(6).Element(childA);
                    grid.Item(4).Element(childB);
                    grid.Item(4).Element(childC);
                    grid.Item(2).Element(childD);
                    grid.Item(8).Element(childE);
                });
            
            // assert
            var expected = new Container();
            
            expected.Stack(stack =>
            {
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(6).Element(childA);
                    row.RelativeColumn(4).Element(childB);
                    row.RelativeColumn(2).Element(Empty.Instance);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(4).Element(childC);
                    row.RelativeColumn(2).Element(childD);
                    row.RelativeColumn(6).Element(Empty.Instance);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(8).Element(childE);
                    row.RelativeColumn(4).Element(Empty.Instance);
                });
            });
            
            structure.Child.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering().IncludingAllRuntimeProperties());
        }
        
        [Test]
        public void AlignCenter()
        {
            // arrange
            var structure = new Container();

            var childA = TestPlan.CreateUniqueElement();
            var childB = TestPlan.CreateUniqueElement();
            var childC = TestPlan.CreateUniqueElement();
            var childD = TestPlan.CreateUniqueElement();
            var childE = TestPlan.CreateUniqueElement();

            // act
            structure
                .Grid(grid =>
                {
                    grid.AlignCenter();
                    
                    grid.Item(6).Element(childA);
                    grid.Item(4).Element(childB);
                    grid.Item(4).Element(childC);
                    grid.Item(2).Element(childD);
                    grid.Item(8).Element(childE);
                });
            
            // assert
            var expected = new Container();
            
            expected.Stack(stack =>
            {
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(1).Element(Empty.Instance);
                    row.RelativeColumn(6).Element(childA);
                    row.RelativeColumn(4).Element(childB);
                    row.RelativeColumn(1).Element(Empty.Instance);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(3).Element(Empty.Instance);
                    row.RelativeColumn(4).Element(childC);
                    row.RelativeColumn(2).Element(childD);
                    row.RelativeColumn(3).Element(Empty.Instance);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(2).Element(Empty.Instance);
                    row.RelativeColumn(8).Element(childE);
                    row.RelativeColumn(2).Element(Empty.Instance);
                });
            });

            structure.Child.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering().IncludingAllRuntimeProperties());
        }
        
        [Test]
        public void AlignRight()
        {
            // arrange
            var structure = new Container();

            var childA = TestPlan.CreateUniqueElement();
            var childB = TestPlan.CreateUniqueElement();
            var childC = TestPlan.CreateUniqueElement();
            var childD = TestPlan.CreateUniqueElement();
            var childE = TestPlan.CreateUniqueElement();

            // act
            structure
                .Grid(grid =>
                {
                    grid.AlignRight();
                    
                    grid.Item(6).Element(childA);
                    grid.Item(4).Element(childB);
                    grid.Item(4).Element(childC);
                    grid.Item(2).Element(childD);
                    grid.Item(8).Element(childE);
                });
            
            // assert
            var expected = new Container();
            
            expected.Container().Stack(stack =>
            {
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(2).Element(Empty.Instance);
                    row.RelativeColumn(6).Element(childA);
                    row.RelativeColumn(4).Element(childB);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(6).Element(Empty.Instance);
                    row.RelativeColumn(4).Element(childC);
                    row.RelativeColumn(2).Element(childD);
                });
                
                stack.Item().Row(row =>
                {
                    row.RelativeColumn(4).Element(Empty.Instance);
                    row.RelativeColumn(8).Element(childE);
                });
            });
            
            structure.Child.Should().BeEquivalentTo(expected, o => o.WithStrictOrdering().IncludingAllRuntimeProperties());
        }
        
        #endregion
    }*/
}