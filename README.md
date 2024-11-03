# GenericClasses
SecureEncryptMe:
  string SecureEncrypt(<string plainText>, <string encryptionKey>)
  string SecureDecrypt(<string cipherText>, <string encryptionKey>)
LogicMethods
  Istrue(<expression>)
    Returns true if expression is not 0 or empty
Class DateRange {
  <DateTime Start>
  <DateTime End>
DateFunc
  DateTime GetMonthEnd(<DateTime date>) 
  DateRange GetMonthRange(<DateTime date>)
  DateRange GetQuarterRange(<DateTime thisDate>)
  DateRange GetWeekRange(<DateTime date>)
  DateRange GetYearRange(<DateTime date>)
  
