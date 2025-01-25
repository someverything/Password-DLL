namespace PasswordDLL
{
    public class Password
    {
        //attributes
        public string PasswordValue { get; private set; }   
        public int Length => PasswordValue.Length;
        public int DigitCount => PasswordValue.Count(char.IsDigit);

        //ctor that initializes empty password
        public Password()
        {
            PasswordValue = string.Empty;
        }

        //Generates Password
        public void GeneratePassword(int length = 8)
        {
            var random = new Random();
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-";
            PasswordValue = new string(Enumerable.Range(0, length).Select(_ => validChars[random.Next(validChars.Length)]).ToArray());
        }

        //Returns Password
        public string GetPassword()
        {
            return PasswordValue;
        }

        // Return PasswordLength
        public int GetPasswordLength()
        {
            return Length;
        }

        // Returns PasswordDigitCount
        public int GetPasswordDigitCount()
        {
            return DigitCount;
        }

    }
}
