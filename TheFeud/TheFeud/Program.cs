using IField;
using McDroid;
using McPig = McDroid.Pig;

Sheep sheep = new Sheep();
Cow cow = new Cow();
IField.Pig pigOne = new IField.Pig();
McPig pigTwo = new McPig();

namespace IField
{
    public class Sheep { }
    public class Pig { }
}

namespace McDroid
{
    public class Cow { }
    public class Pig { }
}