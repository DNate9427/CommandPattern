// See https://aka.ms/new-console-template for more information

using CommandPattern.Invoker;
using CommandPattern.Receivers;

SimpleRemoteControl remote = new SimpleRemoteControl();

Light light = new Light();
GarageDoor garageDoor = new GarageDoor();

GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
LightOnCommand lightOn = new LightOnCommand(light);

remote.SetCommand(lightOn);
remote.ButtonWasPressed();

remote.SetCommand(garageDoorOpenCommand);
remote.ButtonWasPressed();