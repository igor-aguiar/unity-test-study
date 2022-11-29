using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.VehicleTests
{
    public class VehicleTests : IDisposable
    {
        private ITestOutputHelper OutputHelper { get; }
        private Veiculo vehicle;

        public VehicleTests(ITestOutputHelper _output) 
        {
            OutputHelper = _output;
            OutputHelper.WriteLine("Execução do  construtor.");
            vehicle = new Veiculo();
        }

        [Fact]
        public void VehicleSpeedUp()
        {
            //var vehicle = new Veiculo();
            vehicle.Acelerar(10);

            Assert.Equal(100, vehicle.VelocidadeAtual);
        }

        [Fact]
        public void VehicleSpeedDown()
        {
            //var vehicle = new Veiculo();
            vehicle.Frear(10);

            Assert.Equal(-150, vehicle.VelocidadeAtual);
        }

        [Fact]
        public void VehicleTypeTest()
        {
            //var vehicle = new Veiculo();
            Assert.Equal(TipoVeiculo.Automovel, vehicle.Tipo);
        }

        [Fact(Skip = "Method not implemented yet")]
        public void ValidateVehicleOwner()
        {
            //var vehicle = new Veiculo();
        }

        [Fact]
        public void VehicleData()
        {
            vehicle.Proprietario = "Igor Aguiar";
            vehicle.Placa = "ASD-9898";
            vehicle.Cor = "Verde";
            vehicle.Modelo = "Fusca";

            string data = vehicle.ToString();

            Assert.Contains("Tipo do Veículo: Automovel", data);
        }

        [Fact]
        public void TestPlateException()
        {
            string plate = "asd+9999";

            var message = Assert.Throws<FormatException>(
                () => new Veiculo().Placa = plate);

            Assert.Equal("O 4° caractere deve ser um hífen", message.Message);
        }

        public void Dispose()
        {
            OutputHelper.WriteLine("Garbage collector has passed here");
        }
    }
}
