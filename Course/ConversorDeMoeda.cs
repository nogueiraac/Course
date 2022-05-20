using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class ConversorDeMoeda {

        public static double CalcularIof(double valor) {
            valor = valor + ((valor / 100) * 6);
            return valor;
        }
        public static double ConversaoParaReais(double cotacaoDoDolar, double valorDolar) {
            return CalcularIof(cotacaoDoDolar * valorDolar);
        }
        
    }
}
