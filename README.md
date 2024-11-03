# GenericClasses #
## SecureEncryptMe ##
	string SecureEncrypt(string plainText[, string encryptionKey])
	string SecureDecrypt(string cipherText[, string encryptionKey])
## LogicMethods ##
	Istrue(<expression>)
	Returns true if expression is not 0 or empty
## DateRange ##
```
Class DateRange {
  DateTime Start;
  DateTime End;
}
```
## DateFunc ##
	DateTime GetMonthEnd(DateTime date) 
	DateRange GetMonthRange(DateTime date)
	DateRange GetQuarterRange(DateTime thisDate)
	DateRange GetWeekRange(DateTime date)
	DateRange GetYearRange(DateTime date)

 # Other Things #
 Written using C# v 12 +
 Code should be framework and platform independent

 Licensed under [MIT Licence](https://opensource.org/license/mit)
 
  
