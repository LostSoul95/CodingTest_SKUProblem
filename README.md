SKU problem - This solution contains a console application along with an Xunit framework based testing approach.

Entrypoint just allows you to enter number of items in your order and each items of a specific type.

This solution contains interface implemenation with the logic being driven by the service layer.

The Test Solution mocks the service layer and compares the expected output with the real output. I have included the successful cases where the expected results equal to real results.

Test Solution Contains couple of test cases where the expected value from input is not equal to the computed value. This is done intentionally to show the legitamacy of the test cases. If assertion shows that expected value is not equal to real value then we consider it a success; else a failure.

The Sceenshot for same is the given url : [![test-cases.png](https://i.postimg.cc/wxJYr6xJ/test-cases.png)](https://postimg.cc/149dn1q5)
