using Command.Implementation.Commands;
using Command.Implementation.Invoker;
using Command.Implementation.Receivers;

// Kitchen light is the receiver
var kitchenLight = new Light("Kitchen Light");

// Concrete commands are created,
// specifying the receiver
var turnOnKitchenLight = new LightOnCommand(kitchenLight);
var turnOffKitchenLight = new LightOffCommand(kitchenLight);

// Remote control is the invoker
var remoteControl = new RemoteControl();

// Invoker sets the command to be executed
remoteControl.SetCommand(0, turnOnKitchenLight, turnOffKitchenLight);

// Invoker invokes the command
remoteControl.ExecuteOn(0);
remoteControl.ExecuteOff(0);
