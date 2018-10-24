using System;

namespace Command
{
    public class FlipDownCommand : ICommand
    {
        Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
