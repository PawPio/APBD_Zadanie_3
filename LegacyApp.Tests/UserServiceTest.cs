using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LegacyApp.Tests;

[TestClass]
public class UserServiceTest
{
    [TestMethod]
    public void AddUser_ValidatedData()
    {
        var userService = new UserService();
        string firstName = "John";
        string lastName = "Doe";
        string email = "johndoe@gmail.com";
        DateTime dateOfBirth = new DateTime(1982, 3, 21);
        int clientId = 1;
        
        bool result = userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void AddUser_InvalidFirstName()
    {
        var userService = new UserService();
        string firstName = "";
        string lastName = "Doe";
        string email = "johndoe@gmail.com";
        DateTime dateOfBirth = new DateTime(1982, 3, 21);
        int clientId = 1;
        
        bool result = userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void AddUser_InvalidLastName()
    {
        var userService = new UserService();
        string firstName = "John";
        string lastName = "";
        string email = "johndoe@gmail.com";
        DateTime dateOfBirth = new DateTime(1982, 3, 21);
        int clientId = 1;
        
        bool result = userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void AddUser_InvalidEmail()
    {
        var userService = new UserService();
        string firstName = "John";
        string lastName = "Doe";
        string email = "johndoe";
        DateTime dateOfBirth = new DateTime(1982, 3, 21);
        int clientId = 1;
        
        bool result = userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void AddUser_UnderAgeUser()
    {
        var userService = new UserService();
        string firstName = "John";
        string lastName = "Doe";
        string email = "johndoe@gmail.com";
        DateTime dateOfBirth = new DateTime(2017, 3, 21);
        int clientId = 1;
        
        bool result = userService.AddUser(firstName, lastName, email, dateOfBirth, clientId);
        
        Assert.IsTrue(result);
    }
}