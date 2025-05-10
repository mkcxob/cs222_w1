using static System.Console;

string[] numberTypes = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};
int[] byteSize = {sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), 
                sizeof(ulong),  sizeof(float), sizeof(double), sizeof(decimal)};
object[] minValue = {sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, 
                    long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue};
object[] maxValue = {sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, 
                    long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue};

string dashedLine = new string('-', 95);

WriteLine(dashedLine);
WriteLine("{0,-10} {1,-20} {2,30} {3,32}", "Type", "Byte(s) of memory", "Min", "Max");
WriteLine(dashedLine);
for (int i = 0; i < numberTypes.Length; i ++)
    WriteLine("{0,-10} {1,-20} {2,30} {3,32}", numberTypes[i], byteSize[i], minValue[i], maxValue[i]);
WriteLine(dashedLine); 