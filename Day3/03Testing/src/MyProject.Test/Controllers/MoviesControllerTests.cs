using Microsoft.AspNet.Mvc;
using Moq;
using MyProject.Controllers;
using MyProject.Models;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using Microsoft.AspNet.Mvc.ModelBinding;

namespace MyProject.Test.Controllers
{
    public class MoviesControllerTests
    {
        [Fact]
        public void IndexTest()
        {
            // Arrange
            var movies = new List<Movie>
            {
                new Movie { Id=1, Title="Star Wars", Director="George"}

            };
            var mockRepository = new Mock<IRepository>();
            mockRepository.Setup(r => r.ListMovies()).Returns(movies);
            var controller = new MoviesController(mockRepository.Object);

            // this is a workaround for a bug
            controller.ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());

            // Act
            var result = (ViewResult)controller.Index();
            var model = (IList<Movie>)result.ViewData.Model;

            // Assert
            Assert.Equal("Star Wars", model.First().Title);
        }


    }
}