using DriveDocuments.Domain.Repositories.Interfaces;
using DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler;
using Xunit;
using NSubstitute;
using System.Threading.Tasks;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Commands.RequestComprovante;
using System;

namespace DriveDocuments.Tests
{
    public class TestHandlerCreateComprovante
    {
        public readonly IComprovanteRepository _comprovanteRepository;

        public readonly CreateComprovanteHandler _sut;

        public TestHandlerCreateComprovante()
        {
            _comprovanteRepository = Substitute.For<IComprovanteRepository>();
            _sut = new CreateComprovanteHandler(_comprovanteRepository);
        }

        [Fact]
        public void TestarMetodoHandlerCreate()
        {
            //Arrange
            Comprovante comprovante = null;
            CreateComprovanteRequest command = new() { Nome = "Boleto", Beneficiario = "Banco", ImagemBase64 = "" };
            _comprovanteRepository.Create(comprovante);

            //Act
            _sut.Handler(command);

            //Assert
            //_sut.Received().GetImage(command.ImagemCaminhoDoArquivo);
        }
    }
}
