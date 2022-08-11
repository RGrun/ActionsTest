

using Newtonsoft.Json;

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}

TestObj testObj = new TestObj()
{
    TestOne = "1",
    TestTwo = "two",
    TestThree = 3,
};

Console.WriteLine(JsonConvert.SerializeObject(testObj));

Console.ReadLine();

class TestObj
{
    public string TestOne;
    public string TestTwo;
    public int TestThree;
}