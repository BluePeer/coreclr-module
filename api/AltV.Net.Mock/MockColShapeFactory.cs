using System;
using AltV.Net.Elements.Entities;

namespace AltV.Net.Mock
{
    public class MockColShapeFactory<TEntity> : IBaseObjectFactory<IColShape> where TEntity : IColShape
    {
        private readonly IBaseObjectFactory<IColShape> colShapeFactory;

        public MockColShapeFactory(IBaseObjectFactory<IColShape> colShapeFactory)
        {
            this.colShapeFactory = colShapeFactory;
        }

        public IColShape Create(ICore core, IntPtr entityPointer, uint id)
        {
            return MockDecorator<TEntity, IColShape>.Create((TEntity)colShapeFactory.Create(core, entityPointer, id),
                new MockColShape(core, entityPointer, id));
        }
    }
}