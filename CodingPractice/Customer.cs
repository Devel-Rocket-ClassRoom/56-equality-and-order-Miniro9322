using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Customer
{
    public string LastName { get; private set; }
    public string FirstName { get; private set; }

    public Customer(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }
}