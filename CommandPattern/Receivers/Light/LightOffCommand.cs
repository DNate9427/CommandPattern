using CommandPattern.Interfaces;

namespace CommandPattern.Receivers
{
    internal class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
