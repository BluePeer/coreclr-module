using System;
using AltV.Net.Elements.Entities;

namespace AltV.Net.Elements.Factories
{
    public class PlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(ICore core, IntPtr playerPointer, uint id)
        {
            return new Player(core, playerPointer, id);
        }
    }
}