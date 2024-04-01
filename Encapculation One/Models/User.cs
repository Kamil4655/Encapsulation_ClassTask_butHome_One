namespace ConsoleApp1.Models;

internal class User
{
    string _name = "YYY";
    string _surname = "XXX";
    string _userName;
    string _password = "12345678";
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (CheckLetter(value.Trim()) && value.Length > 2 && value.Length < 25)
            {
                _name = Capitalize(value);
            }
            else
            {
                Console.WriteLine("Ad yalnisdir.");
            }
        }
    }
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (CheckLetter(value.Trim()))
            {
                _surname = Capitalize(value);
            }
            else
            {
                Console.WriteLine("Ad yalnisdir.");
            }
        }
    }
    public string Username
    {
        get
        {
            return _userName;
        }
    }
    public string Password
    {
        set
        {
            if (value.Length > 8 && CheckLower(value) && CheckUpper(value) && CheckDigit(value))
            {
                _password = value;
            }
        }
    }


    public User(string name, string surname)
    {
        Name = name;
        Surname = surname;
        _userName = String.Concat(Name.Substring(0, 5), ".", Surname.Substring(0, 10));
    }
    private string Capitalize(string name)
    {
        name = name.Trim();
        return String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());

         name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        return name;
    }
    private bool CheckLetter(string name)
    {

        for (int i = 0; i < name.Length; i++)
        {
            if (!Char.IsLetter(name[i]))
            {
                return false;
            }
        }
        return true;
    }
    private bool CheckLower(string lower)
    {
        for (int i = 0; i < lower.Length; i++)
        {
            if (Char.IsLower(lower[i]))
            {
                return true;
            }
        }
        return false;
    }
    private bool CheckUpper(string upper)
    {
        for (int i = 0; i < upper.Length; i++)
        {
            if (Char.IsUpper(upper[i]))
            {
                return true;
            }
        }
        return false;
    }
    private bool CheckDigit(string dig)
    {
        for (int i = 0; i < dig.Length; i++)
        {
            if (Char.IsDigit(dig[i]))
            {
                return true;
            }
        }
        return false;
    }
    public void ChangePass(string oldpass, string newpass)
    {
        if (oldpass == _password)
        {
            Password = newpass;
        }

    }

}
