using MiniJSON;

var jsonString = "{ \"array\": [1.44,2,3], " +
                 "\"object\": {\"key1\":\"value1\", \"key2\":256}, " +
                 "\"string\": \"The quick brown fox \\\"jumps\\\" over the lazy dog \", " +
                 "\"unicode\": \"\\u3041 Men\u00fa sesi\u00f3n\", " +
                 "\"int\": 65536, " +
                 "\"float\": 3.1415926, " +
                 "\"bool\": true, " +
                 "\"null\": null }";

var dict = Json.Deserialize(jsonString) as Dictionary<string, object>;