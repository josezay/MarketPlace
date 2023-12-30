global using Xunit;
using Marketplace.Tests;

var moneyTest = new MoneyTest();
moneyTest.Money_objects_with_the_same_amount_should_be_equal();
moneyTest.Sum_of_money_gives_full_amount();