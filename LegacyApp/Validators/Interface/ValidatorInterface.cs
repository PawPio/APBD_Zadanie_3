using System;

namespace LegacyApp.Validators.Interface;

public interface ValidatorInterface
{
    public bool ValidateFullName(string firstName, string lastName);
    public bool ValidateEmail(string email);
    public bool ValidateAge(DateTime dateOfBirth);
}