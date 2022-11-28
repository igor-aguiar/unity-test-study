using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class ParkingLotTest
    {
        [Fact]
        public void ValidateParkingLotIncoming()
        {
            var parkingLot = new Patio();
            
            var vehicle = new Veiculo();
            vehicle.Placa = "asd-9999";
            vehicle.Proprietario = "Igor Aguiar";
            vehicle.Cor = "Verde";

            parkingLot.RegistrarEntradaVeiculo(vehicle);
            parkingLot.RegistrarSaidaVeiculo(vehicle.Placa);

            double totalIncoming = parkingLot.TotalFaturado();

            Assert.Equal(2, totalIncoming);

        }
        [Theory]
        [InlineData("Igor Aguiar", "abc-1234", "verde", TipoVeiculo.Motocicleta)]
        [InlineData("Rosa Linda", "wav-5576", "vermelho", TipoVeiculo.Motocicleta)]
        [InlineData("William Ducker", "asf-2243", "rosa", TipoVeiculo.Automovel)]
        [InlineData("Pedro Marins", "pov-4321", "amarelo", TipoVeiculo.Automovel)]
        public void ValidateParkingLotIncomingManyVehicles(string name, string plate, string color, TipoVeiculo tipoVeiculo)
        {
            var parkingLot = new Patio();
            var vehicle = new Veiculo();
            vehicle.Placa = plate;
            vehicle.Proprietario = name;
            vehicle.Cor = color;
            vehicle.Tipo = tipoVeiculo;

            parkingLot.RegistrarEntradaVeiculo(vehicle);
            parkingLot.RegistrarSaidaVeiculo(vehicle.Placa);

            double totalIncoming = parkingLot.TotalFaturado();
            if (vehicle.Tipo == TipoVeiculo.Motocicleta)
            {
                Assert.Equal(1, totalIncoming);
            } else
            {
                Assert.Equal(2, totalIncoming);
            }
            
        }
    }
}
