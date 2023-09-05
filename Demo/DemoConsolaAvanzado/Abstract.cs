using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    abstract class FiguraGeometrica
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }

    class Cuadrado : FiguraGeometrica
    {
        readonly decimal lado;
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public override decimal area()
        {
            return lado * lado;
        }

        public override decimal perimetro()
        {
            return lado * 4;
        }
    }

    class Rectangulo : FiguraGeometrica
    {
        readonly decimal base_, altura;
        public Rectangulo(decimal base_, decimal altura)
        {
            this.base_ = base_;
            this.altura = altura;
        }

        public override decimal area()
        {
            return base_ * altura;
        }

        public override decimal perimetro()
        {
            return base_ * 2 + altura * 2;
        }
    }
}
