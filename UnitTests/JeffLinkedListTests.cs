using Jeffrol.DataStructures;
using NUnit.Framework;
using System.Collections.Generic;


namespace UnitTests;

public class JeffLinkedListTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestLinkedListAddToHead()
    {
        List<int> expectedResult = new List<int>() {21, 22, 23};

        var ll = new JeffLinkedList<int>();
        ll.addValueAtHead(23);
        ll.addValueAtHead(22);
        ll.addValueAtHead(21);

        var result = ll.ToList();

        Assert.AreEqual(result, expectedResult);
    }
}