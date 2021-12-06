using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotnetRPGGame.DataBaseConnection;

namespace TestProject2;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        MySql mySql = new MySql();
        mySql.ConnectionMySql();
    }
}