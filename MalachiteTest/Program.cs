﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

ItemTest it = new ItemTest("asdfasdfasdfasdfasdf");
it.Properties.Put("123", "1234");
it.Properties.Put("adsf", "123");
it.Properties.Put("hg", "null");
it.Properties.Put("hg34", "3453567bgfg");

foreach (KeyValuePair<string, object> kv in it.Properties)
{
    Console.WriteLine(kv.Key + " " + kv.Value);
}

Console.WriteLine(it.Properties.HasNext());
Console.ReadLine();