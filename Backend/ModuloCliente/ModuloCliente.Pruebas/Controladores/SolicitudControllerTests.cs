using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using ModuloCliente.API.Controladores;
using ModuloCliente.API.DTOs.Solicitud;
using ModuloCliente.BC.Enumerados;
using ModuloCliente.BC.Modelos;
using ModuloCliente.BW.Interfaces.BW;
using Moq;

namespace ModuloCliente.Pruebas.Controladores
{
    public class SolicitudControllerTests
    {

        private readonly Mock<IGestionarSolicitudBW> _mockGestionarSolicitudBW;
        private readonly SolicitudController _controller;

        public SolicitudControllerTests()
        {
            _mockGestionarSolicitudBW = new Mock<IGestionarSolicitudBW>();
            _controller = new SolicitudController(_mockGestionarSolicitudBW.Object);
        }

        [Fact]
        public async Task RealizarSolicitud_DeberiaRetornarCreatedConSolicitud()
        {
            // Arrange
            var solicitudDTO = new SolicitudRegistroDTO
            {
                Pedido = "Papas fritas",
                MesaId = 1,
                Tipo = TipoSolicitud.PEDIR_ATENCION
            };

            var solicitudEsperada = new Solicitud
            {
                Pedido = solicitudDTO.Pedido,
                MesaId = solicitudDTO.MesaId,
                Tipo = solicitudDTO.Tipo
            };

            _mockGestionarSolicitudBW
                .Setup(service => service.RealizarSolicitud(It.IsAny<Solicitud>()))
                .ReturnsAsync(true);

            // Act
            var resultado = await _controller.RealizarSolicitud(solicitudDTO);

            // Assert
            var createdResult = resultado.Should().BeOfType<CreatedResult>().Subject;
            createdResult.Value.Should().BeEquivalentTo(solicitudEsperada);
        }

    }
    }
