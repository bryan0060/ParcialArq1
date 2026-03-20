using Xunit; 
using CapaNegocio;
using CapaDatosPrueba;

namespace PruebasCredito
{
    public class LogicaCreditoTests
    {
        // 1. Prueba: Plazo fuera de rango
        [Fact] 
        public void Evaluar_PlazoInvalido_RetornaNegado()
        {
            // Arrange
            var mockRepo = new DatosMemoria();
            var logica = new LogicaCredito(mockRepo);
            var solicitud = new SolicitudCredito { PlazoSolicitado = 80 }; // Mayor a 72

            // Act
            var resultado = logica.Evaluar(solicitud);

            // Assert
            Assert.Equal("Negado: El plazo debe ser entre 1 y 72 meses.", resultado);
        }

        // 2. Prueba: Balanza negativa
        [Fact]
        public void Evaluar_BalanzaNegativa_RetornaNegado()
        {
            // Arrange
            var mockRepo = new DatosMemoria();
            var logica = new LogicaCredito(mockRepo);
            var solicitud = new SolicitudCredito
            {
                PlazoSolicitado = 12,
                IngresosTotales = 1000,
                EgresosTotales = 1500 // Balanza = -500
            };

            // Act
            var resultado = logica.Evaluar(solicitud);

            // Assert
            Assert.Equal("Negado: La balanza es cero o negativa.", resultado);
        }

        // 3. Prueba: Relación Crédito/Balanza mayor a 0.95
        [Fact]
        public void Evaluar_RelacionMuyAlta_RetornaNegado()
        {
            // Arrange
            var mockRepo = new DatosMemoria();
            var logica = new LogicaCredito(mockRepo);
            var solicitud = new SolicitudCredito
            {
                PlazoSolicitado = 10,
                IngresosTotales = 2000,
                EgresosTotales = 1000, // Balanza = 1000
                MontoSolicitado = 9600 // Cuota = 960. Relación = 0.96 (>= 0.95)
            };

            // Act
            var resultado = logica.Evaluar(solicitud);

            // Assert
            Assert.Equal("Negado: El credito debe tener una relación igual o superior a 0.95.", resultado);
        }

        // 4. Prueba: Escenario Ideal (Aprobado) usando el Mock
        [Fact]
        public void Evaluar_RelacionBajaYPuntajeAlto_RetornaAprobado()
        {
            // Arrange
            var mockRepo = new DatosMemoria();
            var logica = new LogicaCredito(mockRepo);
            var solicitud = new SolicitudCredito
            {
                TipoDoc = "CC",
                NroDoc = "1001", // En DatosMemoria este tiene 850 puntos
                PlazoSolicitado = 10,
                IngresosTotales = 2000,
                EgresosTotales = 1000, // Balanza = 1000
                MontoSolicitado = 3000 // Cuota = 300. Relación = 0.3 (< 0.4). Exige puntaje >= 400.
            };

            // Act
            var resultado = logica.Evaluar(solicitud);

            // Assert
            Assert.Equal("Aprobado", resultado);
        }

        // 5. Prueba: Rechazado por bajo puntaje en la central de riesgo
        [Fact]
        public void Evaluar_RelacionMediaYPuntajeBajo_RetornaNegado()
        {
            // Arrange
            var mockRepo = new DatosMemoria();
            var logica = new LogicaCredito(mockRepo);
            var solicitud = new SolicitudCredito
            {
                TipoDoc = "CE",
                NroDoc = "1003", // En DatosMemoria este tiene 200 puntos
                PlazoSolicitado = 10,
                IngresosTotales = 2000,
                EgresosTotales = 1000, // Balanza = 1000
                MontoSolicitado = 5000 // Cuota = 500. Relación = 0.5. Exige puntaje >= 600.
            };

            // Act
            var resultado = logica.Evaluar(solicitud);

            // Assert
            Assert.Equal("Negado: Puntaje menor a 600.", resultado);
        }
    }
}