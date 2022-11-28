using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.VehicleTests
{
    public class VehicleTests
    {
        [Fact]
        public void VehicleSpeedUp()
        {
            var vehicle = new Veiculo();
            vehicle.Acelerar(10);

            Assert.Equal(100, vehicle.VelocidadeAtual);
        }

        [Fact]
        public void VehicleSpeedDown()
        {
            var vehicle = new Veiculo();
            vehicle.Frear(10);

            Assert.Equal(-150, vehicle.VelocidadeAtual);
        }

        [Fact]
        public void VehicleTypeTest()
        {
            var vehicle = new Veiculo();
            Assert.Equal(TipoVeiculo.Automovel, vehicle.Tipo);
        }

        [Fact(Skip = "Method not implemented yet")]
        public void ValidateVehicleOwner()
        {
            var vehicle = new Veiculo();
        }
    }
}
