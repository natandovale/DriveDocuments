using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.DTOs;
using DriveDocuments.Domain.DTOs.Interface;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler;
using DriveDocuments.Domain.Repositories.Interfaces;
using DriveDocuments.Domain.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DriveDocuments.Tests
{
    public class TestHandlerDeleteComprovante
    {
        public readonly IComprovanteRepository _comprovanteRepository;

        public readonly DeleteComprovanteHandler _sut;

        public TestHandlerDeleteComprovante()
        {
            _comprovanteRepository = Substitute.For<IComprovanteRepository>();
            _sut = new DeleteComprovanteHandler(_comprovanteRepository);
        }

        [Fact]
        public void TestarMetodoHandlerDelete()
        {
            //Arrange
            InformacoesImgemBlobsDTO dto = new("25d4e401-d974-4a2e-a59b-6e7a2e6bd4d2.jpg");
            Comprovante comprovante = new(1, dto.Nome);
            DeleteComprovanteRequest command = new() { Id = 1 };
            _comprovanteRepository.Get(command.Id).Returns(comprovante);
            _comprovanteRepository.Delete(command.Id);

            //Act
            _sut.Handler(command);

            //Assert
            //_sut.Received().GetImage(command.ImagemCaminhoDoArquivo);
        }
    }
}
