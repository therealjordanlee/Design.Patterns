using Singleton.Pattern;

var classicSingleton1 = ClassicSingleton.GetInstance();
var classicSingleton2 = ClassicSingleton.GetInstance();
var classicSingleton3 = ClassicSingleton.GetInstance();

classicSingleton1.PrintValue();
classicSingleton2.PrintValue();
classicSingleton3.PrintValue();


var enumSingleton1 = SingletonEnum.UNIQUE_INSTANCE;
var enumSingleton2 = SingletonEnum.UNIQUE_INSTANCE;
var enumSingleton3 = SingletonEnum.UNIQUE_INSTANCE;

enumSingleton1.PrintValue();
enumSingleton2.PrintValue();
enumSingleton3.PrintValue();