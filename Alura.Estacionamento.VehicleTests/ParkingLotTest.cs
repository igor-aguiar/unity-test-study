using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class ParkingLotTest
    {
        [Fact]
        public void ParkingLotIncoming()
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
    }
}
