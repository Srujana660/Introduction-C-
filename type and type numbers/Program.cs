﻿//Example of tyoe and type members
public class Customer
{
    #region fields
    private int _id;
    private string _firstName;
    private string _lastName;
    #endregion

    #region properties
    public int Id
    {
        get{ return _id; }
        set{ _id = value; }
    }
    public string FirstName
    {
        get{ return _firstName;}
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName;}
        set{ _lastName = value;}
    }
    #endregion properties

    #region methods
    public string GetFullName()
    {
        return this._firstName + " " + this._lastName;
    }
    #endregion methods
}




