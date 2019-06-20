using System;
using System.collection.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern 
{
    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;
        public Client(AbstractFactorty factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }

    public abstract class AbstractFactoryPattern
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    public class ConcreateFactoryA : AbstractFactoryPattern{
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractFactoryB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public abstract class AbstractProductA { }
    public class ProductA1 : AbstractProductA { }
    public class ProductA2 : AbstractProductA { }
    public class ProductA2 : AbstractProductA { }
    public abstract class AbstractProductB { }
    public class productB1 : AbstractProductB { }
    public class ProductB2 : AbstractProductB { }
}