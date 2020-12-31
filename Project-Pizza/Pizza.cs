using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Pizza {
    public class Pizza : IPizza {

        public string BuscarTipoPizza() {

            var pizza = "Esta é uma Pizza normal";
            return pizza;
        }
    }
}
