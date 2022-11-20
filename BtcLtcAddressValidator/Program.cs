using BtcLtcAddressValidator;


//legacy
System.Console.WriteLine(AddressValidator.IsValidAddress("mfkJD2aHzWcHsz559siHb9YBu4Pc1MQkNH", "btc", true));

//segwit
System.Console.WriteLine(AddressValidator.IsValidAddress("tb1qngvrltppwep5s499xg6dcm4ej6xmwl4pynjdtf", "btc", true));

//p2sh
System.Console.WriteLine(AddressValidator.IsValidAddress("2NGEvtRbs3yvff3dbeXz5H8eUmBg7Dbztbt", "btc", true));

//not working for taproot
//System.Console.WriteLine(AddressValidator.IsValidAddress("tb1pa5xg5y88pq32wg5uanmx53flzua6n2dxq94p24zm0p57f8hn3d3saqkc7j", "btc", true));
