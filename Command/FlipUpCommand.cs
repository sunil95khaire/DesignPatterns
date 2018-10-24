using System;

namespace Command
{
    public class FlipUpCommand : ICommand
    {
        Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
