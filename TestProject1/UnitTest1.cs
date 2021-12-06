using System;
using NUnit.Framework;
using DotnetRPGGame.DataBaseConnection;
namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        MySql mySql = new MySql();
        mySql.ConnectionMySql();
        Assert.Pass();
    }
}